/*****************************************************************
 * Grocery Store Simulator
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * University of Cincinnati Clermont College
 * ***************************************************************/

// See http://stackoverflow.com/questions/5873170/generate-class-from-database-table for a script to generate this class.

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreSimulator {

    public class tStoreStatus {
        public int StoreStatusID { get; set; }

        public string StoreStatus { get; set; }

        public bool IsOpenForBusiness { get; set; }

        public bool IsClosedForever { get; set; }

        public tStoreStatus(int StoreStatusID, String StoreStatus, bool IsOpenForBusiness, bool IsClosedForever) {
            this.StoreStatusID = StoreStatusID;
            this.StoreStatus = StoreStatus;
            this.IsOpenForBusiness = IsOpenForBusiness;
            this.IsClosedForever = IsClosedForever;
        }

        /// <summary>
        /// Yikes. Clear the store status history and reset the status of all stores.
        /// </summary>
        /// <param name="storeStatusID">The store status all the stores will be assigned</param>
        /// <param name="txtStoreStatus">The text box where diganostics should be written</param>
        /// <returns></returns>
        public static Boolean ResetStoreStatusHistory(int storeStatusID, TextBox txtStoreStatus) {
            Boolean status = true;
            try {
                SqlConnection connection = new SqlConnection(Config.connectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "[spDeleteStoreHistoryAndUpdateALLStoreStatus]";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
                cmd.Parameters.Add(new SqlParameter("StoreStatusID", storeStatusID));
                String now = (DateTime.Now).ToString("d");
                cmd.Parameters.Add(new SqlParameter("StartDate", now));
                cmd.ExecuteNonQuery();
                status = true;
            } catch (Exception ex) {
                status = false;
                if (txtStoreStatus != null) { txtStoreStatus.AppendText(Environment.NewLine + ex.Message); }
            }
            return status;
        }
    }
}
