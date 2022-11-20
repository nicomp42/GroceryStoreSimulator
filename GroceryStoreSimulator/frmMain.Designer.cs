﻿namespace SimulatorGUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.vStoreStatusTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fEmployeesWhoCanBeAStoreManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpConfig = new System.Windows.Forms.TabPage();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.cbCheckForAllStoresClosed = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cbPrioritizeProducts = new System.Windows.Forms.CheckBox();
            this.btnDeleteAllHistoryData = new System.Windows.Forms.Button();
            this.cbExecuteFailSafe = new System.Windows.Forms.CheckBox();
            this.cbCouponAmountToAdd = new System.Windows.Forms.ComboBox();
            this.lblCouponAdd = new System.Windows.Forms.Label();
            this.cbCouponCheckInterval = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.pnlUseCurrentDateStampForTransaction = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.cbUseCurrentDateStampForTransaction = new System.Windows.Forms.CheckBox();
            this.txtThroughDate = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblProductCheckInterval = new System.Windows.Forms.Label();
            this.lblEmplCheckInterval = new System.Windows.Forms.Label();
            this.lblStoreCheckInterval = new System.Windows.Forms.Label();
            this.cbProductCheckInterval = new System.Windows.Forms.ComboBox();
            this.cbEmplCheckInterval = new System.Windows.Forms.ComboBox();
            this.cbStoreCheckInterval = new System.Windows.Forms.ComboBox();
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtTransactionDelay = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnTestDatabaseConnection = new System.Windows.Forms.Button();
            this.btnInitRandomNumberGenerator = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbRunForever = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUseCoupons = new System.Windows.Forms.CheckBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblMilliseconds = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.lblElapsedMinutesToRun = new System.Windows.Forms.Label();
            this.cbIgnoreElapsedTime = new System.Windows.Forms.CheckBox();
            this.txtElapsedTimeToRun = new System.Windows.Forms.TextBox();
            this.txtNumOfTransactionsToAdd = new System.Windows.Forms.TextBox();
            this.tpIngredients = new System.Windows.Forms.TabPage();
            this.btnProcessIngredients = new System.Windows.Forms.Button();
            this.pnlIngredients = new System.Windows.Forms.Panel();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.tpProducts = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.btnReinitializeProductPriceHistory = new System.Windows.Forms.Button();
            this.txtProductPriceHist = new System.Windows.Forms.TextBox();
            this.txtProductInfo = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnCalcNewProductPrice = new System.Windows.Forms.Button();
            this.btnLookUpProduct = new System.Windows.Forms.Button();
            this.tpStores = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetStoreStatusHistory = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.cbNewStoreStatusID = new System.Windows.Forms.ComboBox();
            this.txtStoreStatus = new System.Windows.Forms.TextBox();
            this.pnlAddStore = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cbStoreStatusID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbManagerID = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStoreNumber = new System.Windows.Forms.TextBox();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.tpCoupon = new System.Windows.Forms.TabPage();
            this.lblCouponStatus = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCouponsToAdd = new System.Windows.Forms.TextBox();
            this.txtCouponStatus = new System.Windows.Forms.TextBox();
            this.txtCouponGetInfoResult = new System.Windows.Forms.TextBox();
            this.txtCouponID = new System.Windows.Forms.TextBox();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.btnAddCoupons = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetCouponInfo = new System.Windows.Forms.Button();
            this.lblCouponValidationResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tpSimulate = new System.Windows.Forms.TabPage();
            this.lblStartTimeLabel = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblCurrentTimeLabel = new System.Windows.Forms.Label();
            this.lblElapsedTimeLabel = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.pbGroceries = new System.Windows.Forms.PictureBox();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnStartTransactionSimulator = new System.Windows.Forms.Button();
            this.tcSimulate = new System.Windows.Forms.TabControl();
            this.tpTest = new System.Windows.Forms.TabPage();
            this.txtProductInfoWebServiceResults = new System.Windows.Forms.TextBox();
            this.btnTestProductInfoWebService = new System.Windows.Forms.Button();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.tpUPCLookup01 = new System.Windows.Forms.TabPage();
            this.label35 = new System.Windows.Forms.Label();
            this.txtProductIngredients = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.lblProviderNotes = new System.Windows.Forms.Label();
            this.txtCompleteURL = new System.Windows.Forms.TextBox();
            this.cbURL = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtUPCLookupOnlineResults = new System.Windows.Forms.TextBox();
            this.btnUPCLookupOnlineSubmit = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.tpProductPrioritization = new System.Windows.Forms.TabPage();
            this.gbProductPrioritizationModes = new System.Windows.Forms.GroupBox();
            this.lblNotImplemented = new System.Windows.Forms.Label();
            this.rbPrioritizeProductsAtStartOfEachDay = new System.Windows.Forms.RadioButton();
            this.rbPrioritizeProductsAtStartOfSimulationOnly = new System.Windows.Forms.RadioButton();
            this.rbPrioritizeProductsEachDayOfMonth = new System.Windows.Forms.RadioButton();
            this.rbPrioritizeProductsEachDayOfWeek = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.vStoreStatusTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEmployeesWhoCanBeAStoreManagerBindingSource)).BeginInit();
            this.tpConfig.SuspendLayout();
            this.pnlUseCurrentDateStampForTransaction.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpIngredients.SuspendLayout();
            this.pnlIngredients.SuspendLayout();
            this.tpProducts.SuspendLayout();
            this.tpStores.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAddStore.SuspendLayout();
            this.tpCoupon.SuspendLayout();
            this.tpSimulate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroceries)).BeginInit();
            this.tcSimulate.SuspendLayout();
            this.tpTest.SuspendLayout();
            this.tpUPCLookup01.SuspendLayout();
            this.tpProductPrioritization.SuspendLayout();
            this.gbProductPrioritizationModes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tpConfig
            // 
            this.tpConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpConfig.Controls.Add(this.label37);
            this.tpConfig.Controls.Add(this.label38);
            this.tpConfig.Controls.Add(this.cbCheckForAllStoresClosed);
            this.tpConfig.Controls.Add(this.label36);
            this.tpConfig.Controls.Add(this.cbPrioritizeProducts);
            this.tpConfig.Controls.Add(this.btnDeleteAllHistoryData);
            this.tpConfig.Controls.Add(this.cbExecuteFailSafe);
            this.tpConfig.Controls.Add(this.cbCouponAmountToAdd);
            this.tpConfig.Controls.Add(this.lblCouponAdd);
            this.tpConfig.Controls.Add(this.cbCouponCheckInterval);
            this.tpConfig.Controls.Add(this.label25);
            this.tpConfig.Controls.Add(this.pnlUseCurrentDateStampForTransaction);
            this.tpConfig.Controls.Add(this.lblProductCheckInterval);
            this.tpConfig.Controls.Add(this.lblEmplCheckInterval);
            this.tpConfig.Controls.Add(this.lblStoreCheckInterval);
            this.tpConfig.Controls.Add(this.cbProductCheckInterval);
            this.tpConfig.Controls.Add(this.cbEmplCheckInterval);
            this.tpConfig.Controls.Add(this.cbStoreCheckInterval);
            this.tpConfig.Controls.Add(this.txtConfig);
            this.tpConfig.Controls.Add(this.txtSeed);
            this.tpConfig.Controls.Add(this.txtDatabase);
            this.tpConfig.Controls.Add(this.txtTransactionDelay);
            this.tpConfig.Controls.Add(this.txtPassword);
            this.tpConfig.Controls.Add(this.txtLogin);
            this.tpConfig.Controls.Add(this.txtServer);
            this.tpConfig.Controls.Add(this.btnTestDatabaseConnection);
            this.tpConfig.Controls.Add(this.btnInitRandomNumberGenerator);
            this.tpConfig.Controls.Add(this.lblVersion);
            this.tpConfig.Controls.Add(this.label20);
            this.tpConfig.Controls.Add(this.cbRunForever);
            this.tpConfig.Controls.Add(this.label19);
            this.tpConfig.Controls.Add(this.label2);
            this.tpConfig.Controls.Add(this.label1);
            this.tpConfig.Controls.Add(this.cbUseCoupons);
            this.tpConfig.Controls.Add(this.lblDatabase);
            this.tpConfig.Controls.Add(this.lblMilliseconds);
            this.tpConfig.Controls.Add(this.label17);
            this.tpConfig.Controls.Add(this.label16);
            this.tpConfig.Controls.Add(this.label15);
            this.tpConfig.Controls.Add(this.lblServer);
            this.tpConfig.Controls.Add(this.panel2);
            this.tpConfig.Location = new System.Drawing.Point(4, 25);
            this.tpConfig.Margin = new System.Windows.Forms.Padding(4);
            this.tpConfig.Name = "tpConfig";
            this.tpConfig.Padding = new System.Windows.Forms.Padding(4);
            this.tpConfig.Size = new System.Drawing.Size(1183, 639);
            this.tpConfig.TabIndex = 4;
            this.tpConfig.Text = "Config";
            this.tpConfig.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(305, 428);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(140, 16);
            this.label37.TabIndex = 66;
            this.label37.Text = "(Not Implemented Yet)";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(36, 428);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(174, 16);
            this.label38.TabIndex = 65;
            this.label38.Text = "Check For All Stores Closed";
            // 
            // cbCheckForAllStoresClosed
            // 
            this.cbCheckForAllStoresClosed.AutoSize = true;
            this.cbCheckForAllStoresClosed.Checked = true;
            this.cbCheckForAllStoresClosed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCheckForAllStoresClosed.Location = new System.Drawing.Point(272, 428);
            this.cbCheckForAllStoresClosed.Margin = new System.Windows.Forms.Padding(4);
            this.cbCheckForAllStoresClosed.Name = "cbCheckForAllStoresClosed";
            this.cbCheckForAllStoresClosed.Size = new System.Drawing.Size(15, 14);
            this.cbCheckForAllStoresClosed.TabIndex = 64;
            this.cbCheckForAllStoresClosed.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(36, 404);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(221, 16);
            this.label36.TabIndex = 62;
            this.label36.Text = "Prioritize Products During Simulation";
            // 
            // cbPrioritizeProducts
            // 
            this.cbPrioritizeProducts.AutoSize = true;
            this.cbPrioritizeProducts.Checked = true;
            this.cbPrioritizeProducts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPrioritizeProducts.Location = new System.Drawing.Point(273, 402);
            this.cbPrioritizeProducts.Margin = new System.Windows.Forms.Padding(4);
            this.cbPrioritizeProducts.Name = "cbPrioritizeProducts";
            this.cbPrioritizeProducts.Size = new System.Drawing.Size(15, 14);
            this.cbPrioritizeProducts.TabIndex = 61;
            this.cbPrioritizeProducts.UseVisualStyleBackColor = true;
            this.cbPrioritizeProducts.CheckedChanged += new System.EventHandler(this.cbPrioritizeProducts_CheckedChanged);
            // 
            // btnDeleteAllHistoryData
            // 
            this.btnDeleteAllHistoryData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteAllHistoryData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteAllHistoryData.Location = new System.Drawing.Point(1031, 80);
            this.btnDeleteAllHistoryData.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAllHistoryData.Name = "btnDeleteAllHistoryData";
            this.btnDeleteAllHistoryData.Size = new System.Drawing.Size(100, 42);
            this.btnDeleteAllHistoryData.TabIndex = 60;
            this.btnDeleteAllHistoryData.Text = "Delete all history data";
            this.btnDeleteAllHistoryData.UseVisualStyleBackColor = true;
            this.btnDeleteAllHistoryData.Click += new System.EventHandler(this.btnDeleteAllHistoryData_Click);
            // 
            // cbExecuteFailSafe
            // 
            this.cbExecuteFailSafe.AutoSize = true;
            this.cbExecuteFailSafe.Location = new System.Drawing.Point(821, 240);
            this.cbExecuteFailSafe.Margin = new System.Windows.Forms.Padding(4);
            this.cbExecuteFailSafe.Name = "cbExecuteFailSafe";
            this.cbExecuteFailSafe.Size = new System.Drawing.Size(179, 20);
            this.cbExecuteFailSafe.TabIndex = 56;
            this.cbExecuteFailSafe.Text = "Execute Fail Safe Options";
            this.cbExecuteFailSafe.UseVisualStyleBackColor = true;
            // 
            // cbCouponAmountToAdd
            // 
            this.cbCouponAmountToAdd.FormattingEnabled = true;
            this.cbCouponAmountToAdd.Items.AddRange(new object[] {
            "1 coupon",
            "5 coupons",
            "10 coupons",
            "100 coupons",
            "1000 coupons",
            "10000 coupons",
            "100000 coupons",
            "1000000 coupons"});
            this.cbCouponAmountToAdd.Location = new System.Drawing.Point(561, 369);
            this.cbCouponAmountToAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cbCouponAmountToAdd.Name = "cbCouponAmountToAdd";
            this.cbCouponAmountToAdd.Size = new System.Drawing.Size(160, 24);
            this.cbCouponAmountToAdd.TabIndex = 55;
            // 
            // lblCouponAdd
            // 
            this.lblCouponAdd.AutoSize = true;
            this.lblCouponAdd.Location = new System.Drawing.Point(517, 375);
            this.lblCouponAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCouponAdd.Name = "lblCouponAdd";
            this.lblCouponAdd.Size = new System.Drawing.Size(31, 16);
            this.lblCouponAdd.TabIndex = 54;
            this.lblCouponAdd.Text = "add";
            // 
            // cbCouponCheckInterval
            // 
            this.cbCouponCheckInterval.FormattingEnabled = true;
            this.cbCouponCheckInterval.Location = new System.Drawing.Point(273, 369);
            this.cbCouponCheckInterval.Margin = new System.Windows.Forms.Padding(4);
            this.cbCouponCheckInterval.Name = "cbCouponCheckInterval";
            this.cbCouponCheckInterval.Size = new System.Drawing.Size(232, 24);
            this.cbCouponCheckInterval.TabIndex = 53;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(36, 373);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(148, 16);
            this.label25.TabIndex = 52;
            this.label25.Text = "Coupon Update Interval";
            // 
            // pnlUseCurrentDateStampForTransaction
            // 
            this.pnlUseCurrentDateStampForTransaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUseCurrentDateStampForTransaction.Controls.Add(this.label24);
            this.pnlUseCurrentDateStampForTransaction.Controls.Add(this.cbUseCurrentDateStampForTransaction);
            this.pnlUseCurrentDateStampForTransaction.Controls.Add(this.txtThroughDate);
            this.pnlUseCurrentDateStampForTransaction.Controls.Add(this.label23);
            this.pnlUseCurrentDateStampForTransaction.Controls.Add(this.txtStartDate);
            this.pnlUseCurrentDateStampForTransaction.Location = new System.Drawing.Point(821, 268);
            this.pnlUseCurrentDateStampForTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUseCurrentDateStampForTransaction.Name = "pnlUseCurrentDateStampForTransaction";
            this.pnlUseCurrentDateStampForTransaction.Size = new System.Drawing.Size(340, 123);
            this.pnlUseCurrentDateStampForTransaction.TabIndex = 51;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 50);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 16);
            this.label24.TabIndex = 49;
            this.label24.Text = "Through Date";
            // 
            // cbUseCurrentDateStampForTransaction
            // 
            this.cbUseCurrentDateStampForTransaction.AutoSize = true;
            this.cbUseCurrentDateStampForTransaction.Checked = true;
            this.cbUseCurrentDateStampForTransaction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseCurrentDateStampForTransaction.Location = new System.Drawing.Point(125, 86);
            this.cbUseCurrentDateStampForTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.cbUseCurrentDateStampForTransaction.Name = "cbUseCurrentDateStampForTransaction";
            this.cbUseCurrentDateStampForTransaction.Size = new System.Drawing.Size(188, 20);
            this.cbUseCurrentDateStampForTransaction.TabIndex = 50;
            this.cbUseCurrentDateStampForTransaction.Text = "Use Current Date and Time";
            this.cbUseCurrentDateStampForTransaction.UseVisualStyleBackColor = true;
            // 
            // txtThroughDate
            // 
            this.txtThroughDate.Location = new System.Drawing.Point(125, 50);
            this.txtThroughDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtThroughDate.Name = "txtThroughDate";
            this.txtThroughDate.Size = new System.Drawing.Size(176, 22);
            this.txtThroughDate.TabIndex = 48;
            this.txtThroughDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtThroughDate_MouseDoubleClick);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 21);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 16);
            this.label23.TabIndex = 47;
            this.label23.Text = "Start Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(125, 21);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(176, 22);
            this.txtStartDate.TabIndex = 46;
            this.txtStartDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtStartDate_MouseDoubleClick);
            // 
            // lblProductCheckInterval
            // 
            this.lblProductCheckInterval.AutoSize = true;
            this.lblProductCheckInterval.Location = new System.Drawing.Point(36, 340);
            this.lblProductCheckInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductCheckInterval.Name = "lblProductCheckInterval";
            this.lblProductCheckInterval.Size = new System.Drawing.Size(140, 16);
            this.lblProductCheckInterval.TabIndex = 45;
            this.lblProductCheckInterval.Text = "Product Check Interval";
            // 
            // lblEmplCheckInterval
            // 
            this.lblEmplCheckInterval.AutoSize = true;
            this.lblEmplCheckInterval.Location = new System.Drawing.Point(36, 306);
            this.lblEmplCheckInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmplCheckInterval.Name = "lblEmplCheckInterval";
            this.lblEmplCheckInterval.Size = new System.Drawing.Size(156, 16);
            this.lblEmplCheckInterval.TabIndex = 44;
            this.lblEmplCheckInterval.Text = "Employee Check Interval";
            // 
            // lblStoreCheckInterval
            // 
            this.lblStoreCheckInterval.AutoSize = true;
            this.lblStoreCheckInterval.Location = new System.Drawing.Point(36, 273);
            this.lblStoreCheckInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStoreCheckInterval.Name = "lblStoreCheckInterval";
            this.lblStoreCheckInterval.Size = new System.Drawing.Size(126, 16);
            this.lblStoreCheckInterval.TabIndex = 43;
            this.lblStoreCheckInterval.Text = "Store Check Interval";
            // 
            // cbProductCheckInterval
            // 
            this.cbProductCheckInterval.FormattingEnabled = true;
            this.cbProductCheckInterval.Location = new System.Drawing.Point(273, 336);
            this.cbProductCheckInterval.Margin = new System.Windows.Forms.Padding(4);
            this.cbProductCheckInterval.Name = "cbProductCheckInterval";
            this.cbProductCheckInterval.Size = new System.Drawing.Size(232, 24);
            this.cbProductCheckInterval.TabIndex = 42;
            // 
            // cbEmplCheckInterval
            // 
            this.cbEmplCheckInterval.FormattingEnabled = true;
            this.cbEmplCheckInterval.Location = new System.Drawing.Point(273, 303);
            this.cbEmplCheckInterval.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmplCheckInterval.Name = "cbEmplCheckInterval";
            this.cbEmplCheckInterval.Size = new System.Drawing.Size(232, 24);
            this.cbEmplCheckInterval.TabIndex = 41;
            // 
            // cbStoreCheckInterval
            // 
            this.cbStoreCheckInterval.FormattingEnabled = true;
            this.cbStoreCheckInterval.Location = new System.Drawing.Point(273, 270);
            this.cbStoreCheckInterval.Margin = new System.Windows.Forms.Padding(4);
            this.cbStoreCheckInterval.Name = "cbStoreCheckInterval";
            this.cbStoreCheckInterval.Size = new System.Drawing.Size(232, 24);
            this.cbStoreCheckInterval.TabIndex = 40;
            // 
            // txtConfig
            // 
            this.txtConfig.Location = new System.Drawing.Point(16, 469);
            this.txtConfig.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfig.Multiline = true;
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConfig.Size = new System.Drawing.Size(1145, 127);
            this.txtConfig.TabIndex = 39;
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(973, 156);
            this.txtSeed.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(48, 22);
            this.txtSeed.TabIndex = 15;
            this.txtSeed.Text = "42";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(131, 85);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(269, 22);
            this.txtDatabase.TabIndex = 9;
            // 
            // txtTransactionDelay
            // 
            this.txtTransactionDelay.Location = new System.Drawing.Point(273, 127);
            this.txtTransactionDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTransactionDelay.Name = "txtTransactionDelay";
            this.txtTransactionDelay.Size = new System.Drawing.Size(84, 22);
            this.txtTransactionDelay.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(452, 53);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(129, 53);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(207, 22);
            this.txtLogin.TabIndex = 2;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(129, 21);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(731, 22);
            this.txtServer.TabIndex = 0;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // btnTestDatabaseConnection
            // 
            this.btnTestDatabaseConnection.Location = new System.Drawing.Point(884, 21);
            this.btnTestDatabaseConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDatabaseConnection.Name = "btnTestDatabaseConnection";
            this.btnTestDatabaseConnection.Size = new System.Drawing.Size(100, 65);
            this.btnTestDatabaseConnection.TabIndex = 38;
            this.btnTestDatabaseConnection.Text = "Test Database Connection";
            this.btnTestDatabaseConnection.UseVisualStyleBackColor = true;
            this.btnTestDatabaseConnection.Click += new System.EventHandler(this.btnTestDatabaseConnection_Click);
            // 
            // btnInitRandomNumberGenerator
            // 
            this.btnInitRandomNumberGenerator.Location = new System.Drawing.Point(1031, 153);
            this.btnInitRandomNumberGenerator.Margin = new System.Windows.Forms.Padding(4);
            this.btnInitRandomNumberGenerator.Name = "btnInitRandomNumberGenerator";
            this.btnInitRandomNumberGenerator.Size = new System.Drawing.Size(100, 65);
            this.btnInitRandomNumberGenerator.TabIndex = 34;
            this.btnInitRandomNumberGenerator.Text = "Init Random Number Generator";
            this.btnInitRandomNumberGenerator.UseVisualStyleBackColor = true;
            this.btnInitRandomNumberGenerator.Click += new System.EventHandler(this.btnInitRandomNumberGenerator_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(992, 21);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(2, 22);
            this.lblVersion.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(307, 230);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 16);
            this.label20.TabIndex = 30;
            this.label20.Text = "or ";
            // 
            // cbRunForever
            // 
            this.cbRunForever.AutoSize = true;
            this.cbRunForever.Checked = true;
            this.cbRunForever.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRunForever.Location = new System.Drawing.Point(343, 229);
            this.cbRunForever.Margin = new System.Windows.Forms.Padding(4);
            this.cbRunForever.Name = "cbRunForever";
            this.cbRunForever.Size = new System.Drawing.Size(100, 20);
            this.cbRunForever.TabIndex = 29;
            this.cbRunForever.Text = "Run Forever";
            this.cbRunForever.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(49, 230);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 16);
            this.label19.TabIndex = 28;
            this.label19.Text = "# of transactions to add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "(Enter 0 for true randomness)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Random number seed";
            // 
            // cbUseCoupons
            // 
            this.cbUseCoupons.AutoSize = true;
            this.cbUseCoupons.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbUseCoupons.Location = new System.Drawing.Point(64, 159);
            this.cbUseCoupons.Margin = new System.Windows.Forms.Padding(4);
            this.cbUseCoupons.Name = "cbUseCoupons";
            this.cbUseCoupons.Size = new System.Drawing.Size(209, 20);
            this.cbUseCoupons.TabIndex = 11;
            this.cbUseCoupons.Text = "Use coupons during simulation";
            this.cbUseCoupons.UseVisualStyleBackColor = true;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(56, 85);
            this.lblDatabase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(67, 16);
            this.lblDatabase.TabIndex = 10;
            this.lblDatabase.Text = "Database";
            // 
            // lblMilliseconds
            // 
            this.lblMilliseconds.AutoSize = true;
            this.lblMilliseconds.Location = new System.Drawing.Point(367, 130);
            this.lblMilliseconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMilliseconds.Name = "lblMilliseconds";
            this.lblMilliseconds.Size = new System.Drawing.Size(90, 16);
            this.lblMilliseconds.TabIndex = 8;
            this.lblMilliseconds.Text = "(Milliseconds)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(91, 129);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "Transaction delay";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(371, 53);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Password";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 53);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Login";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(56, 21);
            this.lblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(47, 16);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.lblElapsedMinutesToRun);
            this.panel2.Controls.Add(this.cbIgnoreElapsedTime);
            this.panel2.Controls.Add(this.txtElapsedTimeToRun);
            this.panel2.Controls.Add(this.txtNumOfTransactionsToAdd);
            this.panel2.Location = new System.Drawing.Point(40, 187);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 74);
            this.panel2.TabIndex = 59;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(267, 14);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(22, 16);
            this.label26.TabIndex = 61;
            this.label26.Text = "or ";
            // 
            // lblElapsedMinutesToRun
            // 
            this.lblElapsedMinutesToRun.AutoSize = true;
            this.lblElapsedMinutesToRun.Location = new System.Drawing.Point(9, 14);
            this.lblElapsedMinutesToRun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElapsedMinutesToRun.Name = "lblElapsedMinutesToRun";
            this.lblElapsedMinutesToRun.Size = new System.Drawing.Size(139, 16);
            this.lblElapsedMinutesToRun.TabIndex = 58;
            this.lblElapsedMinutesToRun.Text = "Hours:Minutes To Run";
            // 
            // cbIgnoreElapsedTime
            // 
            this.cbIgnoreElapsedTime.AutoSize = true;
            this.cbIgnoreElapsedTime.Checked = true;
            this.cbIgnoreElapsedTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreElapsedTime.Location = new System.Drawing.Point(303, 12);
            this.cbIgnoreElapsedTime.Margin = new System.Windows.Forms.Padding(4);
            this.cbIgnoreElapsedTime.Name = "cbIgnoreElapsedTime";
            this.cbIgnoreElapsedTime.Size = new System.Drawing.Size(100, 20);
            this.cbIgnoreElapsedTime.TabIndex = 60;
            this.cbIgnoreElapsedTime.Text = "Run Forever";
            this.cbIgnoreElapsedTime.UseVisualStyleBackColor = true;
            // 
            // txtElapsedTimeToRun
            // 
            this.txtElapsedTimeToRun.Location = new System.Drawing.Point(180, 10);
            this.txtElapsedTimeToRun.Margin = new System.Windows.Forms.Padding(4);
            this.txtElapsedTimeToRun.Name = "txtElapsedTimeToRun";
            this.txtElapsedTimeToRun.Size = new System.Drawing.Size(73, 22);
            this.txtElapsedTimeToRun.TabIndex = 57;
            this.txtElapsedTimeToRun.Text = "0:1";
            // 
            // txtNumOfTransactionsToAdd
            // 
            this.txtNumOfTransactionsToAdd.Location = new System.Drawing.Point(180, 37);
            this.txtNumOfTransactionsToAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumOfTransactionsToAdd.Name = "txtNumOfTransactionsToAdd";
            this.txtNumOfTransactionsToAdd.Size = new System.Drawing.Size(73, 22);
            this.txtNumOfTransactionsToAdd.TabIndex = 27;
            this.txtNumOfTransactionsToAdd.Text = "10";
            // 
            // tpIngredients
            // 
            this.tpIngredients.Controls.Add(this.btnProcessIngredients);
            this.tpIngredients.Controls.Add(this.pnlIngredients);
            this.tpIngredients.Location = new System.Drawing.Point(4, 25);
            this.tpIngredients.Margin = new System.Windows.Forms.Padding(4);
            this.tpIngredients.Name = "tpIngredients";
            this.tpIngredients.Padding = new System.Windows.Forms.Padding(4);
            this.tpIngredients.Size = new System.Drawing.Size(1183, 639);
            this.tpIngredients.TabIndex = 6;
            this.tpIngredients.Text = "Ingredients";
            this.tpIngredients.UseVisualStyleBackColor = true;
            // 
            // btnProcessIngredients
            // 
            this.btnProcessIngredients.Location = new System.Drawing.Point(1019, 486);
            this.btnProcessIngredients.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcessIngredients.Name = "btnProcessIngredients";
            this.btnProcessIngredients.Size = new System.Drawing.Size(153, 28);
            this.btnProcessIngredients.TabIndex = 34;
            this.btnProcessIngredients.Text = "Process Ingredients";
            this.btnProcessIngredients.UseVisualStyleBackColor = true;
            // 
            // pnlIngredients
            // 
            this.pnlIngredients.BackColor = System.Drawing.Color.LightGray;
            this.pnlIngredients.Controls.Add(this.lblIngredients);
            this.pnlIngredients.Controls.Add(this.txtIngredients);
            this.pnlIngredients.Location = new System.Drawing.Point(825, 194);
            this.pnlIngredients.Margin = new System.Windows.Forms.Padding(4);
            this.pnlIngredients.Name = "pnlIngredients";
            this.pnlIngredients.Size = new System.Drawing.Size(347, 289);
            this.pnlIngredients.TabIndex = 35;
            this.pnlIngredients.Visible = false;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(17, 23);
            this.lblIngredients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(153, 16);
            this.lblIngredients.TabIndex = 1;
            this.lblIngredients.Text = "Processing Ingredients...";
            // 
            // txtIngredients
            // 
            this.txtIngredients.Location = new System.Drawing.Point(21, 43);
            this.txtIngredients.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngredients.Multiline = true;
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIngredients.Size = new System.Drawing.Size(312, 240);
            this.txtIngredients.TabIndex = 0;
            // 
            // tpProducts
            // 
            this.tpProducts.Controls.Add(this.label22);
            this.tpProducts.Controls.Add(this.btnReinitializeProductPriceHistory);
            this.tpProducts.Controls.Add(this.txtProductPriceHist);
            this.tpProducts.Controls.Add(this.txtProductInfo);
            this.tpProducts.Controls.Add(this.txtProduct);
            this.tpProducts.Controls.Add(this.btnCalcNewProductPrice);
            this.tpProducts.Controls.Add(this.btnLookUpProduct);
            this.tpProducts.Location = new System.Drawing.Point(4, 25);
            this.tpProducts.Margin = new System.Windows.Forms.Padding(4);
            this.tpProducts.Name = "tpProducts";
            this.tpProducts.Padding = new System.Windows.Forms.Padding(4);
            this.tpProducts.Size = new System.Drawing.Size(1183, 639);
            this.tpProducts.TabIndex = 3;
            this.tpProducts.Text = "Products";
            this.tpProducts.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(309, 12);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(394, 16);
            this.label22.TabIndex = 7;
            this.label22.Text = "Search for a product ID, name, description, manufacturer, or brand";
            // 
            // btnReinitializeProductPriceHistory
            // 
            this.btnReinitializeProductPriceHistory.Location = new System.Drawing.Point(465, 489);
            this.btnReinitializeProductPriceHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnReinitializeProductPriceHistory.Name = "btnReinitializeProductPriceHistory";
            this.btnReinitializeProductPriceHistory.Size = new System.Drawing.Size(257, 28);
            this.btnReinitializeProductPriceHistory.TabIndex = 5;
            this.btnReinitializeProductPriceHistory.Text = "Reinitialize Product Price History";
            this.btnReinitializeProductPriceHistory.UseVisualStyleBackColor = true;
            this.btnReinitializeProductPriceHistory.Click += new System.EventHandler(this.btnReinitializeProductPriceHistory_Click);
            // 
            // txtProductPriceHist
            // 
            this.txtProductPriceHist.Location = new System.Drawing.Point(748, 345);
            this.txtProductPriceHist.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductPriceHist.Multiline = true;
            this.txtProductPriceHist.Name = "txtProductPriceHist";
            this.txtProductPriceHist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProductPriceHist.Size = new System.Drawing.Size(421, 143);
            this.txtProductPriceHist.TabIndex = 4;
            // 
            // txtProductInfo
            // 
            this.txtProductInfo.Location = new System.Drawing.Point(21, 42);
            this.txtProductInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductInfo.Multiline = true;
            this.txtProductInfo.Name = "txtProductInfo";
            this.txtProductInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProductInfo.Size = new System.Drawing.Size(1148, 294);
            this.txtProductInfo.TabIndex = 3;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(21, 7);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(171, 22);
            this.txtProduct.TabIndex = 1;
            // 
            // btnCalcNewProductPrice
            // 
            this.btnCalcNewProductPrice.Location = new System.Drawing.Point(915, 489);
            this.btnCalcNewProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcNewProductPrice.Name = "btnCalcNewProductPrice";
            this.btnCalcNewProductPrice.Size = new System.Drawing.Size(257, 28);
            this.btnCalcNewProductPrice.TabIndex = 6;
            this.btnCalcNewProductPrice.Text = "Recompute New Product Prices";
            this.btnCalcNewProductPrice.UseVisualStyleBackColor = true;
            this.btnCalcNewProductPrice.Click += new System.EventHandler(this.btnCalcNewProductPrice_Click);
            // 
            // btnLookUpProduct
            // 
            this.btnLookUpProduct.Location = new System.Drawing.Point(201, 6);
            this.btnLookUpProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnLookUpProduct.Name = "btnLookUpProduct";
            this.btnLookUpProduct.Size = new System.Drawing.Size(100, 28);
            this.btnLookUpProduct.TabIndex = 2;
            this.btnLookUpProduct.Text = "Look Up";
            this.btnLookUpProduct.UseVisualStyleBackColor = true;
            this.btnLookUpProduct.Click += new System.EventHandler(this.btnLookUpProduct_Click);
            // 
            // tpStores
            // 
            this.tpStores.Controls.Add(this.panel1);
            this.tpStores.Controls.Add(this.txtStoreStatus);
            this.tpStores.Controls.Add(this.pnlAddStore);
            this.tpStores.Location = new System.Drawing.Point(4, 25);
            this.tpStores.Margin = new System.Windows.Forms.Padding(4);
            this.tpStores.Name = "tpStores";
            this.tpStores.Padding = new System.Windows.Forms.Padding(4);
            this.tpStores.Size = new System.Drawing.Size(1183, 639);
            this.tpStores.TabIndex = 2;
            this.tpStores.Text = "Stores";
            this.tpStores.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnResetStoreStatusHistory);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.cbNewStoreStatusID);
            this.panel1.Location = new System.Drawing.Point(17, 463);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 39);
            this.panel1.TabIndex = 22;
            // 
            // btnResetStoreStatusHistory
            // 
            this.btnResetStoreStatusHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnResetStoreStatusHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetStoreStatusHistory.ForeColor = System.Drawing.Color.Red;
            this.btnResetStoreStatusHistory.Location = new System.Drawing.Point(537, 5);
            this.btnResetStoreStatusHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetStoreStatusHistory.Name = "btnResetStoreStatusHistory";
            this.btnResetStoreStatusHistory.Size = new System.Drawing.Size(100, 28);
            this.btnResetStoreStatusHistory.TabIndex = 21;
            this.btnResetStoreStatusHistory.Text = "Go";
            this.btnResetStoreStatusHistory.UseVisualStyleBackColor = false;
            this.btnResetStoreStatusHistory.Click += new System.EventHandler(this.btnResetStoreStatusHistory_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(33, 11);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(280, 16);
            this.label21.TabIndex = 20;
            this.label21.Text = "CLEAR Store History and RESET all stores to ";
            // 
            // cbNewStoreStatusID
            // 
            this.cbNewStoreStatusID.DataSource = this.vStoreStatusTableBindingSource;
            this.cbNewStoreStatusID.DisplayMember = "StoreStatus";
            this.cbNewStoreStatusID.FormattingEnabled = true;
            this.cbNewStoreStatusID.Location = new System.Drawing.Point(340, 7);
            this.cbNewStoreStatusID.Margin = new System.Windows.Forms.Padding(4);
            this.cbNewStoreStatusID.Name = "cbNewStoreStatusID";
            this.cbNewStoreStatusID.Size = new System.Drawing.Size(188, 24);
            this.cbNewStoreStatusID.TabIndex = 19;
            this.cbNewStoreStatusID.ValueMember = "StoreStatusID";
            // 
            // txtStoreStatus
            // 
            this.txtStoreStatus.Location = new System.Drawing.Point(8, 279);
            this.txtStoreStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStoreStatus.Multiline = true;
            this.txtStoreStatus.Name = "txtStoreStatus";
            this.txtStoreStatus.ReadOnly = true;
            this.txtStoreStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStoreStatus.Size = new System.Drawing.Size(1163, 180);
            this.txtStoreStatus.TabIndex = 1;
            // 
            // pnlAddStore
            // 
            this.pnlAddStore.BackColor = System.Drawing.Color.Silver;
            this.pnlAddStore.Controls.Add(this.label13);
            this.pnlAddStore.Controls.Add(this.cbStoreStatusID);
            this.pnlAddStore.Controls.Add(this.label12);
            this.pnlAddStore.Controls.Add(this.cbManagerID);
            this.pnlAddStore.Controls.Add(this.txtZip);
            this.pnlAddStore.Controls.Add(this.label11);
            this.pnlAddStore.Controls.Add(this.txtCity);
            this.pnlAddStore.Controls.Add(this.label10);
            this.pnlAddStore.Controls.Add(this.txtState);
            this.pnlAddStore.Controls.Add(this.label9);
            this.pnlAddStore.Controls.Add(this.txtAddress2);
            this.pnlAddStore.Controls.Add(this.txtAddress1);
            this.pnlAddStore.Controls.Add(this.label8);
            this.pnlAddStore.Controls.Add(this.label7);
            this.pnlAddStore.Controls.Add(this.txtStore);
            this.pnlAddStore.Controls.Add(this.label6);
            this.pnlAddStore.Controls.Add(this.label4);
            this.pnlAddStore.Controls.Add(this.txtStoreNumber);
            this.pnlAddStore.Controls.Add(this.btnAddStore);
            this.pnlAddStore.Location = new System.Drawing.Point(8, 7);
            this.pnlAddStore.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddStore.Name = "pnlAddStore";
            this.pnlAddStore.Size = new System.Drawing.Size(1164, 265);
            this.pnlAddStore.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(251, 38);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Store Status";
            // 
            // cbStoreStatusID
            // 
            this.cbStoreStatusID.DataSource = this.vStoreStatusTableBindingSource;
            this.cbStoreStatusID.DisplayMember = "StoreStatus";
            this.cbStoreStatusID.FormattingEnabled = true;
            this.cbStoreStatusID.Location = new System.Drawing.Point(345, 33);
            this.cbStoreStatusID.Margin = new System.Windows.Forms.Padding(4);
            this.cbStoreStatusID.Name = "cbStoreStatusID";
            this.cbStoreStatusID.Size = new System.Drawing.Size(167, 24);
            this.cbStoreStatusID.TabIndex = 9;
            this.cbStoreStatusID.ValueMember = "StoreStatusID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Manager";
            // 
            // cbManagerID
            // 
            this.cbManagerID.DataSource = this.fEmployeesWhoCanBeAStoreManagerBindingSource;
            this.cbManagerID.DisplayMember = "EmplName";
            this.cbManagerID.FormattingEnabled = true;
            this.cbManagerID.Location = new System.Drawing.Point(345, 2);
            this.cbManagerID.Margin = new System.Windows.Forms.Padding(4);
            this.cbManagerID.Name = "cbManagerID";
            this.cbManagerID.Size = new System.Drawing.Size(549, 24);
            this.cbManagerID.TabIndex = 8;
            this.cbManagerID.ValueMember = "EmplID";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(109, 203);
            this.txtZip.Margin = new System.Windows.Forms.Padding(4);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(132, 22);
            this.txtZip.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 203);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Zip";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(109, 139);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(132, 22);
            this.txtCity.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "City";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(109, 171);
            this.txtState.Margin = new System.Windows.Forms.Padding(4);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(132, 22);
            this.txtState.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 171);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "State";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(109, 105);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(132, 22);
            this.txtAddress2.TabIndex = 4;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(109, 73);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(132, 22);
            this.txtAddress1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Address 1";
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(109, 34);
            this.txtStore.Margin = new System.Windows.Forms.Padding(4);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(132, 22);
            this.txtStore.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Store Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Store Number";
            // 
            // txtStoreNumber
            // 
            this.txtStoreNumber.Location = new System.Drawing.Point(109, 4);
            this.txtStoreNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtStoreNumber.Name = "txtStoreNumber";
            this.txtStoreNumber.Size = new System.Drawing.Size(132, 22);
            this.txtStoreNumber.TabIndex = 1;
            // 
            // btnAddStore
            // 
            this.btnAddStore.Location = new System.Drawing.Point(1056, 233);
            this.btnAddStore.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(104, 28);
            this.btnAddStore.TabIndex = 10;
            this.btnAddStore.Text = "Add Store";
            this.btnAddStore.UseVisualStyleBackColor = true;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // tpCoupon
            // 
            this.tpCoupon.Controls.Add(this.lblCouponStatus);
            this.tpCoupon.Controls.Add(this.label18);
            this.tpCoupon.Controls.Add(this.txtCouponsToAdd);
            this.tpCoupon.Controls.Add(this.txtCouponStatus);
            this.tpCoupon.Controls.Add(this.txtCouponGetInfoResult);
            this.tpCoupon.Controls.Add(this.txtCouponID);
            this.tpCoupon.Controls.Add(this.txtCoupon);
            this.tpCoupon.Controls.Add(this.btnAddCoupons);
            this.tpCoupon.Controls.Add(this.label5);
            this.tpCoupon.Controls.Add(this.btnGetCouponInfo);
            this.tpCoupon.Controls.Add(this.lblCouponValidationResult);
            this.tpCoupon.Controls.Add(this.label3);
            this.tpCoupon.Controls.Add(this.btnCheck);
            this.tpCoupon.Location = new System.Drawing.Point(4, 25);
            this.tpCoupon.Margin = new System.Windows.Forms.Padding(4);
            this.tpCoupon.Name = "tpCoupon";
            this.tpCoupon.Padding = new System.Windows.Forms.Padding(4);
            this.tpCoupon.Size = new System.Drawing.Size(1183, 639);
            this.tpCoupon.TabIndex = 1;
            this.tpCoupon.Text = "Coupon";
            this.tpCoupon.UseVisualStyleBackColor = true;
            // 
            // lblCouponStatus
            // 
            this.lblCouponStatus.AutoSize = true;
            this.lblCouponStatus.Location = new System.Drawing.Point(12, 494);
            this.lblCouponStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCouponStatus.Name = "lblCouponStatus";
            this.lblCouponStatus.Size = new System.Drawing.Size(13, 16);
            this.lblCouponStatus.TabIndex = 13;
            this.lblCouponStatus.Text = "  ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(827, 491);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 16);
            this.label18.TabIndex = 12;
            this.label18.Text = "# of Coupons to Add";
            // 
            // txtCouponsToAdd
            // 
            this.txtCouponsToAdd.Location = new System.Drawing.Point(975, 487);
            this.txtCouponsToAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCouponsToAdd.Name = "txtCouponsToAdd";
            this.txtCouponsToAdd.Size = new System.Drawing.Size(73, 22);
            this.txtCouponsToAdd.TabIndex = 5;
            // 
            // txtCouponStatus
            // 
            this.txtCouponStatus.Location = new System.Drawing.Point(8, 169);
            this.txtCouponStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtCouponStatus.Multiline = true;
            this.txtCouponStatus.Name = "txtCouponStatus";
            this.txtCouponStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCouponStatus.Size = new System.Drawing.Size(1163, 313);
            this.txtCouponStatus.TabIndex = 9;
            // 
            // txtCouponGetInfoResult
            // 
            this.txtCouponGetInfoResult.Location = new System.Drawing.Point(501, 27);
            this.txtCouponGetInfoResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtCouponGetInfoResult.Multiline = true;
            this.txtCouponGetInfoResult.Name = "txtCouponGetInfoResult";
            this.txtCouponGetInfoResult.ReadOnly = true;
            this.txtCouponGetInfoResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCouponGetInfoResult.Size = new System.Drawing.Size(669, 133);
            this.txtCouponGetInfoResult.TabIndex = 4;
            this.txtCouponGetInfoResult.Visible = false;
            // 
            // txtCouponID
            // 
            this.txtCouponID.Location = new System.Drawing.Point(179, 60);
            this.txtCouponID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCouponID.Name = "txtCouponID";
            this.txtCouponID.Size = new System.Drawing.Size(132, 22);
            this.txtCouponID.TabIndex = 1;
            this.txtCouponID.Visible = false;
            // 
            // txtCoupon
            // 
            this.txtCoupon.Location = new System.Drawing.Point(179, 25);
            this.txtCoupon.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(132, 22);
            this.txtCoupon.TabIndex = 0;
            this.txtCoupon.Visible = false;
            // 
            // btnAddCoupons
            // 
            this.btnAddCoupons.Location = new System.Drawing.Point(1057, 487);
            this.btnAddCoupons.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCoupons.Name = "btnAddCoupons";
            this.btnAddCoupons.Size = new System.Drawing.Size(115, 28);
            this.btnAddCoupons.TabIndex = 6;
            this.btnAddCoupons.Text = "Add Coupons";
            this.btnAddCoupons.UseVisualStyleBackColor = true;
            this.btnAddCoupons.Click += new System.EventHandler(this.btnAddCoupons_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Coupon ID";
            this.label5.Visible = false;
            // 
            // btnGetCouponInfo
            // 
            this.btnGetCouponInfo.Location = new System.Drawing.Point(337, 60);
            this.btnGetCouponInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetCouponInfo.Name = "btnGetCouponInfo";
            this.btnGetCouponInfo.Size = new System.Drawing.Size(100, 28);
            this.btnGetCouponInfo.TabIndex = 3;
            this.btnGetCouponInfo.Text = "Check";
            this.btnGetCouponInfo.UseVisualStyleBackColor = true;
            this.btnGetCouponInfo.Visible = false;
            this.btnGetCouponInfo.Click += new System.EventHandler(this.btnGetCouponInfo_Click);
            // 
            // lblCouponValidationResult
            // 
            this.lblCouponValidationResult.AutoSize = true;
            this.lblCouponValidationResult.Location = new System.Drawing.Point(445, 28);
            this.lblCouponValidationResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCouponValidationResult.Name = "lblCouponValidationResult";
            this.lblCouponValidationResult.Size = new System.Drawing.Size(38, 16);
            this.lblCouponValidationResult.TabIndex = 3;
            this.lblCouponValidationResult.Text = "Valid";
            this.lblCouponValidationResult.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coupon Code";
            this.label3.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(337, 25);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 28);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tpSimulate
            // 
            this.tpSimulate.Controls.Add(this.lblStartTimeLabel);
            this.tpSimulate.Controls.Add(this.lblStartTime);
            this.tpSimulate.Controls.Add(this.lblCurrentTimeLabel);
            this.tpSimulate.Controls.Add(this.lblElapsedTimeLabel);
            this.tpSimulate.Controls.Add(this.lblCurrentTime);
            this.tpSimulate.Controls.Add(this.pbGroceries);
            this.tpSimulate.Controls.Add(this.lblElapsedTime);
            this.tpSimulate.Controls.Add(this.lblStatus);
            this.tpSimulate.Controls.Add(this.txtResults);
            this.tpSimulate.Controls.Add(this.btnStartTransactionSimulator);
            this.tpSimulate.Location = new System.Drawing.Point(4, 25);
            this.tpSimulate.Margin = new System.Windows.Forms.Padding(4);
            this.tpSimulate.Name = "tpSimulate";
            this.tpSimulate.Padding = new System.Windows.Forms.Padding(4);
            this.tpSimulate.Size = new System.Drawing.Size(1183, 639);
            this.tpSimulate.TabIndex = 0;
            this.tpSimulate.Text = "Simulation";
            this.tpSimulate.UseVisualStyleBackColor = true;
            // 
            // lblStartTimeLabel
            // 
            this.lblStartTimeLabel.AutoSize = true;
            this.lblStartTimeLabel.Location = new System.Drawing.Point(704, 490);
            this.lblStartTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTimeLabel.Name = "lblStartTimeLabel";
            this.lblStartTimeLabel.Size = new System.Drawing.Size(68, 16);
            this.lblStartTimeLabel.TabIndex = 22;
            this.lblStartTimeLabel.Text = "Start Time";
            this.lblStartTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStartTimeLabel.Visible = false;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStartTime.Location = new System.Drawing.Point(804, 490);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(2, 18);
            this.lblStartTime.TabIndex = 21;
            this.lblStartTime.Visible = false;
            // 
            // lblCurrentTimeLabel
            // 
            this.lblCurrentTimeLabel.AutoSize = true;
            this.lblCurrentTimeLabel.Location = new System.Drawing.Point(19, 490);
            this.lblCurrentTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentTimeLabel.Name = "lblCurrentTimeLabel";
            this.lblCurrentTimeLabel.Size = new System.Drawing.Size(83, 16);
            this.lblCurrentTimeLabel.TabIndex = 20;
            this.lblCurrentTimeLabel.Text = "Current Time";
            this.lblCurrentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentTimeLabel.Visible = false;
            // 
            // lblElapsedTimeLabel
            // 
            this.lblElapsedTimeLabel.AutoSize = true;
            this.lblElapsedTimeLabel.Location = new System.Drawing.Point(704, 458);
            this.lblElapsedTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElapsedTimeLabel.Name = "lblElapsedTimeLabel";
            this.lblElapsedTimeLabel.Size = new System.Drawing.Size(92, 16);
            this.lblElapsedTimeLabel.TabIndex = 19;
            this.lblElapsedTimeLabel.Text = "Elapsed Time";
            this.lblElapsedTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblElapsedTimeLabel.Visible = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentTime.Location = new System.Drawing.Point(115, 490);
            this.lblCurrentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(2, 18);
            this.lblCurrentTime.TabIndex = 18;
            this.lblCurrentTime.Visible = false;
            // 
            // pbGroceries
            // 
            this.pbGroceries.Image = global::GroceryStoreSimulator.Properties.Resources.Groceries;
            this.pbGroceries.InitialImage = global::GroceryStoreSimulator.Properties.Resources.Groceries;
            this.pbGroceries.Location = new System.Drawing.Point(957, 4);
            this.pbGroceries.Margin = new System.Windows.Forms.Padding(4);
            this.pbGroceries.Name = "pbGroceries";
            this.pbGroceries.Size = new System.Drawing.Size(184, 111);
            this.pbGroceries.TabIndex = 17;
            this.pbGroceries.TabStop = false;
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblElapsedTime.Location = new System.Drawing.Point(804, 458);
            this.lblElapsedTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(2, 18);
            this.lblElapsedTime.TabIndex = 15;
            this.lblElapsedTime.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(19, 458);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 14;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(23, 39);
            this.txtResults.Margin = new System.Windows.Forms.Padding(4);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(1148, 406);
            this.txtResults.TabIndex = 12;
            // 
            // btnStartTransactionSimulator
            // 
            this.btnStartTransactionSimulator.Location = new System.Drawing.Point(983, 454);
            this.btnStartTransactionSimulator.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartTransactionSimulator.Name = "btnStartTransactionSimulator";
            this.btnStartTransactionSimulator.Size = new System.Drawing.Size(189, 28);
            this.btnStartTransactionSimulator.TabIndex = 9;
            this.btnStartTransactionSimulator.Text = "Start Transaction Simulator";
            this.btnStartTransactionSimulator.UseVisualStyleBackColor = true;
            this.btnStartTransactionSimulator.Click += new System.EventHandler(this.btnStartTransactionSimulator_Click);
            // 
            // tcSimulate
            // 
            this.tcSimulate.Controls.Add(this.tpSimulate);
            this.tcSimulate.Controls.Add(this.tpCoupon);
            this.tcSimulate.Controls.Add(this.tpStores);
            this.tcSimulate.Controls.Add(this.tpProducts);
            this.tcSimulate.Controls.Add(this.tpIngredients);
            this.tcSimulate.Controls.Add(this.tpConfig);
            this.tcSimulate.Controls.Add(this.tpTest);
            this.tcSimulate.Controls.Add(this.tpUPCLookup01);
            this.tcSimulate.Controls.Add(this.tpProductPrioritization);
            this.tcSimulate.Location = new System.Drawing.Point(16, 33);
            this.tcSimulate.Margin = new System.Windows.Forms.Padding(4);
            this.tcSimulate.Name = "tcSimulate";
            this.tcSimulate.SelectedIndex = 0;
            this.tcSimulate.Size = new System.Drawing.Size(1191, 668);
            this.tcSimulate.TabIndex = 9;
            this.tcSimulate.Enter += new System.EventHandler(this.tcSimulate_Enter);
            // 
            // tpTest
            // 
            this.tpTest.Controls.Add(this.txtProductInfoWebServiceResults);
            this.tpTest.Controls.Add(this.btnTestProductInfoWebService);
            this.tpTest.Controls.Add(this.lblProductID);
            this.tpTest.Controls.Add(this.txtProductID);
            this.tpTest.Location = new System.Drawing.Point(4, 25);
            this.tpTest.Margin = new System.Windows.Forms.Padding(4);
            this.tpTest.Name = "tpTest";
            this.tpTest.Padding = new System.Windows.Forms.Padding(4);
            this.tpTest.Size = new System.Drawing.Size(1183, 639);
            this.tpTest.TabIndex = 7;
            this.tpTest.Text = "Test";
            this.tpTest.UseVisualStyleBackColor = true;
            // 
            // txtProductInfoWebServiceResults
            // 
            this.txtProductInfoWebServiceResults.Location = new System.Drawing.Point(499, 33);
            this.txtProductInfoWebServiceResults.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductInfoWebServiceResults.Multiline = true;
            this.txtProductInfoWebServiceResults.Name = "txtProductInfoWebServiceResults";
            this.txtProductInfoWebServiceResults.Size = new System.Drawing.Size(383, 93);
            this.txtProductInfoWebServiceResults.TabIndex = 3;
            // 
            // btnTestProductInfoWebService
            // 
            this.btnTestProductInfoWebService.Location = new System.Drawing.Point(279, 30);
            this.btnTestProductInfoWebService.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestProductInfoWebService.Name = "btnTestProductInfoWebService";
            this.btnTestProductInfoWebService.Size = new System.Drawing.Size(204, 28);
            this.btnTestProductInfoWebService.TabIndex = 2;
            this.btnTestProductInfoWebService.Text = "Product Info Web Service";
            this.btnTestProductInfoWebService.UseVisualStyleBackColor = true;
            this.btnTestProductInfoWebService.Click += new System.EventHandler(this.btnTestProductInfoWebService_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(35, 34);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(66, 16);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "ProductID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(117, 31);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(132, 22);
            this.txtProductID.TabIndex = 0;
            // 
            // tpUPCLookup01
            // 
            this.tpUPCLookup01.Controls.Add(this.label35);
            this.tpUPCLookup01.Controls.Add(this.txtProductIngredients);
            this.tpUPCLookup01.Controls.Add(this.label34);
            this.tpUPCLookup01.Controls.Add(this.txtManufacturer);
            this.tpUPCLookup01.Controls.Add(this.label33);
            this.tpUPCLookup01.Controls.Add(this.lblProviderNotes);
            this.tpUPCLookup01.Controls.Add(this.txtCompleteURL);
            this.tpUPCLookup01.Controls.Add(this.cbURL);
            this.tpUPCLookup01.Controls.Add(this.label32);
            this.tpUPCLookup01.Controls.Add(this.txtModel);
            this.tpUPCLookup01.Controls.Add(this.label31);
            this.tpUPCLookup01.Controls.Add(this.txtBrand);
            this.tpUPCLookup01.Controls.Add(this.label30);
            this.tpUPCLookup01.Controls.Add(this.label29);
            this.tpUPCLookup01.Controls.Add(this.label28);
            this.tpUPCLookup01.Controls.Add(this.txtCategory);
            this.tpUPCLookup01.Controls.Add(this.txtDescription);
            this.tpUPCLookup01.Controls.Add(this.txtTitle);
            this.tpUPCLookup01.Controls.Add(this.txtUPCLookupOnlineResults);
            this.tpUPCLookup01.Controls.Add(this.btnUPCLookupOnlineSubmit);
            this.tpUPCLookup01.Controls.Add(this.label27);
            this.tpUPCLookup01.Controls.Add(this.label14);
            this.tpUPCLookup01.Controls.Add(this.txtUPC);
            this.tpUPCLookup01.Location = new System.Drawing.Point(4, 25);
            this.tpUPCLookup01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUPCLookup01.Name = "tpUPCLookup01";
            this.tpUPCLookup01.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUPCLookup01.Size = new System.Drawing.Size(1183, 639);
            this.tpUPCLookup01.TabIndex = 8;
            this.tpUPCLookup01.Text = "UPC Lookup Providers";
            this.tpUPCLookup01.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(5, 554);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(73, 16);
            this.label35.TabIndex = 24;
            this.label35.Text = "Ingredients";
            // 
            // txtProductIngredients
            // 
            this.txtProductIngredients.Location = new System.Drawing.Point(117, 554);
            this.txtProductIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductIngredients.Name = "txtProductIngredients";
            this.txtProductIngredients.Size = new System.Drawing.Size(657, 22);
            this.txtProductIngredients.TabIndex = 22;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(5, 558);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(0, 16);
            this.label34.TabIndex = 23;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(117, 526);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(657, 22);
            this.txtManufacturer.TabIndex = 20;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 529);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 16);
            this.label33.TabIndex = 21;
            this.label33.Text = "Manufacturer";
            // 
            // lblProviderNotes
            // 
            this.lblProviderNotes.AutoSize = true;
            this.lblProviderNotes.Location = new System.Drawing.Point(511, 6);
            this.lblProviderNotes.Name = "lblProviderNotes";
            this.lblProviderNotes.Size = new System.Drawing.Size(97, 16);
            this.lblProviderNotes.TabIndex = 19;
            this.lblProviderNotes.Text = "Provider Notes";
            // 
            // txtCompleteURL
            // 
            this.txtCompleteURL.Location = new System.Drawing.Point(213, 78);
            this.txtCompleteURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompleteURL.Name = "txtCompleteURL";
            this.txtCompleteURL.ReadOnly = true;
            this.txtCompleteURL.Size = new System.Drawing.Size(860, 22);
            this.txtCompleteURL.TabIndex = 18;
            // 
            // cbURL
            // 
            this.cbURL.FormattingEnabled = true;
            this.cbURL.Location = new System.Drawing.Point(115, 2);
            this.cbURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbURL.Name = "cbURL";
            this.cbURL.Size = new System.Drawing.Size(391, 24);
            this.cbURL.TabIndex = 16;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(5, 500);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 16);
            this.label32.TabIndex = 15;
            this.label32.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(117, 497);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(657, 22);
            this.txtModel.TabIndex = 14;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(5, 473);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(43, 16);
            this.label31.TabIndex = 13;
            this.label31.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(117, 469);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(657, 22);
            this.txtBrand.TabIndex = 12;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(5, 444);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 16);
            this.label30.TabIndex = 11;
            this.label30.Text = "Category";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(5, 406);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 16);
            this.label29.TabIndex = 10;
            this.label29.Text = "Description";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 366);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 16);
            this.label28.TabIndex = 9;
            this.label28.Text = "Title";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(117, 441);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(657, 22);
            this.txtCategory.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(117, 402);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(657, 22);
            this.txtDescription.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(117, 366);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(657, 22);
            this.txtTitle.TabIndex = 6;
            // 
            // txtUPCLookupOnlineResults
            // 
            this.txtUPCLookupOnlineResults.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txtUPCLookupOnlineResults.Location = new System.Drawing.Point(117, 113);
            this.txtUPCLookupOnlineResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUPCLookupOnlineResults.Multiline = true;
            this.txtUPCLookupOnlineResults.Name = "txtUPCLookupOnlineResults";
            this.txtUPCLookupOnlineResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUPCLookupOnlineResults.Size = new System.Drawing.Size(956, 246);
            this.txtUPCLookupOnlineResults.TabIndex = 5;
            // 
            // btnUPCLookupOnlineSubmit
            // 
            this.btnUPCLookupOnlineSubmit.Location = new System.Drawing.Point(115, 78);
            this.btnUPCLookupOnlineSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUPCLookupOnlineSubmit.Name = "btnUPCLookupOnlineSubmit";
            this.btnUPCLookupOnlineSubmit.Size = new System.Drawing.Size(92, 30);
            this.btnUPCLookupOnlineSubmit.TabIndex = 4;
            this.btnUPCLookupOnlineSubmit.Text = "Submit";
            this.btnUPCLookupOnlineSubmit.UseVisualStyleBackColor = true;
            this.btnUPCLookupOnlineSubmit.Click += new System.EventHandler(this.btnUPCLookupOnlineSubmit_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 16);
            this.label27.TabIndex = 3;
            this.label27.Text = "UPC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "URL / Provider";
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point(117, 49);
            this.txtUPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(245, 22);
            this.txtUPC.TabIndex = 1;
            this.txtUPC.Text = "30100100393";
            // 
            // tpProductPrioritization
            // 
            this.tpProductPrioritization.Controls.Add(this.gbProductPrioritizationModes);
            this.tpProductPrioritization.Location = new System.Drawing.Point(4, 25);
            this.tpProductPrioritization.Name = "tpProductPrioritization";
            this.tpProductPrioritization.Size = new System.Drawing.Size(1183, 639);
            this.tpProductPrioritization.TabIndex = 9;
            this.tpProductPrioritization.Text = "Product Prioritization";
            this.tpProductPrioritization.UseVisualStyleBackColor = true;
            // 
            // gbProductPrioritizationModes
            // 
            this.gbProductPrioritizationModes.AutoSize = true;
            this.gbProductPrioritizationModes.Controls.Add(this.lblNotImplemented);
            this.gbProductPrioritizationModes.Controls.Add(this.rbPrioritizeProductsAtStartOfEachDay);
            this.gbProductPrioritizationModes.Controls.Add(this.rbPrioritizeProductsAtStartOfSimulationOnly);
            this.gbProductPrioritizationModes.Controls.Add(this.rbPrioritizeProductsEachDayOfMonth);
            this.gbProductPrioritizationModes.Controls.Add(this.rbPrioritizeProductsEachDayOfWeek);
            this.gbProductPrioritizationModes.Location = new System.Drawing.Point(12, 13);
            this.gbProductPrioritizationModes.Name = "gbProductPrioritizationModes";
            this.gbProductPrioritizationModes.Size = new System.Drawing.Size(328, 145);
            this.gbProductPrioritizationModes.TabIndex = 1;
            this.gbProductPrioritizationModes.TabStop = false;
            this.gbProductPrioritizationModes.Text = "Product Prioritization Modes";
            // 
            // lblNotImplemented
            // 
            this.lblNotImplemented.AutoSize = true;
            this.lblNotImplemented.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblNotImplemented.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotImplemented.Location = new System.Drawing.Point(187, 0);
            this.lblNotImplemented.Name = "lblNotImplemented";
            this.lblNotImplemented.Size = new System.Drawing.Size(135, 18);
            this.lblNotImplemented.TabIndex = 2;
            this.lblNotImplemented.Text = "Not implemented, yet";
            this.lblNotImplemented.Click += new System.EventHandler(this.label39_Click);
            // 
            // rbPrioritizeProductsAtStartOfEachDay
            // 
            this.rbPrioritizeProductsAtStartOfEachDay.AutoSize = true;
            this.rbPrioritizeProductsAtStartOfEachDay.Location = new System.Drawing.Point(6, 52);
            this.rbPrioritizeProductsAtStartOfEachDay.Name = "rbPrioritizeProductsAtStartOfEachDay";
            this.rbPrioritizeProductsAtStartOfEachDay.Size = new System.Drawing.Size(138, 20);
            this.rbPrioritizeProductsAtStartOfEachDay.TabIndex = 3;
            this.rbPrioritizeProductsAtStartOfEachDay.TabStop = true;
            this.rbPrioritizeProductsAtStartOfEachDay.Text = "At start of each day";
            this.rbPrioritizeProductsAtStartOfEachDay.UseVisualStyleBackColor = true;
            // 
            // rbPrioritizeProductsAtStartOfSimulationOnly
            // 
            this.rbPrioritizeProductsAtStartOfSimulationOnly.AutoSize = true;
            this.rbPrioritizeProductsAtStartOfSimulationOnly.Location = new System.Drawing.Point(6, 26);
            this.rbPrioritizeProductsAtStartOfSimulationOnly.Name = "rbPrioritizeProductsAtStartOfSimulationOnly";
            this.rbPrioritizeProductsAtStartOfSimulationOnly.Size = new System.Drawing.Size(170, 20);
            this.rbPrioritizeProductsAtStartOfSimulationOnly.TabIndex = 2;
            this.rbPrioritizeProductsAtStartOfSimulationOnly.TabStop = true;
            this.rbPrioritizeProductsAtStartOfSimulationOnly.Text = "At start of simulation only";
            this.rbPrioritizeProductsAtStartOfSimulationOnly.UseVisualStyleBackColor = true;
            // 
            // rbPrioritizeProductsEachDayOfMonth
            // 
            this.rbPrioritizeProductsEachDayOfMonth.AutoSize = true;
            this.rbPrioritizeProductsEachDayOfMonth.Location = new System.Drawing.Point(6, 104);
            this.rbPrioritizeProductsEachDayOfMonth.Name = "rbPrioritizeProductsEachDayOfMonth";
            this.rbPrioritizeProductsEachDayOfMonth.Size = new System.Drawing.Size(103, 20);
            this.rbPrioritizeProductsEachDayOfMonth.TabIndex = 1;
            this.rbPrioritizeProductsEachDayOfMonth.TabStop = true;
            this.rbPrioritizeProductsEachDayOfMonth.Text = "Day of month";
            this.rbPrioritizeProductsEachDayOfMonth.UseVisualStyleBackColor = true;
            // 
            // rbPrioritizeProductsEachDayOfWeek
            // 
            this.rbPrioritizeProductsEachDayOfWeek.AutoSize = true;
            this.rbPrioritizeProductsEachDayOfWeek.Location = new System.Drawing.Point(6, 77);
            this.rbPrioritizeProductsEachDayOfWeek.Name = "rbPrioritizeProductsEachDayOfWeek";
            this.rbPrioritizeProductsEachDayOfWeek.Size = new System.Drawing.Size(99, 20);
            this.rbPrioritizeProductsEachDayOfWeek.TabIndex = 0;
            this.rbPrioritizeProductsEachDayOfWeek.TabStop = true;
            this.rbPrioritizeProductsEachDayOfWeek.Text = "Day of week";
            this.rbPrioritizeProductsEachDayOfWeek.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1212, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.placeOrderToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1212, 708);
            this.Controls.Add(this.tcSimulate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "SimGrocery by Your Friends at Produce World";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.vStoreStatusTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEmployeesWhoCanBeAStoreManagerBindingSource)).EndInit();
            this.tpConfig.ResumeLayout(false);
            this.tpConfig.PerformLayout();
            this.pnlUseCurrentDateStampForTransaction.ResumeLayout(false);
            this.pnlUseCurrentDateStampForTransaction.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpIngredients.ResumeLayout(false);
            this.pnlIngredients.ResumeLayout(false);
            this.pnlIngredients.PerformLayout();
            this.tpProducts.ResumeLayout(false);
            this.tpProducts.PerformLayout();
            this.tpStores.ResumeLayout(false);
            this.tpStores.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAddStore.ResumeLayout(false);
            this.pnlAddStore.PerformLayout();
            this.tpCoupon.ResumeLayout(false);
            this.tpCoupon.PerformLayout();
            this.tpSimulate.ResumeLayout(false);
            this.tpSimulate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroceries)).EndInit();
            this.tcSimulate.ResumeLayout(false);
            this.tpTest.ResumeLayout(false);
            this.tpTest.PerformLayout();
            this.tpUPCLookup01.ResumeLayout(false);
            this.tpUPCLookup01.PerformLayout();
            this.tpProductPrioritization.ResumeLayout(false);
            this.tpProductPrioritization.PerformLayout();
            this.gbProductPrioritizationModes.ResumeLayout(false);
            this.gbProductPrioritizationModes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource fEmployeesWhoCanBeAStoreManagerBindingSource;
        private System.Windows.Forms.BindingSource vStoreStatusTableBindingSource;
        private System.Windows.Forms.TabPage tpConfig;
        private System.Windows.Forms.Button btnDeleteAllHistoryData;
        private System.Windows.Forms.CheckBox cbExecuteFailSafe;
        private System.Windows.Forms.ComboBox cbCouponAmountToAdd;
        private System.Windows.Forms.Label lblCouponAdd;
        private System.Windows.Forms.ComboBox cbCouponCheckInterval;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel pnlUseCurrentDateStampForTransaction;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox cbUseCurrentDateStampForTransaction;
        private System.Windows.Forms.TextBox txtThroughDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblProductCheckInterval;
        private System.Windows.Forms.Label lblEmplCheckInterval;
        private System.Windows.Forms.Label lblStoreCheckInterval;
        private System.Windows.Forms.ComboBox cbProductCheckInterval;
        private System.Windows.Forms.ComboBox cbEmplCheckInterval;
        private System.Windows.Forms.ComboBox cbStoreCheckInterval;
        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtTransactionDelay;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnTestDatabaseConnection;
        private System.Windows.Forms.Button btnInitRandomNumberGenerator;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox cbRunForever;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbUseCoupons;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblMilliseconds;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblElapsedMinutesToRun;
        private System.Windows.Forms.CheckBox cbIgnoreElapsedTime;
        private System.Windows.Forms.TextBox txtElapsedTimeToRun;
        private System.Windows.Forms.TextBox txtNumOfTransactionsToAdd;
        private System.Windows.Forms.TabPage tpIngredients;
        private System.Windows.Forms.Button btnProcessIngredients;
        private System.Windows.Forms.Panel pnlIngredients;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.TabPage tpProducts;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnReinitializeProductPriceHistory;
        private System.Windows.Forms.TextBox txtProductPriceHist;
        private System.Windows.Forms.TextBox txtProductInfo;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnCalcNewProductPrice;
        private System.Windows.Forms.Button btnLookUpProduct;
        private System.Windows.Forms.TabPage tpStores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetStoreStatusHistory;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbNewStoreStatusID;
        private System.Windows.Forms.TextBox txtStoreStatus;
        private System.Windows.Forms.Panel pnlAddStore;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbStoreStatusID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbManagerID;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStoreNumber;
        private System.Windows.Forms.Button btnAddStore;
        private System.Windows.Forms.TabPage tpCoupon;
        private System.Windows.Forms.Label lblCouponStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCouponsToAdd;
        private System.Windows.Forms.TextBox txtCouponStatus;
        private System.Windows.Forms.TextBox txtCouponGetInfoResult;
        private System.Windows.Forms.TextBox txtCouponID;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.Button btnAddCoupons;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetCouponInfo;
        private System.Windows.Forms.Label lblCouponValidationResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TabPage tpSimulate;
        private System.Windows.Forms.Label lblStartTimeLabel;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblCurrentTimeLabel;
        private System.Windows.Forms.Label lblElapsedTimeLabel;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.PictureBox pbGroceries;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnStartTransactionSimulator;
        private System.Windows.Forms.TabControl tcSimulate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tpTest;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductInfoWebServiceResults;
        private System.Windows.Forms.Button btnTestProductInfoWebService;
        private System.Windows.Forms.TabPage tpUPCLookup01;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUPC;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnUPCLookupOnlineSubmit;
        private System.Windows.Forms.TextBox txtUPCLookupOnlineResults;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.ComboBox cbURL;
        private System.Windows.Forms.TextBox txtCompleteURL;
        private System.Windows.Forms.Label lblProviderNotes;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtProductIngredients;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox cbPrioritizeProducts;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.CheckBox cbCheckForAllStoresClosed;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TabPage tpProductPrioritization;
        private System.Windows.Forms.GroupBox gbProductPrioritizationModes;
        private System.Windows.Forms.RadioButton rbPrioritizeProductsEachDayOfMonth;
        private System.Windows.Forms.RadioButton rbPrioritizeProductsEachDayOfWeek;
        private System.Windows.Forms.RadioButton rbPrioritizeProductsAtStartOfSimulationOnly;
        private System.Windows.Forms.RadioButton rbPrioritizeProductsAtStartOfEachDay;
        private System.Windows.Forms.Label lblNotImplemented;
    }
}

