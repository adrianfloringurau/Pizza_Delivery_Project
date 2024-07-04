using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery.Commands
{
    public static class DatabaseCommands
    {
        public static void CreateUsersDatabase(string path, string connectionString)
        {
            if (File.Exists(path)) return;
            try
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "CREATE TABLE IF NOT EXISTS Users (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "username TEXT NOT NULL UNIQUE," +
                    "password TEXT NOT NULL," +
                    "role TEXT NOT NULL," +
                    "description TEXT," +
                    "verified BOOLEAN NOT NULL DEFAULT FALSE," +
                    "CONSTRAINT ck_role CHECK (role IN ('admin', 'client', 'delivery'))" +
                    ")";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Users (username, password, role, description, verified)" +
                    " VALUES ('root', 'TOOR', 'admin', 'Default admin.', TRUE)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Users (username, password, role, description)" +
                    " VALUES ('test', '1234', 'client', NULL)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Users (username, password, role, description, verified)" +
                    " VALUES ('client', '1234', 'client', NULL, TRUE)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Users (username, password, role, description, verified)" +
                    " VALUES ('deliveryMan', '1234', 'delivery', NULL, TRUE)";
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CreateMainDatabase(string path, string connectionString)
        {
            if (File.Exists(path)) return;
            try
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "CREATE TABLE IF NOT EXISTS Ingredients (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "name TEXT NOT NULL," +
                    "quantity DOUBLE NOT NULL," +
                    "CONSTRAINT ck_quantity CHECK (quantity >= 0)" +
                    ")";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Ingredients (name, quantity)" +
                    " VALUES ('Tomatoes', 400)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Ingredients (name, quantity)" +
                    " VALUES ('Salt', 300)";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE IF NOT EXISTS Pizzas (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "name TEXT NOT NULL," +
                    "price DOUBLE NOT NULL," +
                    "description TEXT" +
                    ")";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Pizzas (name, price, description)" +
                    " VALUES ('Pizza Diavola', 40, 'It is hot.')";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Pizzas (name, price, description)" +
                    " VALUES ('Pizza Vegetariana', 55, 'It is vegetarian.')";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE IF NOT EXISTS Recipes (" +
                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "id_pizza INTEGER NOT NULL," +
                    "id_ingredient INTEGER NOT NULL," +
                    "quantity DOUBLE NOT NULL," +
                    "FOREIGN KEY (id_pizza) REFERENCES Pizzas(id)," +
                    "FOREIGN KEY (id_ingredient) REFERENCES Ingredients(id)" +
                    ")";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Recipes (id_pizza, id_ingredient, quantity)" +
                    " VALUES (1, 1, 200)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Recipes (id_pizza, id_ingredient, quantity)" +
                    " VALUES (1, 2, 300)";
                command.ExecuteNonQuery();
                command.CommandText = "INSERT INTO Recipes (id_pizza, id_ingredient, quantity)" +
                    " VALUES (2, 2, 500)";
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
