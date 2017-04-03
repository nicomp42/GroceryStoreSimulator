using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStoreSimulator.Code
{
    class City
    {
        private String mCity;
        private String mState;
        private String mZip;
    
        public City(String city, String state)
        {
            this.city = city;
            this.state = state;
        }

        public String city {
            get { return mCity; }
            set { mCity = value; }
        }

        public String state {
            get { return mState; }
            set { mState = value; }
        }

        public String zip {
            get { return mZip; }
            set { mZip = value; }
        }



    }
}
