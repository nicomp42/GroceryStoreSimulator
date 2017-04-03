using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreSimulator.Code {
    class EmplName {

        
        private String mFirstName;
        private String mLastName;

        public String lastName {
            get { return mLastName; }
            set { mLastName = value; }
        }
        public String firstName {
            get { return mFirstName; }
            set { mFirstName = value; }
        }
        public EmplName(String firstName, String lastName) {
            mFirstName = firstName;
            mLastName = lastName;
        }

    }
}
