using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroceryStoreSimulator {
    /// <summary>
    /// Models a row in the table tDiscountType
    /// Not used because we have a DataTable object using the .Net DataSet tool
    /// </summary>
    public class tDiscountTypeX {
        public int DiscountTypeID { get; set; }

        public string DiscountType { get; set; }

        public bool IsFree { get; set; }

        public bool IsPercentageDiscount { get; set; }

        public bool IsBOGO { get; set; }

        public bool isAmountOff { get; set; }

        public bool IsGiftCard { get; set; }

    }
}

