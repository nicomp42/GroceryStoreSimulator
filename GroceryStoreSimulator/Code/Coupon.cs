/*****************************************************************
 * Grocery Store Simulator
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * University of Cincinnati Clermont College
 * ***************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreSimulator {
    /// <summary>
    /// Coupon Stuff
    /// </summary>
    class Coupon {
        private TextBox txtCouponResults;
        private Label lblCouponStatus;
        private Random r;
        private SqlConnection connection;
        private int numOfCouponsToAdd;
        //private static Guid guid;
        private  int couponSourceID_count, discountTypeID_count, productID_count;

        /// <summary>
        /// Use this constructor to get ready for a thread that will generate coupons
        /// </summary>
        /// <param name="numOfCouponsToAdd"></param>
        /// <param name="connection"></param>
        /// <param name="r"></param>
        /// <param name="txtResults"></param>
        /// <param name="lblStatus"></param>
        public Coupon(int numOfCouponsToAdd, SqlConnection connection, Random r, TextBox txtCouponResults, Label lblCouponStatus) {
            this.numOfCouponsToAdd = numOfCouponsToAdd;
            this.r = r;
            this.connection = connection;
            this.txtCouponResults = txtCouponResults;
            this.lblCouponStatus = lblCouponStatus;
        }

        /// <summary>
        /// Entry point for the thread.
        /// </summary>
        public void StartThread() {
            GenerateRandomCoupons();
        }
        /// <summary>
        /// Add random coupons to the database
        /// </summary>
        /// <param name="numOfCouponsToAdd"></param>
        /// <param name="r">Random number generator</param>
        /// <param name="connection">Connection object</param>
        /// <param name="txtCouponResults">Text Box to write interesting info into, or null</param>
        /// <param name="lblCouponStatus">Label to write status into, or null</param>
        /// <returns></returns>
        public int GenerateRandomCoupons() {

            int couponCount = 0; 
            int couponDetailCount = 0;
            int total = 0;
            computeDefaultValues();
            CouponParameters cp = new CouponParameters();
            SqlCommand cmd = new SqlCommand();
            bool keepGoing = true;
            for (int i = 0; i < numOfCouponsToAdd && keepGoing; i++) {
                // Add a Coupon record and some Coupon Detail records
                try {
                    computeRandomValuesForCoupon(cp, r);
                    cmd.CommandText = "spAddCouponAndDetail";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;
                    cmd.Parameters.Clear();
                    // The output parameter must be FIRST in the Parameters collection? https://support.microsoft.com/en-us/kb/308621
                    //cmd.Parameters.Add("@CouponID", SqlDbType.Int);
                    cmd.Parameters.Add(new SqlParameter("CouponID", cp.coupon));
                    cmd.Parameters["CouponID"].Direction = ParameterDirection.Output;
                    cmd.Parameters["CouponID"].SqlDbType = SqlDbType.Int;

                    cmd.Parameters.Add(new SqlParameter("Coupon", cp.coupon));
                    cmd.Parameters.Add(new SqlParameter("CouponSourceID", cp.couponSourceID));
                    cmd.Parameters.Add(new SqlParameter("CouponDescription", cp.couponDescription));
                    cmd.Parameters.Add(new SqlParameter("MaxQtyToPurchase", cp.maxQtyToPurchase));
                    cmd.Parameters.Add(new SqlParameter("MinQtyToPurchase", cp.minQtyToPurchase));
                    cmd.Parameters.Add(new SqlParameter("ProductID", cp.productID));
                    cmd.Parameters.Add(new SqlParameter("DiscountTypeID", cp.discountTypeID));
                    cmd.Parameters.Add(new SqlParameter("StartDate", cp.startDate));
                    cmd.Parameters.Add(new SqlParameter("ThroughDate", cp.throughDate));
                    cmd.Parameters.Add(new SqlParameter("PercentageDiscount", cp.percentageDiscount));
                    cmd.Parameters.Add(new SqlParameter("AmountOff", cp.amountOff));

                    cmd.ExecuteNonQuery();
                    couponCount++; couponDetailCount++;

                    WriteStatus(couponCount, couponDetailCount);
                    cp.couponID = (int)cmd.Parameters["CouponID"].Value;
                    Write("Coupon Added: CouponID = " + cp.couponID + ", Start Date = " + cp.startDate.ToShortDateString() + ", Product = " + Utils.FormatProductForPrint(cp.productID));
                } catch (Exception ex) {
                    Write("Coupon.GenerateRandomCoupon(): " + ex.Message);
                    keepGoing = false;
                }
            }
            return total;
        }
        /// <summary>
        /// Write a string to the UI
        /// </summary>
        /// <param name="message">The string to be written to the UI</param>
        private void Write(string message) {
            if (txtCouponResults != null) {
                txtCouponResults.AppendText(Environment.NewLine + message);
            }
        }
        public void WriteStatus(int couponCount, int couponDetailCount) {
            if (lblCouponStatus != null) {
                lblCouponStatus.Text = couponCount + " coupons, " + couponDetailCount + " coupon details";
            }
        }
        /// <summary>
        /// Get a random coupon detail that is available for a customer to use based on the current date and date range of the contents in tCoupon AND a specific product ID.
        /// If there is such a coupon. There may not be one.
        /// </summary>
        /// <returns>The Coupon Detail ID of the coupon in tCouponDetail</returns>
        public static int getRandomCouponDetailID(int productID, Random r, SqlConnection connection) {
            int couponDetailID = 0;
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("productID", productID));
            cmd.CommandText = "SELECT couponDetailID from fGetCouponDetailsCurrentlyOpenByProductID(" + productID + ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            try {
                reader = cmd.ExecuteReader();
                List<int> couponDetailIDList = new List<int>();
                while (reader.Read()) {
                    couponDetailIDList.Add(Convert.ToInt32(reader.GetValue(0)));
                }
                couponDetailID = couponDetailIDList[r.Next(couponDetailIDList.Count - 1)];
            } catch (Exception ex) {
                // todo: Handle this exception
                Utils.Log(ex.Message);
            } finally {
                try { reader.Close(); } catch (Exception ex) { Utils.Log(ex.Message); }
            }
            return couponDetailID;
        }

        /// <summary>
        /// Pick a random coupon based on a Coupon
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public static int GetRandomCoupon(Random r, int ProductID) {
            //int couponID = 0;
            throw new Exception("Coupon.GetRandomCoupon() not implemented");
            //return couponID;
        }

        /// <summary>
        /// Compute random record IDs for the random coupon we will add
        /// </summary>
        /// <param name="cp">The set of coupon parameters upon which to operate</param>
        public void computeRandomValuesForCoupon(CouponParameters cp, Random r) {
            // We need a unique value in the coupon attribute- it's the natural key
            cp.coupon = Convert.ToString(Guid.NewGuid());
            // Random Product
            cp.productID = (int)Utils.MyDLookup("productID",
                                                     "(SELECT ROW_NUMBER() OVER (ORDER BY productID) AS RowNum, * FROM tProduct) sub ",
                                                     " RowNum = " + (r.Next(productID_count) + 1),
                                                     "");
            cp.couponSourceID = (int)Utils.MyDLookup("couponSourceID",
                                                     "(SELECT ROW_NUMBER() OVER (ORDER BY couponSourceID) AS RowNum, * FROM tCouponSource) sub ",
                                                     " RowNum = " + (r.Next(couponSourceID_count) + 1),
                                                     "");

            cp.discountTypeID = (int)Utils.MyDLookup("discountTypeID",
                                                     "(SELECT ROW_NUMBER() OVER (ORDER BY discountTypeID) AS RowNum, * FROM tdiscountType) sub ",
                                                     " RowNum = " + (r.Next(discountTypeID_count) + 1),
                                                     "");
            int decrement = r.Next(30);
            int increment = r.Next(30);
            String startDate, throughDate;

            startDate = Utils.GetRandomDate(r);
            throughDate = Utils.GetRandomDate(r);
            if (r.Next() % 2 == 0) {
                cp.startDate = Convert.ToDateTime(startDate).AddDays(0 - decrement);
            } else {
                // Once in a while use the start date of the date range rather than a random date
                cp.startDate = Config.startDate.AddDays(0 - decrement);
            }
            cp.throughDate = Convert.ToDateTime(throughDate).AddDays(increment);
            if (cp.startDate > cp.throughDate) { DateTime tmp = cp.startDate; cp.startDate = cp.throughDate; cp.throughDate = tmp; }
            cp.couponDescription = " ";
            cp.minQtyToPurchase = 1;
            cp.maxQtyToPurchase = Convert.ToInt32(1 + (.019 * r.Next(909)));
            cp.percentageDiscount = 1 + r.Next(90);
            try {
                cp.amountOff = Convert.ToDouble(Utils.MyDLookup("InitialPricePerSellableUnit", "tProduct", "ProductID = " + cp.productID, null));
            } catch (Exception ex) { cp.amountOff = .25 + (1.00 * r.NextDouble()); Utils.Log(ex.Message); }  // Default to some random value between .25 and $1.25 if something goes wrong and we can't get a price for this product.
            cp.amountOff = Math.Round(cp.amountOff, 2);
        }

        /// <summary>
        /// Compute default values that will be used for all the coupons we simulate
        /// </summary>
        public void computeDefaultValues() {
            couponSourceID_count = (int)Utils.MyDLookup("couponSourceID", "tcouponSource", "", "COUNT");
            discountTypeID_count = (int)Utils.MyDLookup("discountTypeID", "tDiscountType", "", "COUNT");
            productID_count = (int)Utils.MyDLookup("productID", "tProduct", "", "COUNT");
        }
        /// <summary>
        /// Add random coupons across all products and stores. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="r"></param>
        public static Boolean AddRandomCoupons(SqlConnection connection, Random r, TextBox txtInfo, String description, int mCouponAmountToAdd)
        {
            Coupon coupon = new Coupon(mCouponAmountToAdd, connection, r, txtInfo, null);
            coupon.GenerateRandomCoupons();
            return true;
        }
    }
    /// <summary>
    /// Model the set of values required to add a coupon and the associated coupon details. It's just nice to have them grouped together in a class. Encapsulation. Woo Hoo.
    /// </summary>
    class CouponParameters {
        public int couponSourceID;
        public int discountTypeID;
        public DateTime dateStamp;
        //public string dateOfTransaction;
        //public string timeOftransaction;
        //public int emplID;
        public int productID;
        public int maxQtyToPurchase, minQtyToPurchase;
        public List<int> couponDetailIDs;
        public int couponID;
        public String coupon;
        public System.DateTime startDate, throughDate;
        public String couponDescription;
        public int percentageDiscount;
        public double amountOff;

        public void init() {
            dateStamp = DateTime.Now;
            productID = 42;
            maxQtyToPurchase = 1;
            minQtyToPurchase = 1;
            couponDetailIDs = new List<int>();
            couponID = 0;
            discountTypeID = 0;
            coupon = "A coupon";
            couponDescription = ":)";
            percentageDiscount = 0;
            amountOff = 0.0;
        }
    }
}
