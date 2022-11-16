/*
 * Build a list of products randompy prioritized. 
 * We use this so all the products are not purchased at the same rate over time
 * 
 *  x + (x-1) + (x-2) + (x-3) ... 1 = x(x+1)/2
 *  
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorNamespace
{
    /// <summary>
    /// Products in a grocery store sell at different rates. 
    /// We model this behavior, somewhat. 
    /// </summary>
    class ProductPrioritizer
    {
        private static int productID_count;
        /// <summary>
        /// It's more real-world that some products sell better than others. 
        /// Herein we create a collection prrioritized products
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static int[] CreateProductPriorityArray(SqlConnection connection) {
            //List<ProductPrioritizer> productPrioritizer = new List<ProductPrioritizer>();
            // String result;
            // Figure out how many elements we will need in our prioritizer
            productID_count = (int)Utils.MyDLookup("productID", "tProduct", "", "COUNT");
            if (productID_count == 0) {throw new Exception("ProductPrioritizer.CreateProductPriorityArray(): No products on file. Cannot build priority list.");}
            int totalPrioritizerElements = (productID_count * (productID_count + 1)) / 2;
            int[] productPrioritizer = new int[totalPrioritizerElements];
            int priorityCount = productID_count;
            int idx = 0;
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT productID from tProduct";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            int start = 0;
            int stop = productID_count;
            try  {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    int productID = Convert.ToInt32(reader.GetValue(0));
                    for (int k = 0; k < stop; k++, start++) {
//                      productPrioritizer[idx] = priorityCount;        // These are row numbers. Not Product IDs
                        productPrioritizer[start] = productID;        // These are row numbers. Not Product IDs
                        idx++;
                    }
                    stop = stop - 1;
                }
            }
            catch (Exception ex) {
                Utils.Log("ProductPrioritizer.CreateProductPriorityArray(): " + ex.Message);
            } finally {
                try { reader.Close(); } catch (Exception ex) { Utils.Log("ProductPrioritizer.CreateProductPriorityAaary(): " + ex.Message); }
            }
            return productPrioritizer;
        }
    }
}
