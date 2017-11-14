using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreSimulator.Code {
    class ShoppingCartItem {
        private int mProductID;
        private int mQty;
        private String mComment;

        public ShoppingCartItem(int productID, int qty, String comment) {
            this.productD = productD;
            this.qty = qty;
            this.comment = comment;
        }

        public int productD { get; set; }
        public int qty { get; set; }
        public String comment { get; set; }


    }
}
