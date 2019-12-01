/*****************************************************************
 * Grocery Store Simulator
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * University of Cincinnati Clermont College
 * https://www.guru99.com/restful-web-services.html
 * ***************************************************************/
using ProductInfoREST;
using ProductInfoWebService.ProductInfoREST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace ProductInfoREST {
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ProductInfoService {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        public void DoWork() {
            // Add your operation implementation here
            return;
        }
        [WebGet(UriTemplate = "/ProductInfo/{productID}")]

        public Product GetProductInfo(String productID) {
            // For testing: start this project, browse to http://localhost:15176/ProductInfoService.svc/ProductInfo/1
            // Add more operations here and mark them with [OperationContract]
            return new Product("Product ID " + productID + " Product Info not implemented.", "", "");
        }
        /*        public String GetProductInfo(String productID) {
                    // For testing: start this project, browse to http://localhost:15176/ProductInfoService.svc/ProductInfo/1
                    // Add more operations here and mark them with [OperationContract]
                    return "Product Info not implemented.";
                }*/
    }
}
