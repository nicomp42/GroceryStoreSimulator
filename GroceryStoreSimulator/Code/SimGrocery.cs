/*****************************************************************
 * Grocery Store Simulator
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * University of Cincinnati Clermont College
 * ***************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroceryStoreSimulator {
    class SimGrocery {
        public static string title = "SimGrocery";
        Thread oThread ;

        public void Halt() {
            oThread.Abort();
            oThread = null;
        }
        /// <summary>
        /// Start adding transactions to the grocery store
        /// </summary>
        /// <param name="seed">Seed for random number generator. Use 0 for true randomness.</param>
        public void StartTransactionSimulation(int numOfTransactionsToAdd, Random r, TextBox txtResults, Label lblStatus) { 
            AddTransactions addTransactions = null;
            SqlConnection connection = new SqlConnection(Config.connectionString);
            addTransactions = new AddTransactions(numOfTransactionsToAdd, connection, r, txtResults, lblStatus);
            DefaultValues.computeDefaultValues();
            try {
                connection.Open();
            } catch(Exception e) {Console.WriteLine(e.ToString());}
            //List<Store> stores = new List<Store>();
            //InitStores(connection, stores);

            // Kick off thread for the Transaction Adder
            //foreach (Store store in stores) {
            oThread = new Thread(new ThreadStart(addTransactions.StartThread));
            oThread.Start();    // Start the thread

        }
    }
}
