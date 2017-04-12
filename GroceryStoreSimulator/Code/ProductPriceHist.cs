using GroceryStoreSimulator.Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreSimulator {
    class ProductPriceHist {

        /// <summary>
        /// Process random price changes in random products & stores. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="r"></param>
        public static Boolean ProcessProductPrices(SqlConnection connection, Random r, TextBox txtInfo, String description, int amount) {
            txtInfo.AppendText(Environment.NewLine + description);
            // Update 5% of the products/stores, roughly
            int totalUpdates = Convert.ToInt32((DefaultValues.storeID_count * DefaultValues.productID_count) * .05);
            for (int i = 0; i < totalUpdates; i++) {
                AddProductPriceHist(r, txtInfo);
            }
            return true;
        }

        /// <summary>
        /// Zap the tProductPrice table and repopulate it with the original prices from tProduct.InitialPricePerSellableUnit
        /// This is very destructive and should be used carefully.
        /// </summary>
        /// <param name="startDate">The date when the price change should take effect. Use Config.earliestPossibleDate for the earliest possible date
        public static void InitializeProductPriceHistAndCopyFromFromProductTable(DateTime startDate) {
            DateTime myStartDate;
            if (startDate == null) {myStartDate = Config.earliestPossibleDate;} else { myStartDate = startDate; }
            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() {ParameterName = "@StartDate", SqlDbType = SqlDbType.DateTime, Value = startDate.ToString()}
            };
            Utils.ExecuteNonQuery("spInitializeProductPriceHistAndCopyFromFromProductTable", CommandType.StoredProcedure, null, parameters);
        }
        /// <summary>
        /// Populate tProductPriceHist with the original prices from tProduct.InitialPricePerSellableUnit
        /// </summary>
        /// <param name="startDate">The date when the price change should take effect. Use Config.earliestPossibleDate for the earliest possible date
        public static void CopyFromFromProductTableIntoProductPriceHist(DateTime startDate)
        {
            DateTime myStartDate;
            // Use the earliest possible start date if the calling method did not provide a start date
            if (startDate == null) { myStartDate = Config.earliestPossibleDate; } else { myStartDate = startDate; }
            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() {ParameterName = "@StartDate", SqlDbType = SqlDbType.DateTime, Value = startDate.ToString()}
            };
            Utils.ExecuteNonQuery("spCopyProductPriceHistFromProductTable", CommandType.StoredProcedure, null, parameters);
        }


        /// <summary>
        /// Update the prices of all products in all stores. Yowza.
        /// </summary>
        /// <param name="r"></param>
        public static void UpdateAllProductStorePrices(Random r, TextBox txtInfo, DateTime startDate) {
            SqlDataReader reader = null;
            //bool status = true;
            SqlCommand cmd = new SqlCommand();
            // A convoluted query to get all the most current prices for all product/store combinations
            cmd.CommandText = "SELECT dbo.tProductPriceHist.ProductPriceHistID as ID, dbo.tProductPriceHist.PricePerSellableUnit AS price, ProductID, StoreID FROM dbo.tProductPriceHist INNER JOIN (SELECT MAX(StartDate) AS maxStartDate, ProductID AS pID, StoreID AS sID FROM dbo.tProductPriceHist AS tProductPriceHist_1 GROUP BY ProductID, StoreID) AS derivedtbl_1 ON dbo.tProductPriceHist.ProductID = derivedtbl_1.pID AND dbo.tProductPriceHist.StoreID = derivedtbl_1.sID AND dbo.tProductPriceHist.StartDate = derivedtbl_1.maxStartDate";
            cmd.CommandType = CommandType.Text;
            Utils.CheckConnection();
            SqlConnection connection;
            connection = Config.myConnection;
            cmd.Connection = connection;
            try {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    int productPriceHistID;
                    double pricePerSellableUnit;
                    productPriceHistID = Convert.ToInt32(reader.GetValue(0));
                    pricePerSellableUnit = Convert.ToDouble(reader.GetValue(1));
                    double newPricePerSellableUnit;
                    newPricePerSellableUnit = AdjustPricePerSellableUnit(pricePerSellableUnit, r);
                    txtInfo.AppendText(productPriceHistID + ": " + pricePerSellableUnit + ", " + newPricePerSellableUnit + Environment.NewLine);
                    AddProductPriceHist(reader.GetInt32(2), reader.GetInt32(3), startDate.ToString(), newPricePerSellableUnit, connection, txtInfo);
                }
            } catch (Exception ex) {
                //status = false;
                Utils.Log(ex.Message);
            } finally {
                try { reader.Close(); } catch (Exception ex) { Utils.Log(ex.Message); }
            }
        }

        /// <summary>
        /// Add a new current (slightly random) price for a random product/store. 
        /// </summary>
        /// <param name="r"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static bool AddProductPriceHist(Random r, TextBox txtInfo) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            Utils.CheckConnection();
            SqlConnection connection;
            connection = Config.myConnection;
            bool result = true;
            // We need a random Product, Store, Date, and PricePerSellableUnit
            int productID = Utils.GetRandomProductID(r, DefaultValues.productID_count);
            int storeID = Utils.GetRandomStoreID(r, DefaultValues.storeID_count);
            String startDate = DateTime.Now.ToString();
            double pricePerSellableUnit = Utils.GetMostRecentPricePerSellableUnit(productID, storeID, connection );
            pricePerSellableUnit = AdjustPricePerSellableUnit(pricePerSellableUnit, r);
            AddProductPriceHist(productID, storeID, startDate, pricePerSellableUnit, connection, txtInfo);
            return result;
        }
        /// <summary>
        /// Apply a little randomness to the price of a product
        /// </summary>
        /// <param name="pricePerSellableUnit">The starting value of the product</param>
        /// <returns>The adjusted price of the product</returns>
        private static double AdjustPricePerSellableUnit(double pricePerSellableUnit, Random r) {
            // The price will go up a little or down a little. 
            double adjustment = r.NextDouble() * Config.maxPriceChangePct;       // Limit the price change to about 2% up or down.
            bool upOrDown = (r.Next(6) % 2 == 0) ? true : false;
            adjustment = upOrDown ? 0 - adjustment : adjustment;
            pricePerSellableUnit *= 1 + adjustment;
            pricePerSellableUnit = Math.Round(pricePerSellableUnit, 2);     // Round to 2 decimal places.
            return pricePerSellableUnit;
        }

        public static bool AddProductPriceHist(int ProductID, Random r, SqlConnection connection) {
            bool result = true;

            return result;
        }
        public static bool AddProductPriceHist(int ProductID, int StoreID, Random r, SqlConnection connection) {
            bool result = true;

            return result;
        }
        public static bool AddProductPriceHist(int productID, int storeID, String startDate, double pricePerSellableUnit, SqlConnection connection, TextBox txtInfo) {
            bool result = true;
            try {
                int productPriceHistID;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[spAddProductPriceHist]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;

                // The output parameter must be FIRST in the Parameters collection? https://support.microsoft.com/en-us/kb/308621
                cmd.Parameters.Add("productPriceHistID", SqlDbType.Int);
                cmd.Parameters["productPriceHistID"].Direction = ParameterDirection.Output;

                cmd.Parameters.Add(new SqlParameter("ProductID", productID));
                cmd.Parameters.Add(new SqlParameter("StoreID", storeID));
                cmd.Parameters.Add(new SqlParameter("StartDate", startDate));
                cmd.Parameters.Add(new SqlParameter("PricePerSellableUnit", pricePerSellableUnit));

                cmd.ExecuteNonQuery();

                // This could fail if the record was not added to tProductPriceHist...
                productPriceHistID = (int)cmd.Parameters["ProductPriceHistID"].Value;
                String tmp;
                Product.FormatProductIDForDisplay(productID, out tmp);
                Write(txtInfo, tmp);
            } catch (Exception ex) {
                result = false;
                Write(txtInfo, "Error adding product price change: " + ex.Message + Environment.NewLine);
            }
            return result;
        }
        /// <summary>
        /// Write a message to a text box, if a text box was provided. 
        /// </summary>
        /// <param name="txtInfo"></param>
        /// <param name="message"></param>
        private static void Write(TextBox txtInfo, String message) {
            if (txtInfo != null) {
                txtInfo.AppendText(message + Environment.NewLine);
            }
        }
    }
}
