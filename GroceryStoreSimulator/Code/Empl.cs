using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreSimulator.Code {
    /// <summary>
    /// Employee Utilities, see tEmpl in the database
    /// </summary>
    class Empl {

        public static void MakeAllEmplAvailableToWork(DateTime startDate) {
            DateTime myStartDate;
            if (startDate == null) { myStartDate = Config.earliestPossibleDate; } else { myStartDate = startDate; }
            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() {ParameterName = "@StartDate", SqlDbType = SqlDbType.DateTime, Value = startDate.ToString()}
            };
            Utils.ExecuteNonQuery("spCopyEmplHistoryFromEmplTable", CommandType.StoredProcedure, null, parameters);
        }
        public static int AddRandomEmplAndMakeThemAvailableForWork(int storeID, DateTime dateOfTransaction, SqlConnection connection, Random r) {
            int emplID = 0;
            emplID = AddRandomEmpl(storeID, r, connection);
            // We don't know who we just added. 
            return emplID;
        }
        /// <summary>
        /// Add an employee to the database. Calls spAddEmpl stored procedure
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="empl"></param>
        /// <param name="storeID"></param>
        /// <param name="emplTitleID"></param>
        /// <param name="emplStatusID"></param>
        /// <returns>EmplID of record added to tEmpl, or 0 on error</returns>
        public static int AddEmployee(SqlConnection connection, String firstName, String lastName, String empl, int storeID, int emplTitleID, int emplStatusID) {
            int emplID = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spAddEmpl";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("firstName", firstName);
            cmd.Parameters.AddWithValue("lastName", lastName);
            cmd.Parameters.AddWithValue("empl", empl);
            cmd.Parameters.AddWithValue("storeID", storeID);
            cmd.Parameters.AddWithValue("emplTitleID", emplTitleID);
            cmd.Parameters.AddWithValue("emplStatusID", emplStatusID);
            try {
                cmd.ExecuteNonQuery();
                // figure out the emplID that we just added. This is hokey.
                emplID = Convert.ToInt32(Utils.MyDLookup("emplID", "tEmpl", " empl = " + Utils.QuoteMeForSQL(empl),""));    // empl is a natural key. 
            } catch (Exception ex) {
                emplID = 0;
                Console.WriteLine(ex.Message);
            }
            return emplID;
        }
        /// <summary>
        /// Add a random employee to the database. Pick a name from the randomNames.csv file in the project.
        /// </summary>
        /// <param name="storeID_new">Store ID of the store where the employee should be assigned, or 0 if you want it randomly chosen</param>
        /// <param name="r">Random number generator</param>
        /// <param name="connection">SQL Connection</param>
        /// <returns>Empl ID of the record in tEmpl, or zero on error</returns>
        public static int AddRandomEmpl(int storeID_new, Random r, SqlConnection connection) {
            int emplID = 0;
            try {
                if (Config.emplList.Count > 0) {
                    int storeID = storeID_new;
                    String firstName = null, lastName = null;
                    int emplNameCount;
                    emplNameCount = Config.emplList.Count;
                    int nameIdx = r.Next(emplNameCount);
                    firstName = Config.emplList[nameIdx].firstName;
                    nameIdx = r.Next(emplNameCount);
                    lastName = Config.emplList[nameIdx].lastName;
//                  String empl = firstName.Substring(0, 1) + lastName.Substring(0, 1) + Utils.GetRandomString(5, r);
                    String empl = firstName.Substring(0, 1) + lastName.Substring(0, 1) + Utils.GetRandomString(15, new Random());    // This has to be unique. 
                    if (storeID == 0) {
                        storeID = (int)Utils.MyDLookup("storeID",
                                                           "(SELECT ROW_NUMBER() OVER (ORDER BY storeID) AS RowNum, * FROM tStore) sub ",
                                                           " RowNum = " + (r.Next(DefaultValues.storeID_count) + 1),
                                                           "");
                    }
                    int emplTitleID = (int)Utils.MyDLookup("emplTitleID",
                                                           "(SELECT ROW_NUMBER() OVER (ORDER BY emplTitleID) AS RowNum, * FROM templTitle) sub ",
                                                           " RowNum = " + (r.Next(DefaultValues.emplTitleID_count) + 1),
                                                           "");
                    int emplStatusID = (int)Utils.MyDLookup("emplStatusID",
                                                            "(SELECT ROW_NUMBER() OVER (ORDER BY emplStatusID) AS RowNum, * FROM tEmplStatus) sub ",
                                                            " RowNum = " + (r.Next(DefaultValues.emplStatusID_count) + 1),
                                                            "");
                    emplID = AddEmployee(connection, firstName, lastName, empl, storeID, emplTitleID, emplStatusID);
                }
            } catch (Exception ex) {
                Utils.Log(ex.Message);
                emplID = 0;         // oopsy
            }
            return emplID;
        }

        /// <summary>
        /// Check the status of an employee at a specific date/time. Is the employee available to work?
        /// </summary>
        /// <param name="storeID">EmplID from the database</param>
        /// <returns>True if employee is available for work, false otherwise</returns>
        public static bool IsEmplAvailableForWork(int emplID, DateTime dateTime, SqlConnection connection) {
            SqlDataReader reader = null;
            bool status = false;        // It's possible there is no status record for this employee at this date/time. Therefore the employee would not be available for work!
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("emplID", emplID));
            cmd.CommandText = "SELECT CanWork from fGetCurrentEmplStatusByDateTime(" + emplID + ", " + Utils.QuoteMeForSQL(dateTime.ToString()) +  ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            try {
                reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    bool canWork = Convert.ToBoolean(reader.GetValue(0));
                    status = canWork;
                }
            } catch (Exception ex) {
                Utils.Log(ex.Message);
                status = false;
            } finally {
                try { reader.Close(); } catch (Exception ex) { Utils.Log(ex.Message); }
            }
            return status;
        }

        /// <summary>
        /// Check the current status of an employee. Is the employee available to work?
        /// </summary>
        /// <param name="storeID">EmplID from the database</param>
        /// <returns>True if employee is available for work, false otherwise</returns>
        public static bool IsEmplAvailableForWork(int emplID, SqlConnection connection) {
            SqlDataReader reader = null;
            bool status = true;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("emplID", emplID));
            cmd.CommandText = "SELECT CanWork from fGetCurrentEmplStatus(" + emplID + ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            try {
                reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    bool canWork = Convert.ToBoolean(reader.GetValue(0));
                    status = canWork;
                }
            } catch (Exception ex) {
                Utils.Log(ex.Message);
                status = false;
            } finally {
                try { reader.Close(); } catch (Exception ex) {Utils.Log(ex.Message);}
            }
            return status;
        }
        public static void RandomizeWorkStatusForAllEmployees(SqlConnection connection, Random r,  Func<String, int>Write) {
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * from [fGetCurrentEmplStatusForAllEmpl]()";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            int emplID, emplStatusID = 0;
            bool canWork, isEmployed, IsPermanent;
            // Columns in the result set: emplID, startDate, status, canWork, isEmployed, IsPermanent
            try {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    if (!((r.Next(10)+1) != 1)) continue;                   // Only change 10% of the employees each time we run this logic
                    emplID = Convert.ToInt32(reader.GetValue(0));           // Employee ID. Indexing into the reader is zero based
                    canWork = Convert.ToBoolean(reader.GetValue(3));
                    isEmployed = Convert.ToBoolean(reader.GetValue(4));
                    IsPermanent = Convert.ToBoolean(reader.GetValue(5));
                    emplStatusID = Convert.ToInt32(reader.GetValue(6));

                    if (IsPermanent == false) {     // Don't change employee status if current status is permanent.
                        int emplStatusID_new;
                        emplStatusID_new = GetRandomEmplStatus(r);
                        if (emplStatusID != emplStatusID_new) {
                            // Only update the status if (the new status is non-permanent) or (1/50th of the time if the new status is permanent). We don't want to loose too many employees.
                            if (((Boolean)Utils.MyDLookup("IsPermanent", "tEmplStatus", "EmplStatusID = " + Convert.ToString(emplStatusID_new), "") == false) || (r.Next(50) == 1)) {
                                // Only update the status if (it's updating to "Can Work") or (1/10 of the time the new status is can't work). We don't want too many employees not available for work.
                                if (((Boolean)Utils.MyDLookup("CanWork", "tEmplStatus", "EmplStatusID = " + Convert.ToString(emplStatusID_new), "") == true) || (r.Next(10) == 1)) {
                                    // ToDo: The DateTime needs to be relative to the configuration of the current simulation!
                                    UpdateEmplStatus(emplID, emplStatusID_new, null);
                                    String msg = "EmplID = " + emplID + ": " +
                                                  FormatEmplForDisplay(emplID) +
                                                  " old status = " + Utils.MyDLookup("emplStatus", "tEmplStatus", "EmplStatusID = " + Convert.ToInt32(emplStatusID), "") +
                                                  ", new status = " + Utils.MyDLookup("emplStatus", "tEmplStatus", "EmplStatusID = " + Convert.ToInt32(emplStatusID_new), "");
                                    Write.Invoke(msg);
                                }
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Utils.Log(ex.Message);
            } finally {
                try { reader.Close(); } catch (Exception ex) { Utils.Log(ex.Message); }
            }
        }
        /// <summary>
        /// Update the employee status of a store employee
        /// </summary>
        /// <param name="emplID">Primary key in tEmpl</param>
        /// <param name="emplStatusID">Primary key in tEmplStatus</param>
        /// <param name="startDate">Date that this empl status takes effect, or null to default to current date</param>
        /// <returns>True if status was updated, false otherwise</returns>
        public static bool UpdateEmplStatus(int emplID, int emplStatusID, DateTime? startTime) {
            bool status = true;

            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() {ParameterName = "@EmplID", SqlDbType = SqlDbType.Int, Value = Convert.ToString(emplID)},
                new SqlParameter() {ParameterName = "@EmplStatusID", SqlDbType = SqlDbType.Int, Value = Convert.ToString(emplStatusID)},
                // Use the method argument or use the current date if the method parameter is null
                (startTime == null) ?
                    new SqlParameter() {ParameterName = "@StartDate", SqlDbType = SqlDbType.DateTime, Value = DateTime.Now} :
                    new SqlParameter() {ParameterName = "@StartDate", SqlDbType = SqlDbType.DateTime, Value = startTime}
            };
            Utils.ExecuteNonQuery("spUpdateEmplStatus", CommandType.StoredProcedure, null, parameters);
            return status;
        }
        /// <summary>
        /// Grab a random employee status from tEmplStatus table
        /// </summary>
        /// <param name="r">Random number generator</param>
        /// <returns>Random emplStatusID that was grabbed</returns>
        public static int GetRandomEmplStatus(Random r) {
            int emplStatusID = (int)Utils.MyDLookup("emplStatusID",
                                                    "(SELECT ROW_NUMBER() OVER (ORDER BY emplStatusID) AS RowNum, * FROM tEmplStatus) sub ",
                                                    " RowNum = " + (r.Next(DefaultValues.emplStatusID_count) + 1),
                                                    "");
            return emplStatusID;
        }
        /// <summary>
        /// Look up employee info and format something to display on a window or report.
        /// </summary>
        /// <param name="EmplID"></param>
        /// <returns></returns>
        public static String FormatEmplForDisplay(int EmplID) {
            return Convert.ToString(Utils.MyDLookup("(RTRIM(LTRIM(firstName)) + ' ' + RTRIM(LTRIM(lastName)))", "tEmpl", "EmplID = " + Convert.ToString(EmplID), ""));
        }
    }
}
