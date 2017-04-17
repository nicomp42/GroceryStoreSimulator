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
        public frmPlaceAnOrder() {
            InitializeComponent();
        }

        private void frmPlaceAnOrder_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'storesAcceptingOnlineOrders.vStoresAcceptingOnlineOrders' table. You can move, or remove it, as needed.
            this.vStoresAcceptingOnlineOrdersTableAdapter.Fill(this.storesAcceptingOnlineOrders.vStoresAcceptingOnlineOrders);
            // TODO: This line of code loads data into the 'storesNotClosedForever.vStoresNotClosedForever' table. You can move, or remove it, as needed.
            this.vStoresNotClosedForeverTableAdapter.Fill(this.storesNotClosedForever.vStoresNotClosedForever);

        }
    }
}
