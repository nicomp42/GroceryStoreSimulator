using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreSimulator {
    /// <summary>
    /// Models a row in the table tCouponDetail
    /// Not used because we have a DataTable object using the .Net DataSet tool
    /// </summary>
    class tCouponDetailX {
        public int CouponDetailID { get; set; }

        public int CouponID { get; set; }

        public int? ProductID { get; set; }

        public int DiscountTypeID { get; set; }

        public int? PercentageDiscount { get; set; }

        public decimal? AmountOff { get; set; }

        public int MaxQtyToPurchase { get; set; }

        public int MinQtyToPurchase { get; set; }
    }
}
