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

namespace SimulatorNamespace {
    public class SimGrocery {
        public static string title = "SimGrocery";
        Thread oThread ;

        public void Halt() {
            if (oThread != null)
            {
                try {
                    oThread.Abort();
                    oThread = null;
                } catch (Exception ex) {
                    // Eat the exception
                }
            }
        }
        /// <summary>
        /// Start adding transactions to the grocery store
        /// </summary>
        /// <param name="seed">Seed for random number generator. Use 0 for true randomness.</param>
        public void StartTransactionSimulation(int numOfTransactionsToAdd, Random r, TextBox txtResults, Label lblStatus) {
            SqlConnection connection = new SqlConnection(Config.connectionString);
            try {connection.Open();}
            catch (Exception e) { Console.WriteLine(e.ToString()); }
            AddTransactions addTransactions = null;
            try {
                addTransactions = new AddTransactions(numOfTransactionsToAdd, connection, r, txtResults, lblStatus);
                DefaultValues.computeDefaultValues();
                // Kick off thread for the Transaction Adder
                oThread = new Thread(new ThreadStart(addTransactions.StartThread));
                oThread.Start();    // Start the thread
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Unable to add transactions",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
