/*****************************************************************
 * Grocery Store Simulator
 *  Manipulate the ingredients in products            
 *  This code was mostly used one time, to parse the huge
 *   text field in tProduct.ingredients into tIngredients and
 *   tProductIngredients tables.
 *
 * * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * University of Cincinnati Clermont College
 * ***************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreSimulator {
    class Ingredients {
        // Text strings that we tell us to process individual ingredients as 1% or less, or 2% or less.
        private String[] containsLessThanSomePerCentList = {
                                                            "Contains less than 1 per cent of each of the following:",   "contains less than 1 per cent of each of the following:", 
                                                            "Contains less than 1 per cent of each of the following",    "contains less than 1 per cent of each of the following", 
                                                            "Contains 1 per cent or less of:",                           "contains 1 per cent or less of:", 
                                                            "Contains 1 percent or less of:",                            "contains 1 percent or less of:", 
                                                            "Contains less than 1% of:",                                 "contains less than 1% of:", 
                                                            "Contains less than 1% of",                                  "contains less than 1% of", 
                                                            "Contains 1% or less of:",                                   "contains less than 1% of:", 
                                                            "Contains 1% or less of",                                    "contains 1% or less of",
                                                            "Contain 1% or less of:",                                    "contain 1% or less of:",
                                                            "Less than 1% of:",                                          "less than 1% of:", 
                                                            "Less than 1% of",                                           "less than 1% of",
                                                            "Less than 1%",                                              "less than 1%"
                                                           };
        private String[] replacement1PerCents = {"one", "One"};
        private String[] replacement2PerCents = {"2", "Two", "two" };
        private enum enumMode { normalMode, inNestingMode };
        private SqlConnection connection;
        private int containsLessThanSomePerCent;
        private TextBox txtIngredients;

        public void AddAllIngredients(TextBox txtIngredients) {      
            this.txtIngredients = txtIngredients;
            //Boolean status = false;
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            Utils.CheckConnection();
            connection = Config.myConnection;
            cmd.Connection = connection;
//          cmd.CommandText = "SELECT ProductID, Ingredients, Description from tProduct ORDER BY Description";    // WHERE ProductID=322";
            cmd.CommandText = "SELECT TOP (100) PERCENT dbo.tProduct.ProductID, dbo.tProduct.Ingredients, dbo.tName.Name FROM dbo.tProduct INNER JOIN dbo.tName ON dbo.tProduct.NameID = dbo.tName.NameID ORDER BY dbo.tName.Name";
            try {
                reader = cmd.ExecuteReader();
                // Process all the records in tProduct
                while (reader.Read()) {
                    int productID; String ingredients; List<IngredientDetail> ingredientList;
                    productID = Convert.ToInt32(reader.GetValue(0));
                    ingredients = Convert.ToString(reader.GetValue(1));
                    //ingredients = "Chicken Stock, Cooked White Chicken Meat (White Chicken Meat, Water, Modified Food Starch, Soy Protein Concentrate, Salt, Sodium Phosphates, Chicken Flavor [Chicken Stock, Chicken Powder, Chicken Fat], Natural Flavoring),Carrots, Water, Enriched Egg Noodle (Wheat Flour, Egg White Solids, Whole Egg Solids, Niacin, Ferrous Sulfate, Thiamin Mononitrate, Riboflavin, Folic Acid), Celery, Contains less than 2% of the following ingredients: Modified Wheat Starch, Chicken Fat, Natural Flavoring, Potassium Chloride, Salt, Yeast Extract, Sugar, Hydrolyzed Wheat Gluten, Onion Powder, Corn Oil, Flavoring, Dextrose, Maltodextrin, Chicken Flavor (Chicken Stock, Salt and Enzyme), Dehydrated Parsley, Lower Sodium Natural Sea Salt, Autolyzed Yeast Extract, Cultured Whey (Milk), Dehydrated Garlic, Spice, Beta Carotene for color, Modified Food Starch, , Whole Egg Solids.";
                    ingredients = ingredients.Replace(", ,",",");    // There is at least one product ingredient list that has , , in it. 
                    ingredientList = Split(ingredients);
                    Write("Product: " + Convert.ToString(reader.GetValue(2)));
                    // Process each ingredient that was in tProduct.Ingredients
                    foreach (IngredientDetail ingredientDetail in ingredientList) {
                        try {
                            //Console.WriteLine(ingredient);
                            // Add the ingredient to tIngredient. This will fail if the ingredient is already in the table
                            Utils.ExecuteNonQuery("Insert into tIngredient(Ingredient) VALUES(" + Utils.QuoteMeForSQL(ingredientDetail.ingredient) + ")", CommandType.Text, null, null);
                            int ingredientID;
                            Write(ingredientDetail.ingredient);
                            // Look up the Ingredient ID that we just added, or the ID if it was already in the table
                            ingredientID = Convert.ToInt32(Utils.MyDLookup("IngredientID", "tIngredient", "Ingredient = " + Utils.QuoteMeForSQL(ingredientDetail.ingredient.Trim()), ""));
                            // Add a record to the many-to-many table that relates products and ingredients
                            Utils.ExecuteNonQuery("Insert into tProductIngredient(IngredientID, ProductID, containsLessThanSomePerCent) VALUES(" + ingredientID + "," + productID + ", " + Convert.ToString(ingredientDetail.containsLessThanSomePerCent) + ")", CommandType.Text, null, null);
                        } catch (Exception ex) { 
                            Console.WriteLine(ex.Message); 
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                //status = false;
            } finally {
                try { reader.Close(); } catch (Exception ex) {Utils.Log(ex.Message);}
            }
            // Test cases
            //String i1 = "Enriched Egg Noodle (Wheat Flour, Egg White Solids, Whole Egg Solids, Niacin, Ferrous Sulfate, Thiamin Mononitrate, Riboflavin, Folic Acid), Celery, Contains less than 2% of the following ingredients: Modified Wheat Starch, Chicken Fat, Natural Flavoring, Potassium Chloride, Salt, Yeast Extract, Sugar, Hydrolyzed Wheat Gluten, Onion Powder, Corn Oil, Flavoring, Dextrose, Maltodextrin, Chicken Flavor (Chicken Stock, Salt and Enzyme), Dehydrated Parsley, Lower Sodium Natural Sea Salt, Autolyzed Yeast Extract, Cultured Whey (Milk), Dehydrated Garlic, Spice, Beta Carotene for color, Modified Food Starch, , Whole Egg Solids.";
            //String i2 = "Beef, Water, Brown Sugar, Contains 2% or less of Sugar, Salt, Hydrolyzed Soy Protein, Spices, Garlic Powder, Worcestershire Sauce (Maltodextrin, Distilled Vinegar, Molasses, Corn Syrup, Salt, Caramel Color, Garlic Powder, Sugar, Spices, Tamarind, Natural Flavor, Soy Sauce (Water, Salt, Hydrolyzed Soy Protein, Corn Syrup, Caramel Color, Potassium Sorbate), Genuine Jim Beam Bourbon, Sodium Erythorbate, Sodium Nitrite.";
            //List<String> i = Split(i1);
            //Console.WriteLine("hi");
        }

        List<IngredientDetail> Split(String ingredientString) {
            List<IngredientDetail> ingredients = new List<IngredientDetail>();
            enumMode parseMode = enumMode.normalMode;
            int i = 0;
            String ingredient;
            ingredient = "";
            int parenNestingLevel, squareBracketNestingLevel;
            parenNestingLevel = 0; squareBracketNestingLevel = 0;
            containsLessThanSomePerCent = 0;
            try {
                while (true) {
                    switch (parseMode) {
                        case enumMode.normalMode:
                            switch (ingredientString.Substring(i, 1)) {
                                case ",":
                                    // We found the end of an ingredient. Add it to the list and start over.
                                    AddIngredient(ingredient, ingredients);
                                    ingredient = "";
                                    i++;
                                    break;
                                case "[":
                                    squareBracketNestingLevel++;
                                    parseMode = enumMode.inNestingMode;
                                    ingredient += ingredientString.Substring(i, 1);
                                    i++;
                                    break; 
                                case "(":
                                    parenNestingLevel++;
                                    parseMode = enumMode.inNestingMode;
                                    ingredient += ingredientString.Substring(i, 1);
                                    i++;
                                    break;
                                default:
                                    ingredient += ingredientString.Substring(i, 1);
                                    i++;
                                    break;
                            }
                            break;
                        case enumMode.inNestingMode:
                            switch (ingredientString.Substring(i, 1)) {
                                case "]":
                                    // There are some ingredient lists that have un-matched [] pairs. There don't seem to be unmatched () pairs but...
                                    if (squareBracketNestingLevel > 0) { squareBracketNestingLevel--; }
                                    if (squareBracketNestingLevel == 0 && parenNestingLevel == 0) {
                                        parseMode = enumMode.normalMode;
                                        ingredient += ingredientString.Substring(i, 1);
                                    }
                                    i++;
                                    break; 
                                case ")":
                                    // There are some ingredient lists that have un-matched [] pairs. There don't seem to be unmatched () pairs but...
                                    if (parenNestingLevel > 0) { parenNestingLevel--; }
                                    if (parenNestingLevel == 0 && squareBracketNestingLevel == 0) {
                                        parseMode = enumMode.normalMode;
                                        ingredient += ingredientString.Substring(i, 1);
                                        squareBracketNestingLevel = 0;          // Force the square bracket nesting to be closed. It's dirty data!
                                    }
                                    i++;
                                    break;
                                case "[":
                                    squareBracketNestingLevel++;
                                    ingredient += ingredientString.Substring(i, 1);
                                    i++;
                                    break;
                                case "(":
                                    parenNestingLevel++;
                                    ingredient += ingredientString.Substring(i, 1);
                                    i++;
                                    break;
                                default:
                                    ingredient += ingredientString.Substring(i, 1);
                                    i++;
                                    break;
                            }
                            break;
                    }
                }
            } catch (Exception ex) {Utils.Log(ex.Message);}
            AddIngredient(ingredient, ingredients);
            return ingredients;
        }
        /// <summary>
        /// Add an ingredient to the Ingredient List
        /// </summary>
        /// <param name="ingredient">The ingredient name</param>
        /// <param name="containsLessThanSomePerCent">the "less than" percentage, or zero, of this ingredient</param>
        /// <param name="ingredients">The list of ingredients to be added to</param>
        private void AddIngredient(String ingredient, List<IngredientDetail> ingredients) {
            ingredient = ingredient.Trim();
            if (ingredient.Length > 0) {
                // Lop off the terminating period, if any, before doing anything else
                if (ingredient.Substring(ingredient.Length - 1, 1) == ".") { ingredient = ingredient.Substring(0, ingredient.Length - 1); }

                if (ingredient.Contains("[Beef Stock, Onion Powder]")) {
                    Console.WriteLine("Hi");
                }
                // Lop off the enclosing [ and ], if any
                if ((ingredient.Length > 2) && (ingredient.Substring(0, 1) == "[") && (ingredient.Substring(ingredient.Length - 1, 1) == "]")) {
                    ingredient = ingredient.Substring(1, ingredient.Length - 2);
                }
                // Lop off the enclosing ( and ), if any
                if ((ingredient.Length > 2) && (ingredient.Substring(0, 1) == "(") && (ingredient.Substring(ingredient.Length - 1, 1) == ")")) { 
                    ingredient = ingredient.Substring(1, ingredient.Length - 2); 
                }
                // If there's only one right square bracket, delete it
                if ((ingredient.Contains("]")) && !(ingredient.Contains("[")) ) {
                    ingredient = ingredient.Replace("]","");
                }
                // If there's only one left square bracket, delete it
                if ((ingredient.Contains("[")) && !(ingredient.Contains("]")) ) {
                    ingredient = ingredient.Replace("[","");
                }
                // If there's only one right paren, delete it
                if ((ingredient.Contains(")")) && !(ingredient.Contains("("))) {
                    ingredient = ingredient.Replace(")", "");
                }
                // If there's only one left paren, delete it
                if ((ingredient.Contains("(")) && !(ingredient.Contains(")"))) {
                    ingredient = ingredient.Replace("(", "");
                }

                // Lop off the terminating asterisk, if any
                if (ingredient.Substring(ingredient.Length - 1, 1) == "*") { ingredient = ingredient.Substring(0, ingredient.Length - 1); }

                String tmp; tmp = ingredient.Substring(0, 1);
                if (tmp == "*") {
                    ingredient = ingredient.Substring(1, ingredient.Length - 1);
                }
                
                if ((ingredient.Length > 4) && ingredient.Substring(0, 4) == "and ") {
                    ingredient = ingredient.Substring(4, ingredient.Length - 4);
                }
                // Replace ' with '' so ' will be stored in the attribute
                ingredient = ingredient.Replace("'", "''");

                //if (ingredient.Trim().Equals("Calcium Disodium Brominated vegetable Oil")) {
                //    Console.WriteLine("hi");
                //}
                bool keepGoing;
                keepGoing = true;
                // Take out the "Contains less than" phrases, if present. 
                for (int i = 0; i < containsLessThanSomePerCentList.Length && keepGoing; i++) {
                    String tempIngredient;
                    // Look for the 1 per cent phrases
                    if (ingredient.Contains(containsLessThanSomePerCentList[i])) {
                        ingredient = ingredient.Replace(containsLessThanSomePerCentList[i], ""); containsLessThanSomePerCent = 1; keepGoing = false; break;
                    }
                    for (int j = 0; j < replacement1PerCents.Length; j++) {
                        tempIngredient = containsLessThanSomePerCentList[i].Replace("1", replacement1PerCents[j]);
                        if (ingredient.Contains(tempIngredient)) {
                            ingredient = ingredient.Replace(tempIngredient, ""); containsLessThanSomePerCent = 1; keepGoing = false; break;
                        }
                    }
                    for (int j = 0; j < replacement1PerCents.Length; j++) {
                        tempIngredient = containsLessThanSomePerCentList[i].Replace("1", replacement2PerCents[j]);
                        if (ingredient.Contains(tempIngredient)) {
                            ingredient = ingredient.Replace(tempIngredient, ""); containsLessThanSomePerCent = 2; keepGoing = false; break;
                        }
                    }
                }
                ingredient = ingredient.Replace("each of the following :", "");     // Something else we don't want
                ingredient = ingredient.Replace("each of the following:", "");      // Something else we don't want
                ingredient = ingredient.Replace("each of the following", "");       // Something else we don't want
                ingredient = ingredient.Replace("the following ingredients:", "");  // Something else we don't want
                ingredient = ingredient.Replace("the following:", "");              // Something else we don't want
                ingredient = ingredient.Replace("Contain  ", "");                   // Something else we don't want

                ingredients.Add(new IngredientDetail(ingredient.Trim(), containsLessThanSomePerCent));
            }
        }
        private void Write(String message) {
            if (txtIngredients != null) {
                txtIngredients.AppendText(message + Environment.NewLine);
            }
        }
    }
    /// <summary>
    /// Encapsulation of the Ingrediant info that will be added to tProductIngredient and tIngredient
    /// </summary>
    class IngredientDetail {
        public String ingredient;
        public int containsLessThanSomePerCent;
        public IngredientDetail(String ingredient, int containsLessThanSomePerCent) {
            this.ingredient = ingredient;
            this.containsLessThanSomePerCent = containsLessThanSomePerCent;
        }
    }
}