namespace GroceryStoreSimulator {
    partial class frmPlaceAnOrder {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lbProductID = new System.Windows.Forms.ListBox();
            this.btnRemoveFromOrder = new System.Windows.Forms.Button();
            this.lbOrder_ProductID = new System.Windows.Forms.ListBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblStore = new System.Windows.Forms.Label();
            this.cbStoreID = new System.Windows.Forms.ComboBox();
            this.vStoresAcceptingOnlineOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesAcceptingOnlineOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesAcceptingOnlineOrders = new GroceryStoreSimulator.Datasets.StoresAcceptingOnlineOrders();
            this.label27 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.storesNotClosedForever = new GroceryStoreSimulator.Datasets.StoresNotClosedForever();
            this.vStoresNotClosedForeverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vStoresNotClosedForeverTableAdapter = new GroceryStoreSimulator.Datasets.StoresNotClosedForeverTableAdapters.vStoresNotClosedForeverTableAdapter();
            this.vStoresAcceptingOnlineOrdersTableAdapter = new GroceryStoreSimulator.Datasets.StoresAcceptingOnlineOrdersTableAdapters.vStoresAcceptingOnlineOrdersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoyaltyID = new System.Windows.Forms.ComboBox();
            this.vLoyaltyIDsThatCanPlaceOnlineOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vLoyaltyIDsThatCanOrderOnlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vLoyaltyIDsThatCanOrderOnline = new GroceryStoreSimulator.Datasets.vLoyaltyIDsThatCanOrderOnline();
            this.vLoyaltyIDsThatCanPlaceOnlineOrdersTableAdapter = new GroceryStoreSimulator.Datasets.vLoyaltyIDsThatCanOrderOnlineTableAdapters.vLoyaltyIDsThatCanPlaceOnlineOrdersTableAdapter();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vStoresAcceptingOnlineOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesAcceptingOnlineOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesAcceptingOnlineOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesNotClosedForever)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStoresNotClosedForeverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLoyaltyIDsThatCanPlaceOnlineOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLoyaltyIDsThatCanOrderOnlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLoyaltyIDsThatCanOrderOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.lbProductID.FormattingEnabled = true;
            this.lbProductID.Location = new System.Drawing.Point(11, 146);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(782, 160);
            this.lbProductID.TabIndex = 7;
            // 
            // btnRemoveFromOrder
            // 
            this.btnRemoveFromOrder.Location = new System.Drawing.Point(801, 332);
            this.btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            this.btnRemoveFromOrder.Size = new System.Drawing.Size(75, 44);
            this.btnRemoveFromOrder.TabIndex = 10;
            this.btnRemoveFromOrder.Text = "Remove from Cart";
            this.btnRemoveFromOrder.UseVisualStyleBackColor = true;
            // 
            // lbOrder_ProductID
            // 
            this.lbOrder_ProductID.FormattingEnabled = true;
            this.lbOrder_ProductID.Location = new System.Drawing.Point(12, 332);
            this.lbOrder_ProductID.Name = "lbOrder_ProductID";
            this.lbOrder_ProductID.Size = new System.Drawing.Size(782, 173);
            this.lbOrder_ProductID.TabIndex = 9;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(801, 147);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddToOrder.TabIndex = 8;
            this.btnAddToOrder.Text = "Add to Cart";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(11, 10);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(99, 13);
            this.lblStore.TabIndex = 19;
            this.lblStore.Text = "Store to Order From";
            // 
            // cbStoreID
            // 
            this.cbStoreID.DataSource = this.vStoresAcceptingOnlineOrdersBindingSource;
            this.cbStoreID.DisplayMember = "StoreInfo";
            this.cbStoreID.FormattingEnabled = true;
            this.cbStoreID.Location = new System.Drawing.Point(116, 7);
            this.cbStoreID.Name = "cbStoreID";
            this.cbStoreID.Size = new System.Drawing.Size(303, 21);
            this.cbStoreID.TabIndex = 1;
            this.cbStoreID.ValueMember = "StoreID";
            // 
            // vStoresAcceptingOnlineOrdersBindingSource
            // 
            this.vStoresAcceptingOnlineOrdersBindingSource.DataMember = "vStoresAcceptingOnlineOrders";
            this.vStoresAcceptingOnlineOrdersBindingSource.DataSource = this.storesAcceptingOnlineOrdersBindingSource;
            // 
            // storesAcceptingOnlineOrdersBindingSource
            // 
            this.storesAcceptingOnlineOrdersBindingSource.DataSource = this.storesAcceptingOnlineOrders;
            this.storesAcceptingOnlineOrdersBindingSource.Position = 0;
            // 
            // storesAcceptingOnlineOrders
            // 
            this.storesAcceptingOnlineOrders.DataSetName = "StoresAcceptingOnlineOrders";
            this.storesAcceptingOnlineOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(229, 119);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(320, 13);
            this.label27.TabIndex = 17;
            this.label27.Text = "Search for a product ID, name, description, manufacturer, or brand";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Look Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(800, 513);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(72, 31);
            this.btnPlaceOrder.TabIndex = 11;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // storesNotClosedForever
            // 
            this.storesNotClosedForever.DataSetName = "StoresNotClosedForever";
            this.storesNotClosedForever.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vStoresNotClosedForeverBindingSource
            // 
            this.vStoresNotClosedForeverBindingSource.DataMember = "vStoresNotClosedForever";
            this.vStoresNotClosedForeverBindingSource.DataSource = this.storesNotClosedForever;
            // 
            // vStoresNotClosedForeverTableAdapter
            // 
            this.vStoresNotClosedForeverTableAdapter.ClearBeforeFill = true;
            // 
            // vStoresAcceptingOnlineOrdersTableAdapter
            // 
            this.vStoresAcceptingOnlineOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Loyalty ID";
            // 
            // cbLoyaltyID
            // 
            this.cbLoyaltyID.DataSource = this.vLoyaltyIDsThatCanPlaceOnlineOrdersBindingSource;
            this.cbLoyaltyID.DisplayMember = "LoyaltyNumber";
            this.cbLoyaltyID.FormattingEnabled = true;
            this.cbLoyaltyID.Location = new System.Drawing.Point(116, 35);
            this.cbLoyaltyID.Name = "cbLoyaltyID";
            this.cbLoyaltyID.Size = new System.Drawing.Size(303, 21);
            this.cbLoyaltyID.TabIndex = 2;
            this.cbLoyaltyID.ValueMember = "LoyaltyID";
            // 
            // vLoyaltyIDsThatCanPlaceOnlineOrdersBindingSource
            // 
            this.vLoyaltyIDsThatCanPlaceOnlineOrdersBindingSource.DataMember = "vLoyaltyIDsThatCanPlaceOnlineOrders";
            this.vLoyaltyIDsThatCanPlaceOnlineOrdersBindingSource.DataSource = this.vLoyaltyIDsThatCanOrderOnlineBindingSource;
            // 
            // vLoyaltyIDsThatCanOrderOnlineBindingSource
            // 
            this.vLoyaltyIDsThatCanOrderOnlineBindingSource.DataSource = this.vLoyaltyIDsThatCanOrderOnline;
            this.vLoyaltyIDsThatCanOrderOnlineBindingSource.Position = 0;
            // 
            // vLoyaltyIDsThatCanOrderOnline
            // 
            this.vLoyaltyIDsThatCanOrderOnline.DataSetName = "vLoyaltyIDsThatCanOrderOnline";
            this.vLoyaltyIDsThatCanOrderOnline.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vLoyaltyIDsThatCanPlaceOnlineOrdersTableAdapter
            // 
            this.vLoyaltyIDsThatCanPlaceOnlineOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(747, 115);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(44, 26);
            this.nudQty.TabIndex = 6;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quantity";
            // 
            // txtOrderComment
            // 
            this.txtOrderComment.Location = new System.Drawing.Point(116, 62);
            this.txtOrderComment.Multiline = true;
            this.txtOrderComment.Name = "txtOrderComment";
            this.txtOrderComment.Size = new System.Drawing.Size(732, 43);
            this.txtOrderComment.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Comment";
            // 
            // frmPlaceAnOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.cbLoyaltyID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lbProductID);
            this.Controls.Add(this.btnRemoveFromOrder);
            this.Controls.Add(this.lbOrder_ProductID);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.cbStoreID);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Name = "frmPlaceAnOrder";
            this.Text = "Place an Order";
            this.Load += new System.EventHandler(this.frmPlaceAnOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vStoresAcceptingOnlineOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesAcceptingOnlineOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesAcceptingOnlineOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesNotClosedForever)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStoresNotClosedForeverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLoyaltyIDsThatCanPlaceOnlineOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLoyaltyIDsThatCanOrderOnlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLoyaltyIDsThatCanOrderOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProductID;
        private System.Windows.Forms.Button btnRemoveFromOrder;
        private System.Windows.Forms.ListBox lbOrder_ProductID;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.ComboBox cbStoreID;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPlaceOrder;
        private Datasets.StoresNotClosedForever storesNotClosedForever;
        private System.Windows.Forms.BindingSource vStoresNotClosedForeverBindingSource;
        private Datasets.StoresNotClosedForeverTableAdapters.vStoresNotClosedForeverTableAdapter vStoresNotClosedForeverTableAdapter;
        private System.Windows.Forms.BindingSource storesAcceptingOnlineOrdersBindingSource;
        private Datasets.StoresAcceptingOnlineOrders storesAcceptingOnlineOrders;
        private System.Windows.Forms.BindingSource vStoresAcceptingOnlineOrdersBindingSource;
        private Datasets.StoresAcceptingOnlineOrdersTableAdapters.vStoresAcceptingOnlineOrdersTableAdapter vStoresAcceptingOnlineOrdersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoyaltyID;
        private System.Windows.Forms.BindingSource vLoyaltyIDsThatCanOrderOnlineBindingSource;
        private Datasets.vLoyaltyIDsThatCanOrderOnline vLoyaltyIDsThatCanOrderOnline;
        private System.Windows.Forms.BindingSource vLoyaltyIDsThatCanPlaceOnlineOrdersBindingSource;
        private Datasets.vLoyaltyIDsThatCanOrderOnlineTableAdapters.vLoyaltyIDsThatCanPlaceOnlineOrdersTableAdapter vLoyaltyIDsThatCanPlaceOnlineOrdersTableAdapter;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderComment;
        private System.Windows.Forms.Label label3;
    }
}