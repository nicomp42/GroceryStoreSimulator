using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreSimulator.Code {
    class ShoppingCart {
        int mLoyaltyID;
        List<ShoppingCartItem> mShoppingCartItems;
        int mStoreID;
        public ShoppingCart() {
            mShoppingCartItems = new List<ShoppingCartItem>();
        }
        public List<ShoppingCartItem> shoppingCartItems { get; set; }
        public int storeID {get; set;}
        public int loyaltyID { get; set; }
    }
}
