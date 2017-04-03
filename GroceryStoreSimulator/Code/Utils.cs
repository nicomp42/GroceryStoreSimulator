/*****************************************************************
 * Grocery Store Simulator
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * University of Cincinnati Clermont College
 * 
update tProduct set ProductImage = (
SELECT 1, 'test', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\nicomp\Google Drive\GroceryStoreSimulator\GroceryStoreSimulator\Images', Single_Blob) as image)
where ProductID = 503 * 
 * 
 * ***************************************************************/
// http://support.microsoft.com/kb/301240

using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Text;

namespace GroceryStoreSimulator {
    /// <summary>
    /// Utilities for use throughout the application
    /// </summary>
    public class Utils {
        private static Char[] letters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' }; // lame.
        private static Object thisLock = new Object();
        /// <summary>
        /// Constructor
        /// </summary>
        public Utils() {
        }
        public static String GetRandomDate(Random r) {
            String myDate = "";
            if (Config.throughDate == Config.startDate) {
                myDate = Config.startDate.ToShortDateString();
            } else {
                // We need a random date between Config.startDate and Config.endDate, inclusive
                double dateDiff = (Config.throughDate - Config.startDate).TotalDays;
                int days = Convert.ToInt32(Math.Round(r.NextDouble() * dateDiff, 0));
                myDate = Config.startDate.AddDays(days).ToShortDateString();
            }
            return myDate;
        }
        public static String GetRandomTime(Random r) {
           return r.Next(23) + ":" + r.Next(60) + ":" + r.Next(60) + "." + r.Next(1000);
        }

        public static void Log(String message) {
            // ToDo: implement this
            Console.WriteLine(message);
        }
        /// <summary>
        /// Compute a randomly constructed string of upper case letters
        /// </summary>
        /// <param name="length">The desired length of the string</param>
        /// <returns>The generated string</returns>
        public static StringBuilder GetRandomString(int length, Random r) {
            StringBuilder tmp = new StringBuilder();
            for (int i = 0; i < length; i++) {
                tmp.Append(letters[r.Next(letters.Length-1)]);
            }
            return tmp;
        }

        public static double GetMostRecentPricePerSellableUnit(int ProductID, int StoreID, SqlConnection connection) {
            double pricePerSellableUnit = 0;
            using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("fGetCurrentPricePerSellableUnit", connection)) {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Money).Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.AddWithValue("@ProductID", ProductID);
                cmd.Parameters.AddWithValue("@StoreID", StoreID);
                try {
                    cmd.ExecuteNonQuery();
                    pricePerSellableUnit = Convert.ToDouble(cmd.Parameters["@RETURN_VALUE"].Value.ToString());
                } catch (Exception ex) {
                    pricePerSellableUnit = 1.42;            // Inelegant recovery
                    Utils.Log(ex.Message);
                }
            }
            return pricePerSellableUnit;
        }
        /// <summary>
        /// Get a random product ID from tProduct
        /// </summary>
        /// <param name="r">The random number generator</param>
        /// <param name="productID_count">The number of products in tProduct</param>
        /// <returns>The randomly generated product ID</returns>
        public static int GetRandomProductID(Random r, int productID_count) {
            return (int)Utils.MyDLookup("ProductID",
                                        "(SELECT ROW_NUMBER() OVER (ORDER BY productID) AS RowNum, * FROM tProduct) sub ",
                                        " RowNum = " + (r.Next(productID_count) + 1),
                                        "");
        }
        /// <summary>
        /// Get a random store ID from tStore
        /// </summary>
        /// <param name="r">The random number generator</param>
        /// <param name="productID_count">The number of stores in tStore</param>
        /// <returns>The randomly generated store ID</returns>
        public static int GetRandomStoreID(Random r, int storeID_count) {
            return (int)Utils.MyDLookup("StoreID",
                                        "(SELECT ROW_NUMBER() OVER (ORDER BY storeID) AS RowNum, * FROM tStore) sub ",
                                        " RowNum = " + (r.Next(storeID_count) + 1),
                                        "");
        }

        /// <summary>
        /// The most amazing method in the world. 
        /// </summary>
        /// <param name="pTarget">The attribute to read from the cursor</param>
        /// <param name="pDomain">The selection logic for the set of records in the cursor</param>
        /// <param name="pCriteria">The filter to be applied to the domain</param>
        /// <param name="pAggregate">The aggregate to be applied to the domain</param>
        /// <returns></returns>
        public static object MyDLookup(String pTarget, String pDomain, String pCriteria, String pAggregate) {
            lock (thisLock) {
                String criteria;
                //bool keepGoing;
                String aggregate;
                String asName;
                object result = null;
                System.Data.SqlClient.SqlDataReader reader = null;

                if (pAggregate.Trim().Length != 0) {
                    aggregate = pAggregate;      // MAX, MIN, etc.
                    asName = "foo";              // We need a unique name because this is a calculated field
                } else {
                    aggregate = "";
                    asName = "foo";              // We can't use pTarget here because it causes an SQL "Circular Reference" error
                }
                //  If the domain is a select statement, don't do anything to it. We can't perform an agregate function on SQL.
                //    Whoever calls this function should configure the SQL to have the desired record at the top of the cursor
                //    before calling this function.
                if ((pDomain.Length > 7) && (pDomain.Substring(0, 6) == "SELECT")) {    // subString is zero-based
                    criteria = pDomain;
                    asName = pTarget;
                } else {
                    criteria = "SELECT " + aggregate + "(" + pTarget + ") AS " + asName + " FROM " + pDomain;
                    if (pCriteria == "") {
                    } else {
                        criteria = criteria + " WHERE " + pCriteria;
                    }
                    criteria = criteria + ";";
                }
                //keepGoing = true;

                try {
                    //MySqlCommand command = new MySqlCommand(criteria, myConnection);
                    //try { Config.myConnection.Close(); } catch (Exception e) { }      // todo: Do we need to close the connection first and reopen it?
                    CheckConnection();
                    System.Data.SqlClient.SqlCommand command = Config.myConnection.CreateCommand();
                    command.CommandText = criteria;

//                  reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    reader = command.ExecuteReader();

                    if (reader.HasRows) {
                        reader.Read();       // Get the first row. We always assume it's the first row, in this function
                        result = reader.GetValue(0);
                    } else {
                        result = null;
                    }

                    reader.Close();
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                    result = null;                // null means we failed
                    try { reader.Close(); } catch (Exception ex) {Utils.Log(ex.Message); }
                }
                return result;
            }
    }
        /// <summary>
        /// Make sure the database connection is open
        /// </summary>
        /// <returns>true if the connection is open, false otherwise</returns>
        public static bool CheckConnection() {
            // todo: Add a select case to handle all the possible states of myConnection.State
            bool status = true, justGotConnString = false;

            if (Config.myConnection == null) {
                Config.myConnection = new System.Data.SqlClient.SqlConnection(Config.connectionString);
                justGotConnString = true;
            }
            if (Config.myConnection.State != System.Data.ConnectionState.Open) {
                if (!justGotConnString) { Config.myConnection.ConnectionString = Config.connectionString; }
                try {
                    Config.myConnection.Open();
                } catch (Exception ex) {
                    status = false;
                    Utils.Log(ex.Message);
                }
            }
            return status;
        }
        /// <summary>
        /// Execute an action query. The name , "Non Query" reflects what Microsoft uses in the .Net framework
        /// </summary>
        /// <param name="pSQL">The SQL to be executed</param>
        /// <param name="pCommandType">Text or Stored Procedure</param>
        /// <param name="pSQLCmd"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(String pSQL,
                                          System.Data.CommandType pCommandType,
                                          System.Data.SqlClient.SqlCommand pSQLCmd,
                                          List<SqlParameter> parameters) {
            int status = -1;
            try {
                // I don't know why the Framework method is called "ExecuteNonQuery" but I named this
                //  method the same, to reduce confusion. The name should be "ExecuteActionQuery"

                CheckConnection();
                System.Data.SqlClient.SqlCommand objCmd = Config.myConnection.CreateCommand();
                objCmd.CommandText = pSQL;
                objCmd.CommandType = pCommandType;      // The default is 'text', which implies an SQL string
                objCmd.Parameters.Clear();          // Just in case we used any the last time we called this
                if (parameters != null) {
                    foreach(SqlParameter parameter in parameters) {objCmd.Parameters.Add(parameter);}
                }
                objCmd.ExecuteNonQuery();
            } catch (Exception ex) {
                try {
                    //ErrorLog.LogEvent(pSQL + " ERROR in ExcecuteNonQuery() : " + ex.Message, 0,  0);
                    System.Console.WriteLine(DateTime.Now + " ExecuteNonQuery() : " + ex.Message + " : " + pSQL);
                    status = 1;
                } catch (Exception ex1) {
                    status = 0;
                    Utils.Log(ex1.Message);
                }
            } finally {}
            return status;
        }

        /// <summary>
        /// Enclose a string in double quotes.
        /// </summary>
        /// <param name="s">The string to be quoted</param>
        /// <returns>The quoted string</returns>
        public static String QuoteMe(String s) {
            return (Config.doubleQuote + s + Config.doubleQuote);
        }

        /// <summary>
        /// Enclose a string in single quotes. SQL Server likes single quotes.
        /// </summary>
        /// <param name="s">The string to be quoted</param>
        /// <returns>The quoted string</returns>
        public static String QuoteMeForSQL(String s) {
            return ("'" + s + "'");
        }

        public static String FormatProductForPrint(int productID) {
            String product = null;
            int nameID = Convert.ToInt32( Utils.MyDLookup("NameID", "tProduct", "ProductID = " + Convert.ToString(productID),""));
            int manufacturerID = Convert.ToInt32( Utils.MyDLookup("ManufacturerID", "tProduct", "ProductID = " + Convert.ToString(productID),""));
            product = Convert.ToString(Utils.MyDLookup("Description",  "tProduct",      "ProductID = "      + Convert.ToString(productID),"")) + ", " + 
                      Convert.ToString(Utils.MyDLookup("Name",         "tName",         "NameID = "         + Convert.ToString(nameID),"")) + ", " + 
                      Convert.ToString(Utils.MyDLookup("manufacturer", "tmanufacturer", "manufacturerID = " + Convert.ToString(manufacturerID),""));

            return product;
        }
    }
}