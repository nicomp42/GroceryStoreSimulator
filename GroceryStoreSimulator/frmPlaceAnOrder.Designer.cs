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
            ((System.ComponentModel.ISupportInitialize)(this.vStoresAcceptingOnlineOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesAcceptingOnlineOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesAcceptingOnlineOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesNotClosedForever)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStoresNotClosedForeverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.lbProductID.FormattingEnabled = true;
            this.lbProductID.Location = new System.Drawing.Point(11, 146);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(782, 160);
            this.lbProductID.TabIndex = 23;
            // 
            // btnRemoveFromOrder
            // 
            this.btnRemoveFromOrder.Location = new System.Drawing.Point(801, 317);
            this.btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            this.btnRemoveFromOrder.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFromOrder.TabIndex = 22;
            this.btnRemoveFromOrder.Text = "Remove ";
            this.btnRemoveFromOrder.UseVisualStyleBackColor = true;
            // 
            // lbOrder_ProductID
            // 
            this.lbOrder_ProductID.FormattingEnabled = true;
            this.lbOrder_ProductID.Location = new System.Drawing.Point(12, 317);
            this.lbOrder_ProductID.Name = "lbOrder_ProductID";
            this.lbOrder_ProductID.Size = new System.Drawing.Size(782, 173);
            this.lbOrder_ProductID.TabIndex = 21;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(801, 147);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddToOrder.TabIndex = 20;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
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
            this.cbStoreID.TabIndex = 18;
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
            this.button1.TabIndex = 16;
            this.button1.Text = "Look Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 15;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(783, 513);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(89, 31);
            this.btnPlaceOrder.TabIndex = 24;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
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
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Loyalty ID";
            // 
            // frmPlaceAnOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 556);
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
    }
}