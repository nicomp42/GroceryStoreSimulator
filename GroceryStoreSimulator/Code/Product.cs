using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreSimulator.Code {
    class Product {
        /// <summary>
        /// Read interesting product info and put it into a text box on a form
        /// </summary>
        /// <param name="productID"> Product ID</param>
        /// <param name="txtProductInfo"></param>
        public static void DisplayProductIDInfo(int productID, TextBox txtProductInfo) {
            txtProductInfo.Text = "";
            String tmp = "";
            FormatProductIDForDisplay(productID, out tmp);
            txtProductInfo.Text = tmp;
        }
        /// <summary>
        /// Look up a product using the natural key and create a user-friendly string for it
        /// </summary>
        /// <param name="product"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static Boolean FormatProductIDForDisplay(int productID, out String result) {
            result = "";
            SqlDataReader reader = null;
            bool status = true;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select foo from [fGetProductInfoForDisplayByProductID](" + Convert.ToString(productID) + ")";
            //cmd.CommandText = "select foo from [fGetProductInfoForDisplayByProductID]";
            cmd.CommandType = CommandType.Text;
            Utils.CheckConnection();
            //cmd.Parameters.Add(new SqlParameter("ProductID", productID));
            Utils.CheckConnection();
            cmd.Connection = Config.myConnection;
            Boolean found = false;
            try {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    result = reader.GetString(0);
                    found = true;
                }
            } catch (Exception ex) {
                result = ex.Message;
                status = false;
            } finally {
                try { reader.Close(); } catch (Exception ex) {Utils.Log(ex.Message);}
            }
            if (!found) { result = "No matches."; }

            return status;
        }

        /// <summary>
        /// Read interesting product info and put it into a text box on a form
        /// </summary>
        /// <param name="productInfo">A productID or part of a descriprtion, brand, name, manufacturer</param>
        /// <param name="txtProductInfo"></param>
        public static void DisplayProductInfo(String productInfo, TextBox txtProductInfo) {
            txtProductInfo.Text = "";
            String result;
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select foo from fGetProductInfoForDisplay(" + Utils.QuoteMeForSQL(Convert.ToString(productInfo)) + ")";
            cmd.CommandType = CommandType.Text;
            Utils.CheckConnection();
            SqlConnection connection;
            connection = Config.myConnection;
            cmd.Connection = connection;
            //cmd.Parameters.Add(new SqlParameter("ProductInfo", Utils.QuoteMeForSQL(productInfo)));
            Boolean found = false;
            try {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    result = reader.GetString(0);
                    txtProductInfo.AppendText(result + Environment.NewLine);
                    found = true;
                }
            } catch (Exception ex) {
                txtProductInfo.AppendText(ex.Message + Environment.NewLine);
            } finally {
                try { reader.Close(); } catch (Exception ex) { Utils.Log(ex.Message);}
            }
            if (!found) { result = "No matches."; }

        }
    }
}
