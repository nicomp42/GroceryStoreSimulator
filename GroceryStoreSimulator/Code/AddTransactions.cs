/***********************************************
 * Add transactions to the SimGrocery database *
 * Bill Nicholson                              *
 * nicholdw@ucmail.uc.edu                      *
 * University of Cincinnati Clermont College   *
 * Random Employee Name Generator:             *
 * * http://www.behindthename.com/random/      *
 * *********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using System.Data;
using System.Windows.Forms;
using GroceryStoreSimulator.Code;
using System.Diagnostics;

namespace GroceryStoreSimulator {
    class AddTransactions {
        private int numOfTransactionsAdded;
        private int hour, prevHour, minute, prevMinute, second;
        private TextBox txtResults;
        private Label lblStatus;
        private SqlConnection connection;
        private int transactionCount = 0, transactionDetailCount = 0;
        private List<tStoreStatus> tStoreStatus = new List<tStoreStatus>();
        private int numOfTransactionsToAdd;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connection">The open connection to the database</param>
        /// <param name="r">A random number generator object</param>
        /// <param name="txtResults">The TextBox on the UI where info should be written, or null</param>
        /// <param name="lblStatus">The Label on the UI where info should be written, or null</param>
        public AddTransactions(int numOfTransactionsToAdd, SqlConnection connection, Random r, TextBox txtResults, Label lblStatus) {
            this.connection = connection;
            this.txtResults = txtResults;
            this.lblStatus = lblStatus;
            this.numOfTransactionsToAdd = numOfTransactionsToAdd;
        }
        /// <summary>
        /// Write a string to the UI
        /// </summary>
        /// <param name="message">The string to be written to the UI</param>
        private int Write(string message) {
            // Let's not crash if the form isn't there.
            try {
                if (txtResults != null) {
                    txtResults.AppendText(Environment.NewLine + message);
                }
            } catch (Exception ex) {Utils.Log(ex.Message);}
            //Console.WriteLine(message);
            return 42;      // This is only here so I can use this method as a delegate. See the call to tEmpl.RandomizeWorkStatusForAllEmployees in this class
        }

        /// <summary>
        /// Entry point for the thread.
        /// </summary>
        public void StartThread() {
            Stopwatch watch = Stopwatch.StartNew();
            numOfTransactionsAdded = 0;
            prevHour = DateTime.Now.Hour;
            hour = prevHour;
            minute = DateTime.Now.Minute;
            prevMinute = minute;
            Write("AddTransactions: starting thread...");
            LoadStoreStatusTable(connection);
            Config.loadEmployeNamesFromTextFile();
            while (true) {
                if (addTransaction(Config.random)) {
                    if (numOfTransactionsToAdd != 0 && numOfTransactionsAdded >= numOfTransactionsToAdd) {
                        Write("AddTransactions: number of transactions for this simulation have been reached.");
                        break;
                    }
                }
                numOfTransactionsAdded++;
                Thread.Sleep(Config.random.Next(Config.getTransactionDelay()));

                checkTheCheckInterval(ProcessStoreStatusValues, Config.storeCheckInterval, connection, Config.random, txtResults, "**** Processing Stores", 0);
                checkTheCheckInterval(ProcessEmployees, Config.emplCheckInterval, connection, Config.random, txtResults, "**** Processing Employees", 0);
                checkTheCheckInterval(ProductPriceHist.ProcessProductPrices, Config.productCheckInterval, connection, Config.random, txtResults, "**** Processing Products", 0);
                checkTheCheckInterval(Coupon.AddRandomCoupons, Config.couponCheckInterval, connection, Config.random, txtResults, "**** Processing Coupons", Config.couponAmountToAdd);
                TimeSpan myTimeSpan = new TimeSpan(0, Config.elapsedMinutesToRun, 0);
                if ((Config.elapsedMinutesToRun != 0) && (watch.Elapsed > (myTimeSpan))) {
                    // We are supposed to stop after a specific time period. We are done
                    Write("AddTransactions: elapsed time for this simulation has expired.");
                    break;
                }
            }
            Write("AddTransactions: ending thread.");
        }
        private void checkTheCheckInterval(Func<SqlConnection, Random, TextBox, String, int, Boolean> MyFunc, Config.enum_availableCheckIntervals checkInterval,  SqlConnection connection, Random r, TextBox txtResults, String description, int amount) {
            hour = DateTime.Now.Hour;
            Boolean newMinute;
            newMinute = false;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;

            if (minute != prevMinute) { // Do we have a new minute?
                newMinute = true;
                prevMinute = minute;
            }
            switch (checkInterval) {
                case Config.enum_availableCheckIntervals.Never: break;
                case Config.enum_availableCheckIntervals.OnTheHour: if (minute == 0 && (newMinute == true))        { MyFunc(connection, Config.random, txtResults, description, amount); } break;               
                case Config.enum_availableCheckIntervals.OnThe1s:   if (newMinute == true)                         { MyFunc(connection, Config.random, txtResults, description + " on the minute", amount); } break;
                case Config.enum_availableCheckIntervals.OnThe5s:   if ((minute % 5) == 0 && (newMinute == true))  { MyFunc(connection, Config.random, txtResults, description + " on the 5's", amount); } break;
                case Config.enum_availableCheckIntervals.OnThe10s:  if ((minute % 10) == 0 && (newMinute == true)) { MyFunc(connection, Config.random, txtResults, description + " on the 10's", amount); } break;
                case Config.enum_availableCheckIntervals.OnThe15s:  if ((minute % 15) == 0 && (newMinute == true)) { MyFunc(connection, Config.random, txtResults, description + " on the 15's", amount); } break;
                case Config.enum_availableCheckIntervals.OnThe20s:  if ((minute % 20) == 0 && (newMinute == true)) { MyFunc(connection, Config.random, txtResults, description + " on the 20's", amount); } break;
                case Config.enum_availableCheckIntervals.OnThe30s:  if ((minute % 30) == 0 && (newMinute == true)) { MyFunc(connection, Config.random, txtResults, description + " on the 30's", amount); } break;
                case Config.enum_availableCheckIntervals.AfterEeveryTransaction: MyFunc(connection, Config.random, txtResults, description + " after each transaction", amount); break;
                case Config.enum_availableCheckIntervals.AfterEvery5Transactions: if ((numOfTransactionsAdded % 5) == 0) {MyFunc(connection, Config.random, txtResults, description + " after every 5 transactions", amount);} break;
                case Config.enum_availableCheckIntervals.AfterEvery10Transactions: if ((numOfTransactionsAdded % 10) == 0) { MyFunc(connection, Config.random, txtResults, description + " after every 10 transactions", amount); } break;
                case Config.enum_availableCheckIntervals.AfterEvery100Transactions: if ((numOfTransactionsAdded % 100) == 0) { MyFunc(connection, Config.random, txtResults, description + " after every 100 transactions", amount); } break;
                case Config.enum_availableCheckIntervals.AfterEvery1000Transactions: if ((numOfTransactionsAdded % 1000) == 0) { MyFunc(connection, Config.random, txtResults, description + " after every 1,000 transactions", amount); } break;
                case Config.enum_availableCheckIntervals.AfterEvery10000Transactions: if ((numOfTransactionsAdded % 10000) == 0) { MyFunc(connection, Config.random, txtResults, description + " after every 10,000 transactions", amount); } break;
                case Config.enum_availableCheckIntervals.AfterEvery100000Transactions: if ((numOfTransactionsAdded % 100000) == 0) { MyFunc(connection, Config.random, txtResults, description + " after every 100,000 transactions", amount); } break;
                case Config.enum_availableCheckIntervals.AfterEvery1000000Transactions: if ((numOfTransactionsAdded % 1000000) == 0) { MyFunc(connection, Config.random, txtResults, description + " after every 1,000,000 transactions", amount); } break;
            }
        }

        /// <summary>
        /// Add a transaction to the database. 
        /// </summary>
        /// <returns>True if the add succeeded, false otherwise</returns>
        public bool addTransaction(Random r) {
            bool status = true;
            try { 
                SqlCommand cmd = new SqlCommand();
                TransactionParameters tp = new TransactionParameters();
                //computeDefaultValues();
                tp.init();
                computeRandomValuesForTransaction(tp, r);
                computeRandomValuesForTransactionDetail(tp, r);
                // We have a store ID but is the store open for business?
                if (IsStoreOpenForBusiness(tp.storeID, connection)) {
                    ProcessTransactionDetailAndCoupon(tp);
                    cmd.CommandText = "spAddTransactionAndDetail";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;

                    // The output parameter must be FIRST in the Parameters collection? https://support.microsoft.com/en-us/kb/308621
                    cmd.Parameters.Add("@TransactionID", SqlDbType.Int);
                    cmd.Parameters["@TransactionID"].Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(new SqlParameter("LoyaltyID", tp.loyaltyID));
                    cmd.Parameters.Add(new SqlParameter("DateOfTransaction", tp.dateOfTransaction));
                    cmd.Parameters.Add(new SqlParameter("TimeOfTransaction", tp.timeOftransaction));
                    cmd.Parameters.Add(new SqlParameter("TransactionTypeID", tp.transactionTypeID));
                    cmd.Parameters.Add(new SqlParameter("StoreID", tp.storeID));
                    cmd.Parameters.Add(new SqlParameter("emplID", tp.emplID));
                    cmd.Parameters.Add(new SqlParameter("productID", tp.productID));
                    cmd.Parameters.Add(new SqlParameter("qty", tp.qty));
                    cmd.Parameters.Add(new SqlParameter("pricePerSellableUnitToTheCustomer", tp.pricePerSellableUnitToTheCustomer));
                    cmd.Parameters.Add(new SqlParameter("pricePerSellableUnitAsMarked", tp.pricePerSellableUnitAsMarked));
                    //cmd.Parameters.Add(new SqlParameter("totalPrice", tp.totalPrice));
                    cmd.Parameters.Add(new SqlParameter("transactionComment", tp.transactionComment));
                    cmd.Parameters.Add(new SqlParameter("transactionDetailComment", tp.transactionDetailComment));
                    SqlParameter sp = new SqlParameter("couponDetailID", tp.couponDetailID);
                    //if (tp.couponDetailID != 0) { sp = new SqlParameter("couponDetailID", tp.couponDetailID); } else { sp = new SqlParameter("couponDetailID", null); sp.IsNullable = true; }
                    cmd.Parameters.Add(sp);
                    cmd.ExecuteNonQuery();
                    transactionCount++; transactionDetailCount++;
                    WriteStatus(transactionCount, transactionDetailCount);

                    tp.transactionID = (int)cmd.Parameters["@TransactionID"].Value;
                    string store = (string)Utils.MyDLookup("store", "tStore", "StoreID = " + tp.storeID, "");
                    Write("Store: " + store.Trim() + ". TransactionID = " + tp.transactionID);

                    // Add more transaction detail records for this transaction
                    int totalTransactionDetailRecords = r.Next(31);     // 0 to 30
                    if (totalTransactionDetailRecords == 30) totalTransactionDetailRecords = r.Next(101);   // One out of 30 of these loops can go as high as 100 items
                    for (int i = 0; i < totalTransactionDetailRecords; i++) {
                        computeRandomValuesForTransactionDetail(tp, r); // We already have values for tTransaction. Now we need another Transaction Detail record.
                        cmd.Parameters.Clear();
                        cmd.CommandText = "spAddTransactionDetail";
                        // The output parameter must be  FIRST in the Parameters collection? https://support.microsoft.com/en-us/kb/308621
                        cmd.Parameters.Add("@TransactionDetailID", SqlDbType.Int);
                        cmd.Parameters["@TransactionDetailID"].Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(new SqlParameter("transactionID", tp.transactionID));
                        cmd.Parameters.Add(new SqlParameter("productID", tp.productID));
                        cmd.Parameters.Add(new SqlParameter("qty", tp.qty));
                        cmd.Parameters.Add(new SqlParameter("pricePerSellableUnitToTheCustomer", tp.pricePerSellableUnitToTheCustomer));
                        cmd.Parameters.Add(new SqlParameter("pricePerSellableUnitAsMarked", tp.pricePerSellableUnitAsMarked));
                        //cmd.Parameters.Add(new SqlParameter("totalPrice", tp.totalPrice));    // Got rid of this 12/20/2016
                        cmd.Parameters.Add(new SqlParameter("transactionDetailComment", tp.transactionDetailComment));
                        sp = new SqlParameter("couponDetailID", tp.couponDetailID);
                        //if (tp.couponDetailID != 0) { sp = new SqlParameter("couponDetailID", tp.couponDetailID); } else { sp = new SqlParameter("couponDetailID", null); sp.IsNullable = true; }
                        cmd.Parameters.Add(sp);
                        cmd.ExecuteNonQuery();
                        tp.transactionDetailID = (int)cmd.Parameters["@TransactionDetailID"].Value;
                        Write("  TransactionDetailID = " + tp.transactionDetailID);
                        //Thread.Sleep(r.Next(500));
                        transactionDetailCount++;
                    }
                    transactionDetailCount++;
                    WriteStatus(transactionCount, transactionDetailCount);
                    status = true;
                } else {
                    string store = (string)Utils.MyDLookup("store", "tStore", "StoreID = " + tp.storeID, "");
                    Write("Store: " + store.Trim() + " is closed. Cannot add transaction.");
                    status = false;
                }
            } catch (Exception ex) {
                // Something went wrong. 
                txtResults.AppendText(Environment.NewLine + "AddTransactions.addTransaction: " + ex.Message);
            }
            return status;
        }
        /// <summary>
        /// Process the coupon, if any, relative to the transaction taking place
        /// </summary>
        /// <param name="tp">Transaction Paramaters for the current transaction</param>
        private void ProcessTransactionDetailAndCoupon(TransactionParameters tp) {
            try {
                if (tp.couponDetailID > 0) {
                    tDiscountType discountType = new tDiscountType();
                    tCouponDetail.fGetCouponDetailDataTable couponDetailDataTable = LoadCouponDetail(tp.couponDetailID);
                    int discountTypeID = couponDetailDataTable.Rows[0].Field<int>("DiscountTypeID");
                    tDiscountType.fGetDiscountTypeDataTable discountTypeDataTable = LoadDiscountType(discountTypeID);
                    // Check the quantity being purhased in the transaction to make sure it's not too many or too few to use the coupon.
                    if (tp.qty < couponDetailDataTable.Rows[0].Field<int>("MinQtyToPurchase")) { tp.qty = couponDetailDataTable.Rows[0].Field<int>("MinQtyToPurchase"); }
                    if (tp.qty > couponDetailDataTable.Rows[0].Field<int>("MaxQtyToPurchase")) { tp.qty = couponDetailDataTable.Rows[0].Field<int>("MaxQtyToPurchase"); }
                    if (discountTypeDataTable.Rows[0].Field<bool>("isFree") == true) {
                        // It's a free coupon! Make the cost in the transaction detail zero
                        tp.pricePerSellableUnitToTheCustomer = 0;
                    } else {
                        if (discountTypeDataTable.Rows[0].Field<bool>("isPercentageDiscount") == true) {
                            // It's a percentage off coupon! Reduce the cost in the transaction detail
                            double percentageDiscount = ((double)(100 - couponDetailDataTable.Rows[0].Field<int>("PercentageDiscount"))) / 100;
                            tp.pricePerSellableUnitToTheCustomer *= percentageDiscount;
                        } else {
                            if (discountTypeDataTable.Rows[0].Field<bool>("isBOGO") == true) {
                                // It's buy one / get one free. 
                                tp.pricePerSellableUnitToTheCustomer /= 2;      // Reduce the purchase price of each unit by 1/2 to acheive BOGO
                                // round it up because we don't sell fractions of a cent
                                tp.pricePerSellableUnitToTheCustomer = Math.Round(tp.pricePerSellableUnitToTheCustomer, 2);
                                tp.qty *= 2;        // They will get twice as many as they purchased. Woo Hoo.
                            } else {
                                if (discountTypeDataTable.Rows[0].Field<bool>("isAmountOff") == true) {
                                    // It's a specific amount off the purchase price.
                                    double amountOff = Double.Parse(couponDetailDataTable.Rows[0].Field<decimal>("AmountOff").ToString());
                                    tp.pricePerSellableUnitToTheCustomer -= amountOff;      // Reduce the purchase price of each unit by the amount on the coupon
                                } else {
                                    if (discountTypeDataTable.Rows[0].Field<bool>("isGiftCard") == true) {
                                        // It's a gift card.
                                        double amountOff = Double.Parse(couponDetailDataTable.Rows[0].Field<decimal>("AmountOff").ToString());
                                        tp.pricePerSellableUnitToTheCustomer -= amountOff/tp.qty;      // Reduce the purchase price of each unit
                                        // round it up because we don't sell fractions of a cent
                                        tp.pricePerSellableUnitToTheCustomer = Math.Round(tp.pricePerSellableUnitToTheCustomer, 2);
                                    }
                                }
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                // Something went wrong. 
                Write(Environment.NewLine + "AddTransactions.ProcessTransactionDetailAndCoupon: " + ex.Message);
            }
        }
        /// <summary>
        /// Load a DataTable object with a row from the tCouponDetail table
        /// </summary>
        /// <param name="couponDetailID"></param>
        /// <returns></returns>
        private tCouponDetail.fGetCouponDetailDataTable LoadCouponDetail(int couponDetailID) {
            tCouponDetail.fGetCouponDetailDataTable couponDetailDataTable = new tCouponDetail.fGetCouponDetailDataTable();
            try { 
                tCouponDetailTableAdapters.fGetCouponDetailTableAdapter fGetCouponDetailTableAdapter = new tCouponDetailTableAdapters.fGetCouponDetailTableAdapter();
                // Don't use the connection configured in the DataSet designer. Use the one we like. 
                fGetCouponDetailTableAdapter.Connection = Config.myConnection;
                fGetCouponDetailTableAdapter.Fill(couponDetailDataTable, couponDetailID);
            } catch (Exception ex) {
                // Something went wrong. 
                txtResults.AppendText(Environment.NewLine + "AddTransactions.LoadCouponDetail: " + ex.Message);
            }
            return couponDetailDataTable;
        }
        /// <summary>
        /// Load a DataTable object with a row from the tDiscountType table
        /// </summary>
        /// <param name="discountTypeID"></param>
        /// <returns></returns>
        private tDiscountType.fGetDiscountTypeDataTable LoadDiscountType(int discountTypeID) {
            tDiscountType.fGetDiscountTypeDataTable discountTypeDataTable = new tDiscountType.fGetDiscountTypeDataTable();
            tDiscountTypeTableAdapters.fGetDiscountTypeTableAdapter fGetDiscountTypeTableAdapter = new tDiscountTypeTableAdapters.fGetDiscountTypeTableAdapter();
            // Don't use the connection configured in the DataSet designer. Use the one we like. 
            fGetDiscountTypeTableAdapter.Connection = Config.myConnection;
            fGetDiscountTypeTableAdapter.Fill(discountTypeDataTable, discountTypeID);
            return discountTypeDataTable;
        }
        /// <summary>
        /// Update the UI with transaction counts
        /// </summary>
        /// <param name="transactionCount">The number of transaction records that have been added</param>
        /// <param name="transactionDetailCount">The number of transaction detail records that have been added</param>
        public void WriteStatus(int transactionCount, int transactionDetailCount) {
            lblStatus.Text = transactionCount + " transactions, " + transactionDetailCount + " transaction details";
        }
        /// <summary>
        /// Compute random values for a transaction detail. Be sure you called computeRandomValuesForTransaction first.
        /// </summary>
        /// <param name="tp">Transaction Paramaters that are being populated</param>
        /// <param name="r">Random number generator</param>
        private void computeRandomValuesForTransactionDetail(TransactionParameters tp, Random r)
        {
            try
            {
                // Random Product
                tp.productID = Utils.GetRandomProductID(r, DefaultValues.productID_count);

                if (Config.useCoupons)
                {
                    // Is there a coupon for this product?
                    tp.couponDetailID = Coupon.getRandomCouponDetailID(tp.productID, r, connection);
                }
                else
                {
                    tp.couponDetailID = 0;
                }
                // qty should trend toward 1 but have some randomness
                int scale = r.Next(100) + 1;        // 1 to 100
                tp.qty = 1 + (int)((r.NextDouble() + r.NextDouble()) * (scale * r.NextDouble() * r.NextDouble() * r.NextDouble()));

                //double q1 = (r.NextDouble() * 1000);
                //int q2 = (int)q1;
                //double q3 = (double)q2 / 100;
                tp.pricePerSellableUnitToTheCustomer = Utils.GetMostRecentPricePerSellableUnit(tp.productID, tp.storeID, connection);
                tp.pricePerSellableUnitAsMarked = tp.pricePerSellableUnitToTheCustomer;
                //tp.totalPrice = tp.pricePerSellableUnitToTheCustomer * tp.qty;
            } catch (Exception ex) {
                // Something went wrong. 
                txtResults.AppendText(Environment.NewLine + "AddTransactions.computeRandomValuesForTransactionDetail: " + ex.Message);
            }
        }
        /// <summary>
        /// Compute random record IDs for the random transaction we will add
        /// </summary>
        /// <param name="tp">The set of transaction parameters upon which to operate</param>
        private void computeRandomValuesForTransaction(TransactionParameters tp, Random r) {
            try {
                // Date/time of transaction
                if (Config.useCurrentDateStampForTransaction) {
                    tp.dateOfTransaction = DateTime.Now.ToShortDateString();
                    tp.timeOftransaction = DateTime.Now.ToLongTimeString();
                } else {
                    tp.dateOfTransaction = Utils.GetRandomDate(r);
                    tp.timeOftransaction = Utils.GetRandomTime(r);
                }
                tp.emplID = 0;
                tp.storeID = Utils.GetRandomStoreID(r, DefaultValues.storeID_count);

                //tp.storeID = 10;
                //tp.dateOfTransaction = "1/9/2017";
                //tp.timeOftransaction = "12:29:1.656";
                //if (tp.storeID == 29)
                //{
                //   int tmp = 42;
                //}
                while (true) {
                    int emplID;
                    // Pick a random employee that is available for work at the storeID
                    try {
                         emplID = (int)Utils.MyDLookup("EmplID", "SELECT TOP 1 EmplID FROM [fEmplWhoCanWorkOnASpecificDateAtASpecificStore](" + Utils.QuoteMeForSQL(tp.dateOfTransaction) + " ," + tp.storeID + ") ORDER BY NEWID()", "", "");
                         // SELECT top 1   * FROM [fEmplWhoCanWorkOnASpecificDateAtASpecificStore]('1/1/2016', 2) order by newID()
                    } catch (Exception ex) {emplID = 0; Utils.Log("AddTransactions.computeRandomValuesForTransaction(): " + ex.Message); }
                    // emplID = (int)Utils.MyDLookup("EmplID", "(SELECT ROW_NUMBER() OVER (ORDER BY emplID) AS RowNum, * FROM tEmpl) sub ", " RowNum = " + (r.Next(DefaultValues.emplID_count) + 1), "");
                    if (emplID > 0) {
                        tp.emplID = emplID;
                        break;
                    } else {
                        //if (tp.storeID == 21) {
                        //    int foo = -42;
                        //}
                        Write("### It appears that no employees are available for work. Adding one... ###");
                        emplID = Empl.AddRandomEmplAndMakeThemAvailableForWork(tp.storeID, DateTime.Parse(tp.dateOfTransaction), connection, r);
                        tp.emplID = emplID;
                        break;
                    }
                }
                if (tp.emplID == 0) {       // Uh oh. No employees available for work at this store...
                    // todo: something here
                    //int tmp = 0;
                }
                tp.loyaltyID = (int)Utils.MyDLookup("loyaltyID",
                                                 "(SELECT ROW_NUMBER() OVER (ORDER BY loyaltyID) AS RowNum, * FROM tloyalty) sub ",
                                                 " RowNum = " + (r.Next(DefaultValues.loyaltyID_count) + 1),
                                                 "");
                // A high percentage of transactions should be purchases.
                int selector = r.Next(100) + 1;     // 1 to 100
                if (selector >= Config.percentageOfPurchaseTransactions) {
                    // It can be another type of transaction so we will look it up randomly
                    tp.transactionTypeID = (int)Utils.MyDLookup("transactionTypeID",
                                                                "(SELECT ROW_NUMBER() OVER (ORDER BY transactionTypeID) AS RowNum, * FROM tTransactionType) sub ",
                                                                " RowNum = " + (r.Next(DefaultValues.transactionTypeID_count) + 1),
                                                                "");
                } else {
                    // It has to be a purchase transaction
                    tp.transactionTypeID = DefaultValues.transactionTypeID_Purchase;
                }
            } catch (Exception ex) {
                // Something went wrong. 
                txtResults.AppendText(Environment.NewLine + "AddTransactions.computeRandomValuesForTransaction: " + ex.Message);
            }
        }
        /// <summary>
        /// Check the current status of a physical store. Is the store open for business?
        /// </summary>
        /// <param name="storeID">StoreID from the database</param>
        /// <returns>True if store is open for business, false otherwise</returns>
        private bool IsStoreOpenForBusiness(int storeID, SqlConnection connection) {
            SqlDataReader reader = null;
            bool status = true;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("storeID", storeID));
            //cmd.CommandText = "SELECT IsOpenForBusiness from fGetCurrentStoreStatus("@Store)";
            cmd.CommandText = "SELECT IsOpenForBusiness from fGetCurrentStoreStatus(" + storeID + ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            try {
                reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    bool isOpen = Convert.ToBoolean(reader.GetValue(0));
                    status = isOpen;
                }
            } catch (Exception ex) {
                status = false;
                Utils.Log(ex.Message);
            } finally {
                try { reader.Close(); } catch (Exception ex) { Utils.Log(ex.Message);}
            }
            return status;
        }
        /// <summary>
        /// Step through all the stores and randomly set the status values
        /// </summary>
        /// <param name="connection">The open database connection</param>
        private Boolean ProcessStoreStatusValues(SqlConnection connection, Random r, TextBox txtResults, String description, int amount) {
            SqlDataReader reader = null;
            int storeID;
            bool isOpenForBusiness;
            bool isClosedForever;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from vCurrentStoreStatusForAllStores";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            try {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    storeID = Convert.ToInt32(reader.GetValue(0));
                    isOpenForBusiness = Convert.ToBoolean(reader.GetValue(3));
                    isClosedForever = Convert.ToBoolean(reader.GetValue(4));
                    int myRandomValue = r.Next(1001); // 0 to 1000
                    int storeStatusID = 0;
                    int tmpRandom;
                    if (!isClosedForever) {
                        if (isOpenForBusiness) {
                            // Let's say that 10% of the time the store will be closed 
                            if (myRandomValue > 900) {
                                // We need to close this store. Let's find a store status that is closed but not closed forever.
                                while (true) {
                                    tmpRandom = r.Next(tStoreStatus.Count());
                                    if (tStoreStatus[tmpRandom].IsOpenForBusiness == false && tStoreStatus[tmpRandom].IsClosedForever == false) {
                                        storeStatusID = tStoreStatus[tmpRandom].StoreStatusID;
                                        break;
                                    }
                                }
                                // Set the status of the store to this new status.
                                String store = Convert.ToString(Utils.MyDLookup("Store", "tStore", "StoreID = " + storeID, "")).Trim();
                                Write("****************** Closing StoreID " + storeID + " (" + store + ") with StoreStatus " + storeStatusID);
                                DateTime tmpDate;
                                if (Config.useCurrentDateStampForTransaction) {
                                    tmpDate = DateTime.Now;
                                } else {
                                    // ToDo: This store may already have transactions on this date or after this date, if this will change the current status of the store.
                                    tmpDate = Convert.ToDateTime(Utils.GetRandomDate(r));
                                }
                                UpdateStoreStatus(storeID, storeStatusID, tmpDate, connection);
                            }
                        } else {
                            // It's closed now. Let's open it 90% of the time
                            if (myRandomValue < 900) {
                                // We need to open this store. Randomly access the Store Status table until we find an Open status
                                while (true) {
                                    tmpRandom = r.Next(tStoreStatus.Count());
                                    if (tStoreStatus[tmpRandom].IsOpenForBusiness == true) {
                                        storeStatusID = tStoreStatus[tmpRandom].StoreStatusID;
                                        break;
                                    }
                                }
                                // Set the status of the store to this new status.
                                String store = Convert.ToString(Utils.MyDLookup("Store", "tStore", "StoreID = " + storeID, "")).Trim();
                                Write("****************** Opening StoreID " + storeID + "(" + store + ") with StoreStatus " + storeStatusID);
                                DateTime tmpDate;
                                if (Config.useCurrentDateStampForTransaction) {tmpDate = DateTime.Now;} else {tmpDate = Convert.ToDateTime(Utils.GetRandomDate(r));}
                                UpdateStoreStatus(storeID, storeStatusID, DateTime.Now, connection);
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("AddTransactions.ProcessStoreStatusValues(): " + ex.Message);
            } finally {
                try { reader.Close(); } catch (Exception ex) { Utils.Log(ex.Message); }
            }
            return true;
        }
        /// <summary>
        /// Update the status of a store
        /// </summary>
        /// <param name="storeID"></param>
        /// <param name="storeStatusID"></param>
        /// <param name="now"></param>
        /// <param name="connection"></param>
        private void UpdateStoreStatus(int storeID, int storeStatusID, DateTime now, SqlConnection connection) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spUpdateStoreStatus";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            cmd.Parameters.Add(new SqlParameter("StoreID", storeID));
            cmd.Parameters.Add(new SqlParameter("StoreStatusID", storeStatusID));
            cmd.Parameters.Add(new SqlParameter("StartDate", now));
            try {
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Console.WriteLine("AddTransactions.UpdateStoreStatus(" + storeID + ", " + storeStatusID + ", " + now + "): " + ex.Message);
            }
        }
        /// <summary>
        /// Make a local copy of the table because it's a small footprint and the contents won't change much.
        /// </summary>
        private void LoadStoreStatusTable(SqlConnection connection) {
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from vStoreStatusTable";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            tStoreStatus.Clear();
            try {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    tStoreStatus.Add(new tStoreStatus(Convert.ToInt32(reader.GetValue(0)),
                                                      Convert.ToString(reader.GetValue(1)).Trim(),
                                                      Convert.ToBoolean(reader.GetValue(2)),
                                                      Convert.ToBoolean(reader.GetValue(3))));
                }
            } catch (Exception ex) {
                Console.WriteLine("AddTransactions.LoadStoreStatusTable(): " + ex.Message);
            } finally { try { reader.Close(); } catch (Exception ex) { Utils.Log(ex.Message); } }
        }
        /// <summary>
        /// Process employees. Some come, some go.
        /// </summary>
        /// <param name="connection">DB Connection</param>
        private Boolean ProcessEmployees(SqlConnection connection, Random r, TextBox txtResults, String description, int amount) {
            txtResults.AppendText(Environment.NewLine + description);
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from vStoresNotClosedForever";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            int storeID;
            // Add a random employee for each store that is not closed forever
            try {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    storeID = Convert.ToInt32(reader.GetValue(0));
                    Empl.AddRandomEmpl(storeID, r, connection);
                }
                reader.Close();
                Empl.RandomizeWorkStatusForAllEmployees(connection, r, Write);
            } catch (Exception ex) {
                Console.WriteLine("AddTransactions.ProcessEmployees(): " + ex.Message);
            } finally { try { reader.Close(); } catch (Exception ex) { Utils.Log(ex.Message); } }
            return true;
        }
        /// <summary>
        /// Get a random coupon that is available for a customer to use based on the current date and date range of the contents in tCoupon
        /// </summary>
        /// <returns>The Coupon ID of the randomly selected coupon in tCoupon</returns>
        private int getRandomCouponID(Random r) {
            int couponID_count = Convert.ToInt32(Utils.MyDLookup("CountOfCouponID", "vCouponsCurrentlyOpen", "", "Count"));
            int couponID = 0;
            // Pick a random coupon that is not expired
            couponID = (int)Utils.MyDLookup("couponID", "(SELECT ROW_NUMBER() OVER (ORDER BY couponID) AS RowNum, * FROM vCouponsCurrentlyOpen) sub ", " RowNum = " + (r.Next(couponID_count) + 1), "");
            return couponID;
        }
        /// <summary>
        /// Get a random coupon detail that is available for a customer to use based on the current date and date range of the contents in tCoupon
        /// </summary>
        /// <returns>The Coupon Detail ID of the coupon in tCouponDetail</returns>
        private int getRandomCouponDetailID(Random r) {
            int couponDetailID_count = Convert.ToInt32(Utils.MyDLookup("CountOfcouponDetailID", "vCouponDetailsCurrentlyOpen", "", "Count"));
            int couponDetailID = 0;
            try {
                // Pick a random coupon that is not expired, if any.
                couponDetailID = (int)Utils.MyDLookup("couponDetailID", "(SELECT ROW_NUMBER() OVER (ORDER BY couponDetailID) AS RowNum, * FROM vCouponDetailssCurrentlyOpen) sub ", " RowNum = " + (r.Next(couponDetailID_count) + 1), "");
            } catch (Exception ex) { Utils.Log(ex.Message); }
            return couponDetailID;
        }
        /// <summary>
        /// Model the set of values required to add a transaction. It's just nice to have them grouped together in a class. Encapsulation. Woo Hoo.
        /// </summary>
        class TransactionParameters {
            public int storeID;
            public int loyaltyID;
            public DateTime dateStamp;
            public string dateOfTransaction;
            public string timeOftransaction;
            public int transactionTypeID;
            public int emplID;
            public int productID;
            public int qty;
            public double pricePerSellableUnitToTheCustomer;
            public double pricePerSellableUnitAsMarked;
            //public double totalPrice;
            public string transactionComment;
            public string transactionDetailComment;
            public int transactionID;
            public int transactionDetailID;
            public int couponDetailID;
            public int couponID;

            public void init() {
                storeID = 0;
                loyaltyID = 0;
                dateStamp = DateTime.Now;
                transactionTypeID = 0;
                emplID = 0;
                productID = 42;
                qty = 0;
                pricePerSellableUnitToTheCustomer = 0;
                pricePerSellableUnitAsMarked = 0;
                //totalPrice = 0;
                transactionComment = "";
                transactionDetailComment = "";
                transactionID = 0;
                transactionDetailID = 0;
                couponDetailID = 0;
                couponID = 0;
            }
        }
    }
}