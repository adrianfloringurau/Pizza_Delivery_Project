using PizzaDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery.Repositories
{
    public class MainRepository
    {
        public static void CreateMainDatabase()
        {
            Commands.DatabaseCommands.CreateMainDatabase(Constants.DatabaseConstants.MainDatabasePath,
                Constants.DatabaseConstants.MainDatabaseConnectionString);
        }

        public static List<Ingredient> GetAllIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.MainDatabaseConnectionString);
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT id, name, quantity FROM Ingredients";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Ingredient ingredient = new Ingredient();
                            ingredient.Id = reader.GetInt32(reader.GetOrdinal("id"));
                            ingredient.Name = reader.GetString(reader.GetOrdinal("name"));
                            ingredient.Quantity = reader.GetFloat(reader.GetOrdinal("quantity"));
                            ingredients.Add(ingredient);
                        }
                    }
                    else
                    {
                        //no ingredients
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ingredients;
        }

        public static List<Pizza> GetAllPizzas()
        {
            List<Pizza> pizzas = new List<Pizza>();
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.MainDatabaseConnectionString);
                connection.Open();

                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT id, name, price, description FROM Pizzas";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Pizza pizza = new Pizza();
                            pizza.Id = reader.GetInt32(reader.GetOrdinal("id"));
                            pizza.Name = reader.GetString(reader.GetOrdinal("name"));
                            pizza.Price = reader.GetDouble(reader.GetOrdinal("price"));
                            pizza.Description = reader.GetString(reader.GetOrdinal("description"));

                            SQLiteCommand inline_command = connection.CreateCommand();
                            inline_command.CommandText = $"SELECT Ingredients.id as id, Ingredients.name as name, Recipes.quantity as quantity FROM Ingredients, Recipes, Pizzas" +
                                $" WHERE Ingredients.id = Recipes.id_ingredient AND Pizzas.id = Recipes.id_pizza AND" +
                                $" Pizzas.id = @id";
                            inline_command.Parameters.Add(new SQLiteParameter("@id") { DbType = System.Data.DbType.Int32, Value = pizza.Id });
                            using (var inline_reader = inline_command.ExecuteReader())
                            {
                                if (inline_reader.HasRows)
                                {
                                    while(inline_reader.Read())
                                    {
                                        Recipe recipe = new Recipe();
                                        recipe.Id = inline_reader.GetInt32(inline_reader.GetOrdinal("id"));
                                        recipe.Name = inline_reader.GetString(inline_reader.GetOrdinal("name"));
                                        recipe.Quantity = inline_reader.GetFloat(inline_reader.GetOrdinal("quantity"));
                                        pizza.Recipes.Add(recipe);
                                    }
                                }
                            }
                            pizzas.Add(pizza);
                        }
                    }
                    else
                    {
                        //no pizzas
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return pizzas;
        }

        public static Ingredient UpdateIngredient(Ingredient ingredient, string newName, string newQuantity, out string errMessage)
        {
            errMessage = null;
            try
            {
                if (!double.TryParse(newQuantity, out var quantity))
                {
                    throw new ArgumentException("Quantity value is not a valid number.");
                }
                if (quantity < 0)
                {
                    throw new Exception("Quantity cannot be negative.");
                }
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.MainDatabaseConnectionString);
                connection.Open();
                SQLiteCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = $"UPDATE Ingredients SET name = @name, quantity = @quantity" +
                $" WHERE id = {ingredient.Id}";
                sqlCommand.Parameters.Add(new SQLiteParameter("@name") { DbType = DbType.String, Value = newName });
                sqlCommand.Parameters.Add(new SQLiteParameter("@quantity") { DbType = DbType.Double, Value = quantity });
                sqlCommand.ExecuteNonQuery();
                Ingredient newIngredient = new Ingredient();
                sqlCommand.CommandText = $"SELECT id, name, quantity" +
                $" FROM Ingredients WHERE id = {ingredient.Id}";
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        newIngredient.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        newIngredient.Name = reader.GetString(reader.GetOrdinal("name"));
                        newIngredient.Quantity = reader.GetDouble(reader.GetOrdinal("quantity"));
                    }
                    else
                    {
                        //ingredient not existent
                    }
                }
                connection.Close();
                return newIngredient;
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
                return ingredient;
            }
        }

        public static void CreateIngredient(string name, double quantity)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.MainDatabaseConnectionString);
                connection.Open();
                SQLiteCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = $"INSERT INTO Ingredients (name, quantity) VALUES (@name, @quantity);";
                sqlCommand.Parameters.Add(new SQLiteParameter("@name", name) { DbType = System.Data.DbType.String });
                sqlCommand.Parameters.Add(new SQLiteParameter("@quantity", quantity) { DbType = System.Data.DbType.Double });
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Ingredient created.", "Added successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteIngredient(Ingredient ingredient, out string errMessage)
        {
            errMessage = null;
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.MainDatabaseConnectionString);
                connection.Open();
                SQLiteCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = $"SELECT COUNT(*) FROM Recipes WHERE id_ingredient = {ingredient.Id}";
                var result = sqlCommand.ExecuteScalar();
                int count = Convert.ToInt32(result);
                if (count > 0)
                {
                    throw new Exception($"The targeted ingredient appears in {count} pizzas. It cannot be deleted.");
                }
                sqlCommand.CommandText = $"DELETE FROM Ingredients WHERE id = {ingredient.Id}";
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
            }
        }

        public static void DeletePizza(Pizza pizza, out string errMessage)
        {
            errMessage = null;
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.MainDatabaseConnectionString);
                connection.Open();
                SQLiteCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = $"DELETE FROM Recipes WHERE id_pizza = {pizza.Id}";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = $"DELETE FROM Pizzas WHERE id = {pizza.Id}";
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
            }
        }

        public static void CreatePizza(string name, double price, string description, List<Recipe> recipes)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.MainDatabaseConnectionString);
                connection.Open();
                SQLiteCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = @"
                INSERT INTO Pizzas (name, price, description) 
                VALUES (@name, @price, @description);
                SELECT last_insert_rowid();";
                sqlCommand.Parameters.Add(new SQLiteParameter("@name", name) { DbType = DbType.String });
                sqlCommand.Parameters.Add(new SQLiteParameter("@price", price) { DbType = DbType.Double });
                sqlCommand.Parameters.Add(new SQLiteParameter("@description", description) { DbType = DbType.String });
                int newPizzaId = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (recipes != null)
                {
                    foreach (Recipe recipe in recipes)
                    {
                        sqlCommand.CommandText = $"INSERT INTO Recipes (id_pizza, id_ingredient, quantity)" +
                        $" VALUES ({newPizzaId}, {recipe.Id}, {recipe.Quantity})";
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Pizza created.", "Added successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdatePizza(Pizza pizza, string newName, double newPrice, string newDescription, List<Recipe> newRecipes, out string errMessage)
        {
            errMessage = null;
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.MainDatabaseConnectionString);
                connection.Open();
                SQLiteCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = $"UPDATE Pizzas SET name = @name, price = @price, description = @description" +
                $" WHERE id = {pizza.Id}";
                sqlCommand.Parameters.Add(new SQLiteParameter("@name") { DbType = DbType.String, Value = newName });
                sqlCommand.Parameters.Add(new SQLiteParameter("@price") { DbType = DbType.Double, Value = newPrice });
                sqlCommand.Parameters.Add(new SQLiteParameter("@description") { DbType = DbType.String, Value = newDescription });
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = $"DELETE FROM Recipes WHERE id_pizza = {pizza.Id}";
                sqlCommand.ExecuteNonQuery();
                foreach(var newRecipe in newRecipes)
                {
                    sqlCommand.CommandText = $"INSERT INTO Recipes (id_pizza, id_ingredient, quantity) " +
                        $"VALUES ({pizza.Id}, {newRecipe.Id}, {newRecipe.Quantity})";
                    sqlCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
            }
        }
    }
}
