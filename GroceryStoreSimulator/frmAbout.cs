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
    public partial class frmAbout : Form {
        public frmAbout() {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e) {
            lblVersion.Text = "Version: " + Config.version;
        }

        private void lblVersion_Click(object sender, EventArgs e) {

        }
    }
}
