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
using System.Threading.Tasks;

namespace SimulatorNamespace
{
    public class ShoppingCart {
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
