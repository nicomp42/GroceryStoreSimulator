using GroceryStoreSimulator.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreSimulator {
    public partial class frmPlaceAnOrder : Form {
        ShoppingCart shoppingCart;
        public frmPlaceAnOrder() {
            InitializeComponent();
        }

        private void frmPlaceAnOrder_Load(object sender, EventArgs e) {
            this.vLoyaltyIDsThatCanPlaceOnlineOrdersTableAdapter.Fill(this.vLoyaltyIDsThatCanOrderOnline.vLoyaltyIDsThatCanPlaceOnlineOrders);
            this.vStoresAcceptingOnlineOrdersTableAdapter.Fill(this.storesAcceptingOnlineOrders.vStoresAcceptingOnlineOrders);
            this.vStoresNotClosedForeverTableAdapter.Fill(this.storesNotClosedForever.vStoresNotClosedForever);
            nudQty.Value = 1;
            shoppingCart = new ShoppingCart();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e) {
            int qty = 0;
            try {
                qty = Convert.ToInt32(nudQty.Value);
                AddProductToOrder(Convert.ToInt32(lbProductID.SelectedValue), qty);
            } catch (Exception ex) { }
        }
        private void AddProductToOrder(int productID, int qty) {
            shoppingCart.shoppingCartItems.Add(new ShoppingCartItem(productID, qty, ""));
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e) {
            shoppingCart.loyaltyID = Convert.ToInt32(cbLoyaltyID.SelectedItem);
            shoppingCart.storeID = Convert.ToInt32(cbStoreID.SelectedItem);
            PlaceOrder(shoppingCart);
        }
        private void PlaceOrder(ShoppingCart shoppingCart) {
            // Create an order with the data entered into this form.
        }
    }
}
