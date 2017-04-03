using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreSimulator {
    public class DefaultValues {

        public static int loyaltyID_count {get; set;}
        public static int transactionTypeID_count { get; set; }
        public static int emplID_count { get; set; }
        public static int emplTitleID_count { get; set; }
        public static int emplStatusID_count { get; set; }
        public static int productID_count { get; set; }
        public static int storeID_count { get; set; }
        public static int transactionTypeID_Purchase { get; set; }

        /// <summary>
        /// Compute default values that will be used for all the transactions we simulate
        /// </summary>
        public static void computeDefaultValues() {
            loyaltyID_count = (int)Utils.MyDLookup("loyaltyID", "tloyalty", "", "COUNT");
            transactionTypeID_count = (int)Utils.MyDLookup("transactionTypeID", "ttransactionType", "", "COUNT");
            emplID_count = (int)Utils.MyDLookup("emplID", "templ", "", "COUNT");
            emplTitleID_count = (int)Utils.MyDLookup("emplTitleID", "tEmplTitle", "", "COUNT");
            emplStatusID_count = (int)Utils.MyDLookup("emplStatusID", "tEmplStatus", "", "COUNT");
            productID_count = (int)Utils.MyDLookup("productID", "tProduct", "", "COUNT");
            storeID_count = (int)Utils.MyDLookup("storeID", "tStore", "", "COUNT");

            transactionTypeID_Purchase = (int)Utils.MyDLookup("transactionTypeID", "tTransactionType", "TransactionType=" + Utils.QuoteMeForSQL("Purchase"), "");
        }
    }
}
