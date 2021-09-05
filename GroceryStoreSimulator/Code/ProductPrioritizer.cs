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

namespace GroceryStoreSimulator.Code
{
    class ProductPrioritizer
    {
        private static int productID_count;

        public static int[] CreateProductPriorityArray(SqlConnection connection) {
            //List<ProductPrioritizer> productPrioritizer = new List<ProductPrioritizer>();
           // String result;
            // Figure out how many elements we will need in our prioritizer
            productID_count = (int)Utils.MyDLookup("productID", "tProduct", "", "COUNT");
            int totalPrioritizerElements = (productID_count * (productID_count + 1)) / 2;
            int[] productPrioritizer = new int[totalPrioritizerElements];
            int priorityCount = productID_count;
            int idx = 0;
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT productID from tProduct";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            try  {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    int productID = Convert.ToInt32(reader.GetValue(0));
                    for (int k = 0; k < priorityCount; k++) {
//                      productPrioritizer[idx] = priorityCount;        // These are row numbers. Not Product IDs
                        productPrioritizer[idx] = productID;        // These are row numbers. Not Product IDs
                        idx++;
                    }
                }
            }
            catch (Exception ex) {
                Utils.Log("ProductPrioritizer.CreateProductPriorityAaary(): " + ex.Message);
            } finally {
                try { reader.Close(); } catch (Exception ex) { Utils.Log("ProductPrioritizer.CreateProductPriorityAaary(): " + ex.Message); }
            }
            return productPrioritizer;
        }
    }
}
