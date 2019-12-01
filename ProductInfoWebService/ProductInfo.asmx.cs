/*****************************************************************
 * Grocery Store Simulator
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * University of Cincinnati Clermont College
 * https://www.c-sharpcorner.com/article/how-to-create-a-web-service-project-in-net-using-visual-studio/
 * ***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProductInfoWebService {
    /// <summary>
    /// Summary description for ProductInfo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductInfo : System.Web.Services.WebService {

        /*[WebMethod]
        public string HelloWorld() {
            return "Hello World";
        }*/
        [WebMethod]

        public Product LookupProduct(int productID) {
            Product product = new Product("ID = " + productID + ", lookup not implemented","","");
            // ToDo: Implement this
            return product;
        }
    }
}
