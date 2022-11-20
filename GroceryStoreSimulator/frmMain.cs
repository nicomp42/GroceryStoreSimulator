﻿/*****************************************************************
 * Grocery Store Simulator
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * University of Cincinnati Clermont College
 * ***************************************************************/
// use GroceryStoreSimulator
// CREATE ROLE db_executor;
// GRANT EXECUTE TO db_executor;

using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;
using SimulatorNamespace;
using RestSharp;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace SimulatorGUI
{
    public partial class frmMain : Form {
        private SimulatorNamespace.SimGrocery sg = new SimulatorNamespace.SimGrocery();
        private Stopwatch watch;

        public frmMain() {
            InitializeComponent();
            tcSimulate.TabPages.Remove(tpProductPrioritization);
            rbPrioritizeProductsAtStartOfSimulationOnly.Checked = true;
            UpdateControls();
        }
        private void btnStartTransactionSimulator_Click(object sender, EventArgs e) {
            TextBox.CheckForIllegalCrossThreadCalls = false;    // We will spawn a thread that writes to a control on this thread.
            Boolean validInput = true;
            DateTime startDate = DateTime.Now, throughDate = DateTime.Now;
            switch (Config.mode) {
                case Config.modeEnum.idle:
                    try {
                        // Check to see if the user wants to run for a period of elapsed time or run forever
                        if (cbIgnoreElapsedTime.Checked == true) {
                            Config.elapsedMinutesToRun = 0;     // zero means ignore this limit
                        } else {
                            int hours = 0, minutes = 0;
                            String[] split = txtElapsedTimeToRun.Text.Trim().Split(':');
                            hours = Convert.ToInt32(split[0]);
                            if (split.Length == 2) { minutes = Convert.ToInt32(split[1]); }
                            Config.elapsedMinutesToRun = hours * 60 + minutes;
                        }
                    } catch (Exception ex) {
                        validInput = false;
                        MessageBox.Show("Input error: " + ex.Message, "Check Hours:Minutes to run.");
                    }
                    try {
                        Config.setTransactionDelay(Convert.ToInt32(txtTransactionDelay.Text));
                    } catch (Exception ex) {
                        MessageBox.Show("Input error: " + ex.Message, "Check Transaction Delay.");
                        Utils.Log(ex.Message);
                        validInput = false;
                    }
                    if (validInput && !cbUseCurrentDateStampForTransaction.Checked) {
                        try {
                            // Don't store these values in the Config object unless both are valid.
                            startDate = Convert.ToDateTime(txtStartDate.Text);
                            throughDate = Convert.ToDateTime(txtThroughDate.Text);
                            if ((throughDate - startDate).TotalDays < 0) {
                                throw new Exception("Through Date must follow or equal Start Date.");
                            }
                            if (startDate < Config.earliestPossibleDate) { throw new Exception("Start date cannot be earlier than " + Config.earliestPossibleDate.ToShortDateString()); }
                        } catch (Exception ex) {
                            validInput = false;
                            MessageBox.Show("Input error: " + ex.Message, "Check Start Date and Through Date.");
                        }
                    }
                    if (validInput) {
                        Config.useCurrentDateStampForTransaction = cbUseCurrentDateStampForTransaction.Checked;
                        Config.startDate = startDate;
                        Config.throughDate = throughDate;
                        Config.mode = Config.modeEnum.running;
                        Config.server = txtServer.Text;
                        Config.login = txtLogin.Text;
                        Config.password = txtPassword.Text;
                        Config.database = txtDatabase.Text;
                        Config.useCoupons = cbUseCoupons.Checked;
                        Config.checkForAllStoresClosed = cbCheckForAllStoresClosed.Checked;
                        Config.executeFailSafeOptions = cbExecuteFailSafe.Checked;
                        Config.prioritizeProducts = cbPrioritizeProducts.Checked;
                        // This is tricky: the index of the selected item in the combo box must map to a specific enum. Be sure both are zero based:
                        Config.storeCheckInterval = (Config.enum_availableCheckIntervals)cbStoreCheckInterval.SelectedIndex;
                        Config.emplCheckInterval = (Config.enum_availableCheckIntervals)cbEmplCheckInterval.SelectedIndex;
                        Config.productCheckInterval = (Config.enum_availableCheckIntervals)cbProductCheckInterval.SelectedIndex;
                        Config.couponCheckInterval = (Config.enum_availableCheckIntervals)cbCouponCheckInterval.SelectedIndex;
                        String[] tmp = cbCouponAmountToAdd.SelectedItem.ToString().Split();
                        Config.couponAmountToAdd = Convert.ToInt32(tmp[0]);
                        Config.prioritizeProductsAtStartOfSimulationOnly = rbPrioritizeProductsAtStartOfSimulationOnly.Checked;
                        Config.prioritizeProductsAtStartOfEachDay = rbPrioritizeProductsAtStartOfEachDay.Checked;
                        Config.prioritizeProductsEachDayOfWeek = rbPrioritizeProductsEachDayOfWeek.Checked;
                        Config.prioritizeProductsEachDayOfMonth = rbPrioritizeProductsEachDayOfMonth.Checked;
                        int numOfTransactionsToAdd;
                        if (cbRunForever.Checked == true) {
                            numOfTransactionsToAdd = 0; // Zero means run forever
                        } else {
                            try {
                                numOfTransactionsToAdd = Convert.ToInt32(txtNumOfTransactionsToAdd.Text);
                            } catch (Exception ex) {
                                MessageBox.Show("Enter the number of transactions to add or select Run Forever", "Invalid Number");
                                txtNumOfTransactionsToAdd.Focus();
                                Utils.Log(ex.Message);
                                return;
                            }
                        } 
                        try {
                            if (Config.executeFailSafeOptions) {
                                ProductPriceHist.CopyFromFromProductTableIntoProductPriceHist(Config.startDate); // Config.earliestPossibleDate);     // Fail-safe strategy
                                Empl.MakeAllEmplAvailableToWork(Config.startDate); // Config.earliestPossibleDate);                                   // Fail-safe strategy
                                Store.MakeAllStoreOpenForBusiness(Config.startDate); // Config.earliestPossibleDate);                                 // Fail-safe strategy
                            }
                            //*****************************
                            // Finally, start transacting
                            //*****************************
                            sg.StartTransactionSimulation(numOfTransactionsToAdd, Config.random, txtResults, lblStatus);
                        } catch (Exception ex) {
                            txtResults.Text += " btnGo_Click:" + "sg.StartSimulation: " + ex.Message;
                        }
                        btnStartTransactionSimulator.Text = "Halt";
                        watch = Stopwatch.StartNew();
                        lblElapsedTime.Text = "";
                        ShowTimerControls(true);
                        timer1.Enabled = true;
                        txtSeed.Enabled = false;
                        lblStartTime.Text = (String.Format("{0:hh\\:mm\\:ss tt}", DateTime.Now));
                    }
                    break;

                case Config.modeEnum.running:
                    Config.mode = Config.modeEnum.idle;
                    btnStartTransactionSimulator.Text = "Go";
                    sg.Halt();
                    watch = null;
                    timer1.Enabled = false;
                    txtSeed.Enabled = true;
                    break;
            }
        }
        private void ShowTimerControls(Boolean visible) {
            lblElapsedTime.Visible = visible;
            lblElapsedTimeLabel.Visible = visible;
            lblStartTime.Visible = visible;
            lblStartTimeLabel.Visible = visible;
            lblCurrentTime.Visible = visible;
            lblCurrentTimeLabel.Visible = visible;
        }
        private void frmMain_Load(object sender, EventArgs e) {
            cbUseCoupons.Checked = Config.useCoupons;
            lblVersion.Text = "Version " + Config.version;
            txtServer.Text = Config.server;
            txtLogin.Text = Config.login;
            txtPassword.Text = Config.password;
            txtTransactionDelay.Text = Convert.ToString(Config.getTransactionDelay());
            txtDatabase.Text = Config.database;
            txtCouponsToAdd.Text = "5";
            InitRandomNumberGenerator();
            // Select the Config page by default
            tcSimulate.SelectTab("tpConfig");
            InitIntervalComboBox(cbStoreCheckInterval); cbStoreCheckInterval.SelectedIndex = 4;
            InitIntervalComboBox(cbEmplCheckInterval); cbEmplCheckInterval.SelectedIndex = 4;
            InitIntervalComboBox(cbProductCheckInterval); cbProductCheckInterval.SelectedIndex = 4;
            InitIntervalComboBox(cbCouponCheckInterval); cbCouponCheckInterval.SelectedIndex = 4;
            //cbStoreCheckInterval.SelectedIndex = 0;     // Interval = "Never"
            //cbEmplCheckInterval.SelectedIndex = 0;
            //cbProductCheckInterval.SelectedIndex = 0;
            //cbCouponCheckInterval.SelectedIndex = 0;
            cbCouponAmountToAdd.SelectedIndex = 3;
            txtStartDate.Text = Config.startDate.ToShortDateString();
            try { txtThroughDate.Text = Config.throughDate.ToShortDateString(); } catch (Exception ex) { txtThroughDate.Text = null; Utils.Log(ex.Message); }
            txtElapsedTimeToRun.Text = "0:1";
            ShowTimerControls(false);
            cbURL.Items.Add("https://api.upcitemdb.com/prod/trial/lookup");
            cbURL.Items.Add("https://api.upcdatabase.org/");
            cbURL.Items.Add("https://api.barcodelookup.com");
            cbURL.SelectedIndex = 2;
            lblProviderNotes.Text = "upcitemdb wants 11 or 13 digit codes" + "\n" + "upcdatabase wants 13 digit codes" + "\n" + "barcodelookup.com wants 11 digit codes";
        }
        private void InitRandomNumberGenerator() {
            try {
                Config.initRandomNumberGenerator(Convert.ToInt32(txtSeed.Text));
            } catch (Exception ex) {
                txtSeed.Text = Convert.ToString(Config.randomNumberSeed);
                Config.initRandomNumberGenerator(Convert.ToInt32(txtSeed.Text));
                Utils.Log(ex.Message);
            }
        }
        private void LoadManagerComboBox() {
            //Utils.CheckConnection();
            //cbManagerID.Items.Clear();
            //lvManagerID.Items.Clear();
            //DataTable dt = fEmployeesWhoCanBeAStoreManagerTableAdapter.GetData();

            //foreach (DataRow r in dt.Rows) {
            //    lvManagerID.Items.Add(Convert.ToString(r[1]), Convert.ToString(r[0]));
            //}
        }
        private void LoadStoreStatusComboBox() {
            //Utils.CheckConnection();
            //cbStoreStatusID.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            //lblElapsedTime.Text = Convert.ToString(watch.ElapsedMilliseconds / 1000);
            lblElapsedTime.Text = (String.Format("{0:d\\:hh\\:mm\\:ss}", watch.Elapsed));
            lblCurrentTime.Text = (String.Format("{0:hh\\:mm\\:ss tt}", DateTime.Now));
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e) {
            /*
            txtResults.Height = this.Height - 180;
            lblVersion.Location = new Point(lblVersion.Location.X, this.Height - lblVersion.Height * 4 - 5);
            lblStatus.Location = new Point(lblStatus.Location.X, this.Height - lblStatus.Height * 6 - 5);
            lblElapsedTime.Location = new Point(lblElapsedTime.Location.X, this.Height - lblElapsedTime.Height * 4 - 5);
            btnGo.Location = new Point(this.Width - btnGo.Width - btnGo.Width/2, this.Height - btnGo.Height * 3);
            */
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            // Invoke the Coupon Web Service
            GroceryStoreSimulator.CouponServiceReference.CouponServiceSoapClient cs = new GroceryStoreSimulator.CouponServiceReference.CouponServiceSoapClient();
            int couponID = cs.ValidateCoupon(txtCoupon.Text);
            if (couponID > 0) {
                lblCouponValidationResult.Text = "Valid";
            } else {
                lblCouponValidationResult.Text = "NOT Valid";
            }
            lblCouponValidationResult.Visible = true;
        }

        private void btnGetCouponInfo_Click(object sender, EventArgs e) {
            /*
                        try {
            //                GroceryStoreSimulator.CouponServiceReference.CouponServiceSoapClient cs = new GroceryStoreSimulator.CouponServiceReference.CouponServiceSoapClient();
            //                CouponServiceReference.Coupon coupon = cs.GetCouponInfo(Convert.ToInt32(txtCouponID.Text));
            /*
                            tCoupon.fGetCouponDataTable couponDataTable = LoadCoupon(txtCouponID.Text);
                            if (couponDataTable != null) {
                                try {
                                    txtCouponGetInfoResult.Text = "Found it: Coupon = " + coupon.description;
                                    for (int i = 0; i < couponDataTable.couponDetails.Count(); i++) {
                                        txtCouponGetInfoResult.Text += ", " + " Product = " + couponDataTable.couponDetails[i].product;
                                    }
                                } catch (Exception ex) {
                                    txtCouponGetInfoResult.Text = "Found it: Coupon = " + couponDataTable.description + ", " + " No products on the coupon!";
                                    Utils.Log(ex.Message);
                                }
                            } else {
                                txtCouponGetInfoResult.Text = "DID NOT find it";
                            }
                            txtCouponGetInfoResult.Visible = true;
                        } catch (Exception ex) {
                            Utils.Log(ex.Message);
                            txtCouponGetInfoResult.Text = "Error: " + ex.Message;
                        }
             */
        }
        /// <summary>
        /// Event handler for Add Store Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStore_Click(object sender, EventArgs e) {
            if (txtStoreNumber.Text.Trim().Length > 0 && txtStore.Text.Trim().Length > 0) {
                if (Convert.ToInt32(Utils.MyDLookup("StoreID",
                                                    "tStore",
                                                    "StoreNumber = " + Utils.QuoteMeForSQL(txtStoreNumber.Text.Trim()),
                                                    "Count")) == 0) {
                    if (addStore()) {
                        txtStoreStatus.AppendText(Environment.NewLine + "Store " + txtStoreNumber.Text.Trim() + " added");
                    } else {
                        txtStoreStatus.AppendText(Environment.NewLine + "Store " + txtStoreNumber.Text.Trim() + " NOT added");
                    }
                } else {
                    MessageBox.Show("Store Number already exists");
                }
            } else {
                MessageBox.Show("Store Number and Store Name cannot be blank");
            }
        }
        /// <summary>
        /// Add a store to the database
        /// </summary>
        /// <returns>True on success, false otherwise</returns>
        private bool addStore() {
            SqlCommand cmd = new SqlCommand();
            bool status = true;
            try {
                Utils.CheckConnection();
                cmd.CommandText = "spAddStoreWithStoreStatus";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Config.myConnection;

                cmd.Parameters.Add(new SqlParameter("StoreNumber", txtStoreNumber.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("Store", txtStore.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("Address1", txtAddress1.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("Address2", txtAddress2.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("City", txtCity.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("State", txtState.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("Zip", txtZip.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("ManagerID", cbManagerID.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("StoreStatusID", cbStoreStatusID.SelectedValue));
                cmd.ExecuteNonQuery();
                int storeID;
                storeID = Convert.ToInt32(Utils.MyDLookup("StoreID", "tStore", "StoreNumber = " + Utils.QuoteMeForSQL(txtStoreNumber.Text.Trim()), ""));
                // Add product price history records for the new store and all the current products
                cmd.Parameters.Clear();
                cmd.CommandText = "AddProductsToProductPriceHistForOneStore";
                cmd.Parameters.Add(new SqlParameter("StoreID", storeID));
                cmd.ExecuteNonQuery();

            } catch (Exception ex) {
                status = false;
                txtStoreStatus.AppendText(ex.Message);
            }
            return status;
        }

        private void btnAddCoupons_Click(object sender, EventArgs e) {
            try {
                // Copy date range from the GUI to the config settings
                Config.startDate = Convert.ToDateTime(txtStartDate.Text);
                Config.throughDate = Convert.ToDateTime(txtThroughDate.Text);
                SqlConnection connection = new SqlConnection(Config.connectionString);
                connection.Open();
                Config.initRandomNumberGenerator(Convert.ToInt32(txtSeed.Text));
                SimCoupon simCoupon = new SimCoupon();
                TextBox.CheckForIllegalCrossThreadCalls = false;    // We will spawn a thread that writes to a control on this thread.
                Label.CheckForIllegalCrossThreadCalls = false;    // We will spawn a thread that writes to a control on this thread.
                simCoupon.StartCouponSimulation(Convert.ToInt32(txtCouponsToAdd.Text), Config.random, connection, txtCouponStatus, lblCouponStatus);
            } catch (Exception ex) {
                txtCouponStatus.Text = ex.Message;
            }
        }

        private void cbRunForever_CheckedChanged(object sender, EventArgs e) {
            if (cbRunForever.Checked == true) {
                txtNumOfTransactionsToAdd.Enabled = false;
            } else {
                txtNumOfTransactionsToAdd.Enabled = true;
            }
        }

        private void btnResetStoreStatusHistory_Click(object sender, EventArgs e) {
            if (MessageBox.Show("This will delete all the store history. Are you sure?", "Are you really sure?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                int storeStatusID;
                String msg = "";
                storeStatusID = Convert.ToInt32(cbNewStoreStatusID.SelectedValue);
                if (tStoreStatus.ResetStoreStatusHistory(storeStatusID, txtStoreStatus) == true) {
                    msg = "Store status history has been reset.";
                } else {
                    msg = "Store status history has not been reset.";
                }
                txtStoreStatus.AppendText(Environment.NewLine + msg);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("This will populate tIngredient and tProductIngredient from tProduct.Ingredients. It will take a long time and it's probably already been done.",
                                                  "You probably do not need to do this.",
                                                  MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) {
                pnlIngredients.Visible = true;
                txtIngredients.Focus();
                btnProcessIngredients.Visible = false;
                Ingredients i = new Ingredients();
                i.AddAllIngredients(txtIngredients);
                pnlIngredients.Visible = false;
                btnProcessIngredients.Visible = true;
                btnProcessIngredients.Focus();
            }
        }

        private void btnCalcNewProductPrice_Click(object sender, EventArgs e) {
            // ProductPriceHist.AddProductPriceHist(Config.random); // Add a new price for a random product/store. This isn't all that useful.       

            DialogResult result = MessageBox.Show("Update all product prices at all stores for " + txtStartDate.Text + "? Are you sure?", "This could take a while.", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) {
                try {
                    DateTime myStartDate = DateTime.Parse(txtStartDate.Text);
                    ProductPriceHist.UpdateAllProductStorePrices(Config.random, txtProductPriceHist, DateTime.Parse(txtStartDate.Text));
                } catch (Exception ex) {
                    Utils.Log(ex.Message);
                    MessageBox.Show("Start Date is invalid. Cannot process product price history.", "Check start date");
                }
            }
        }
        private void btnInitRandomNumberGenerator_Click(object sender, EventArgs e) {
            InitRandomNumberGenerator();
        }

        private void btnReinitializeProductPriceHistory_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Delete product price history and reinitialize from the original product prices? Are you sure?", "This will delete all product price history!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) {
                ProductPriceHist.InitializeProductPriceHistAndCopyFromFromProductTable(Config.earliestPossibleDate);
            }
        }

        /// <summary>
        /// Look up some products and display some info about them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLookUpProduct_Click(object sender, EventArgs e) {
            Product.DisplayProductInfo(txtProduct.Text, txtProductInfo);
        }

        private void FillDatasets() {
            try {
                Utils.CheckConnection();
                // This line of code loads data into the 'dataSet2.vStoreStatusTable' table. You can move, or remove it, as needed.
//                vStoreStatusTableTableAdapter.Connection = Config.myConnection;
//              this.vStoreStatusTableTableAdapter.Fill(this.dataSet2.vStoreStatusTable);
                // This line of code loads data into the 'dataSet1.fEmployeesWhoCanBeAStoreManager' table. You can move, or remove it, as needed.
                //fEmployeesWhoCanBeAStoreManagerTableAdapter.Connection = Config.myConnection;
//                this.fEmployeesWhoCanBeAStoreManagerTableAdapter.Fill(this.dataSet1.fEmployeesWhoCanBeAStoreManager);
                //LoadManagerComboBox();
                //LoadStoreStatusComboBox();
            } catch (Exception ex) {
                txtStoreStatus.AppendText(Environment.NewLine + ex.Message);
            }
        }

        private void tcSimulate_Enter(object sender, EventArgs e) {
            // Try to connect to the database server and populate the drop-down controls
            FillDatasets();
        }

        private void btnTestDatabaseConnection_Click(object sender, EventArgs e) {
            try {
                Config.server = txtServer.Text.Trim();
                Config.password = txtPassword.Text.Trim();
                Config.login = txtLogin.Text.Trim();
                Config.database = txtDatabase.Text.Trim();
                if (Utils.CheckConnection()) {
                    txtConfig.AppendText(Environment.NewLine + "Connection verified to " + txtServer.Text.Trim() + " .");
                } else {
                    txtConfig.AppendText(Environment.NewLine + "Connection failed " + txtServer.Text.Trim() + " .");
                }
            } catch (Exception ex) {
                txtConfig.AppendText("Connection failed! ");
                txtConfig.AppendText(Environment.NewLine + ex.Message);
            }
        }

        private void InitIntervalComboBox(ComboBox cb) {
            cb.Items.Clear();
            foreach (String interval in Config.availableCheckIntervals) {
                cb.Items.Add(interval);
            }
        }

        private void txtStartDate_MouseDoubleClick(object sender, MouseEventArgs e) {
            txtStartDate.Text = DateTime.Now.ToShortDateString();
        }

        private void txtThroughDate_MouseDoubleClick(object sender, MouseEventArgs e) {
            txtThroughDate.Text = DateTime.Now.AddYears(100).ToShortDateString();
        }

        private void btnDeleteAllHistoryData_Click(object sender, EventArgs e) {
            if (MessageBox.Show("This will delete all history for transactions, product prices, store status, and employee status!", "Are you sure? Truly sure?", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                try {
                    Utils.ExecuteNonQuery("zDeleteAllHistoryData", CommandType.StoredProcedure, null, null);
                    Utils.Log("zDeleteAllHistoryData was executed.");
                } catch (Exception ex) {
                    Utils.Log("btnDeleteAllHistoryData_Click: " + ex.Message);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            GroceryStoreSimulator.frmAbout frm = new GroceryStoreSimulator.frmAbout();
            frm.Show();
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e) {
            //frmPlaceAnOrder placeAnOrder = new frmPlaceAnOrder();
            //placeAnOrder.Show();

        }

        private void btnTestProductInfoWebService_Click(object sender, EventArgs e) {
            //            http://restsharp.org/ from nuGet
            //              NewtonSoft JsonConvert from nuGet
            RestClient client = new RestClient("http://localhost:20570/ProductInfoService.svc/ProductInfo/");
            RestRequest request = new RestRequest(txtProductID.Text, Method.GET) { RequestFormat = DataFormat.Json };
            RestResponse<ProductInfoWebService.ProductInfoREST.Product> response = (RestResponse<ProductInfoWebService.ProductInfoREST.Product>)client.Execute<ProductInfoWebService.ProductInfoREST.Product>(request);

            txtProductInfo.Text = response.Content;
        }

        private void btnUPCLookupOnlineSubmit_Click(object sender, EventArgs e)
        {
            txtCompleteURL.Text = "";
            txtUPCLookupOnlineResults.Text = "";
            if (cbURL.SelectedIndex > -1)
            {
                if (txtUPC.Text.Trim().Length != 0)
                {
                    if (cbURL.SelectedItem.ToString().Contains("upcitemdb"))
                    {
                        try
                        {
                            String url = cbURL.SelectedItem.ToString() + "?" + "upc=" + txtUPC.Text.Trim();
                            txtCompleteURL.Text = url;
                            String response = Get(url);
                            txtUPCLookupOnlineResults.Text = response;
                            var foo = JsonConvert.DeserializeObject<object>(response);
                            //MessageBox.Show(foo["items"].ToString());
                            myDeserialize(response);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error requesting UPC Data: " + ex.Message, "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (cbURL.SelectedItem.ToString().Contains("upcdatabase"))
                    {
                        String url = cbURL.SelectedItem.ToString()
                                         + "product/"
                                         + txtUPC.Text.ToString().Trim()
                                         + "?" + "apikey=" + "D9D70594759A404808F06BC4098EE3B9";
                        txtCompleteURL.Text = url;
                        String response = Get(url);
                        txtUPCLookupOnlineResults.Text = response;
                        var foo = JsonConvert.DeserializeObject<object>(response);
                        //MessageBox.Show(foo["items"].ToString());
                        myDeserialize(response);
                    }
                    else if (cbURL.SelectedItem.ToString().Contains("barcodelookup.com")) {
//                      https://api.barcodelookup.com/v3/products?barcode=9780140157376&formatted=y&key=euqiq5ek5npia1q8v0hytv0kie3syp
                        String url = "https://api.barcodelookup.com/v3/products?barcode="
                                     + txtUPC.Text.ToString().Trim()
                                     + "&" + "formatted=y&key=" + "euqiq5ek5npia1q8v0hytv0kie3syp";
                        txtCompleteURL.Text = url;
                        String response = Get(url);
                        if (response != null)
                        {
                            txtUPCLookupOnlineResults.Text = response;
                            var foo = JsonConvert.DeserializeObject<object>(response);
                            //MessageBox.Show(foo["items"].ToString());
                            myDeserializeFromBarcodeLookupDotCom(response);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No URL selected or URL not recognized", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Need a UPC.", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Need a URL/Provider.", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// See https://www.newtonsoft.com/json/help/html/QueryJson.htm
        /// </summary>
        /// <param name="jsonString">The JSON returned by the Web Get </param>
        private void myDeserializeFromBarcodeLookupDotCom(String jsonString)
        {
            try
            {
                JObject rss = JObject.Parse(jsonString);
                String title = (String)rss["products"][0]["title"];
                String description = "";  // (String)rss["items"][0]["description"];
                String category = (String)rss["products"][0]["category"];
                String brand = (String)rss["products"][0]["brand"];
                String model = (String)rss["products"][0]["model"];
                String manufacturer = (String)rss["products"][0]["manufacturer"];
                String productIngredients = (String)rss["products"][0]["ingredients"];
                txtTitle.Text = title;
                txtDescription.Text = description;
                txtCategory.Text = category;
                txtBrand.Text = brand;
                txtModel.Text = model;
                txtManufacturer.Text = manufacturer;
                txtProductIngredients.Text = productIngredients;
            }
            catch (Exception ex) { }
        }
        /// <summary>
        /// See https://www.newtonsoft.com/json/help/html/QueryJson.htm
        /// </summary>
        /// <param name="jsonString">The JSON returned by the Web Get </param>
        private void myDeserialize(String jsonString)
        {
            try {
                JObject rss = JObject.Parse(jsonString);
                String title = (String)rss["items"][0]["title"];
                String description = (String)rss["items"][0]["description"];
                String category = (String)rss["items"][0]["category"];
                String brand = (String)rss["items"][0]["brand"];
                String model = (String)rss["items"][0]["model"];
                String manufacturer = (String)rss["items"][0]["manufacturer"];
                txtTitle.Text = title;
                txtDescription.Text = description;
                txtCategory.Text = category;
                txtBrand.Text = brand;
                txtModel.Text = model;
                txtManufacturer.Text = manufacturer;
            } catch (Exception ex) { }
        }
        public string Get(string uri)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Attempting to Access Web Site", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPrioritizeProducts_CheckedChanged(object sender, EventArgs e)
        {
            // User checked/unchecked the Product Prioritization feature
            UpdateControls();
        }
        private void UpdateControls()
        {
            // Show and Hide don't work on individual tab pages:
            // https://stackoverflow.com/questions/22323836/hide-show-tab-pages-c-sharp
            if (cbPrioritizeProducts.Checked) {
                //tpProductPrioritization.Show();
                tcSimulate.TabPages.Add(tpProductPrioritization);
            } else {
                //tpProductPrioritization.Hide();
                tcSimulate.TabPages.Remove(tpProductPrioritization);
            }

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }
    }
 }