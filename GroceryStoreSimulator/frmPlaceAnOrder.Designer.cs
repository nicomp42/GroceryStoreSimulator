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
            this.lbProductID = new System.Windows.Forms.ListBox();
            this.btnRemoveFromOrder = new System.Windows.Forms.Button();
            this.lbOrder_ProductID = new System.Windows.Forms.ListBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblStore = new System.Windows.Forms.Label();
            this.cbStoreID = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.lbProductID.FormattingEnabled = true;
            this.lbProductID.Location = new System.Drawing.Point(12, 60);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(782, 160);
            this.lbProductID.TabIndex = 23;
            // 
            // btnRemoveFromOrder
            // 
            this.btnRemoveFromOrder.Location = new System.Drawing.Point(802, 231);
            this.btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            this.btnRemoveFromOrder.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFromOrder.TabIndex = 22;
            this.btnRemoveFromOrder.Text = "Remove ";
            this.btnRemoveFromOrder.UseVisualStyleBackColor = true;
            // 
            // lbOrder_ProductID
            // 
            this.lbOrder_ProductID.FormattingEnabled = true;
            this.lbOrder_ProductID.Location = new System.Drawing.Point(13, 231);
            this.lbOrder_ProductID.Name = "lbOrder_ProductID";
            this.lbOrder_ProductID.Size = new System.Drawing.Size(782, 173);
            this.lbOrder_ProductID.TabIndex = 21;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(802, 61);
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
            this.cbStoreID.FormattingEnabled = true;
            this.cbStoreID.Location = new System.Drawing.Point(116, 7);
            this.cbStoreID.Name = "cbStoreID";
            this.cbStoreID.Size = new System.Drawing.Size(195, 21);
            this.cbStoreID.TabIndex = 18;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(227, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(320, 13);
            this.label27.TabIndex = 17;
            this.label27.Text = "Search for a product ID, name, description, manufacturer, or brand";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Look Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 15;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(778, 437);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(89, 31);
            this.btnPlaceOrder.TabIndex = 24;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // frmPlaceAnOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 480);
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
    }
}