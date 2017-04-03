using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreSimulator.Code {
    class SimCoupon {
        public static string title = "SimCoupon";
        Thread oThread ;

        public void Halt() {
            oThread.Abort();
            oThread = null;
        }
        /// <summary>
        /// Start adding transactions to the grocery store
        /// </summary>
        /// <param name="seed">Seed for random number generator. Use 0 for true randomness.</param>
        public void StartCouponSimulation(int numOfCouponsToAdd, Random r, SqlConnection connection, TextBox txtResults, Label lblStatus) { 
            Coupon coupon = null;
            coupon = new Coupon(numOfCouponsToAdd, connection, r, txtResults, lblStatus);
            oThread = new Thread(new ThreadStart(coupon.StartThread));
            oThread.Start();    // Start the thread
        }
    }
}
