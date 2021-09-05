/*****************************************************************
 * Grocery Store Simulator
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * University of Cincinnati Clermont College
 * ***************************************************************/using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreSimulator.Code
{
    class Store {
        /// <summary>
        /// Invoke a stored procedure that will add records to tStoreHistory for all stores so all stores are open for business
        /// </summary>
        /// <param name="startDate"></param>
        public static void MakeAllStoreOpenForBusiness(DateTime startDate)
        {
            DateTime myStartDate;
            if (startDate == null) { myStartDate = Config.earliestPossibleDate; } else { myStartDate = startDate; }
            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() {ParameterName = "@StartDate", SqlDbType = SqlDbType.DateTime, Value = startDate.ToString()}
            };
            Utils.ExecuteNonQuery("spCopyStoreHistoryFromStoreTable", CommandType.StoredProcedure, null, parameters);
        }
        /// <summary>
        /// If all stores are currently closed, open some of them.
        /// Not implemented yet
        /// </summary>
        /// <param name="connection"></param>
        /// <returns>Trueif all stores were closed and we opened some of them</returns>
        public static int CheckForAllStoresClosed(SqlConnection connection, Random r)
        {
            int result = 0;
            int countOfStores = DefaultValues.storeID_count;
            // How many stores are currently closed?

            int storeID_random = Utils.GetRandomStoreID(r, DefaultValues.storeID_count);

            return result;
        }
    }
}
