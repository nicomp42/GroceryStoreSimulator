using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInfoREST {
    public class Product {
        private String _UPCA;
        private String _manufacturer;
        private String _brand;

        public String UPCA { get { return _UPCA; } }
        public String manufacturer { get { return _manufacturer; } }
        public String brand { get { return _brand; } }

        public Product(String UPCA, String manufacturer, String brand) {
            _UPCA = UPCA;
            _manufacturer = manufacturer;
            _brand = brand;
        }
        public Product() { }    // We need this to make the Web Service work else we get "Product cannot be serialized" error 

        public override String ToString() {
            return _UPCA + ", " + _manufacturer + ", " + _brand;
        }
    }
}