using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreSimulator.Code
{
    class Store
    {



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
    }
}
