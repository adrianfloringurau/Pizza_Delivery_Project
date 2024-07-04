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
    public class UsersRepository
    {
        public static void CreateUsersDatabase()
        {
            Commands.DatabaseCommands.CreateUsersDatabase(Constants.DatabaseConstants.UsersDatabasePath,
                Constants.DatabaseConstants.UsersDatabaseConnectionString);
        }

        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.UsersDatabaseConnectionString);
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT id, username, password, role, COALESCE(description, '[N/A]') as alteredDescription, verified FROM Users";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.Id = reader.GetInt32(reader.GetOrdinal("id"));
                            user.Username = reader.GetString(reader.GetOrdinal("username"));
                            user.Password = reader.GetString(reader.GetOrdinal("password"));
                            user.Role = reader.GetString(reader.GetOrdinal("role"));
                            user.Description = reader.GetString(reader.GetOrdinal("alteredDescription"));
                            user.IsVerified = reader.GetBoolean(reader.GetOrdinal("verified"));
                            users.Add(user);
                        }
                    }
                    else
                    {
                        //no users
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return users;
        }

        public static List<string> GetAllUsernames()
        {
            List<string> usernames = new List<string>();
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.UsersDatabaseConnectionString);
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT username FROM Users";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            usernames.Add(reader.GetString(reader.GetOrdinal("username")));
                        }
                    }
                    else
                    {
                        //no users
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return usernames;
        }

        public static bool TryLogin(string username, string password, out string role, out string errMessage)
        {
            bool loginSuccessful = false;
            role = null;
            errMessage = null;
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.UsersDatabaseConnectionString);
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT username, password, role, verified FROM Users WHERE username = @username AND password = @password LIMIT 1";
                command.Parameters.Add(new SQLiteParameter("@username") { DbType = System.Data.DbType.String, Value = username });
                command.Parameters.Add(new SQLiteParameter("@password") { DbType = System.Data.DbType.String, Value = password });
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (reader.GetBoolean(reader.GetOrdinal("verified")))
                        {
                            role = reader.GetString(reader.GetOrdinal("role"));
                            loginSuccessful = true;
                        }
                        else
                        {
                            errMessage = "User exists but is not verified.";
                        }
                    }
                    else
                    {
                        errMessage = "Username or password incorrect.";
                    }
                }
                connection.Close();
                return loginSuccessful;
            }
            catch (Exception ex)
            {
                errMessage = "Error.";
                MessageBox.Show(ex.Message);
                return loginSuccessful;
            }
        }

        public static void TrySignUp(string username, string password, string role, string description)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.UsersDatabaseConnectionString);
                connection.Open();
                SQLiteCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = $"INSERT INTO Users (username, password, role, description) VALUES (@username, @password, @role, @description);";
                sqlCommand.Parameters.Add(new SQLiteParameter("@username", username) { DbType = System.Data.DbType.String });
                sqlCommand.Parameters.Add(new SQLiteParameter("@password", password) { DbType = System.Data.DbType.String });
                sqlCommand.Parameters.Add(new SQLiteParameter("@role", role) { DbType = System.Data.DbType.String });
                sqlCommand.Parameters.Add(new SQLiteParameter("@description", description) { DbType = System.Data.DbType.String });
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Your application was sent.", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static User VerifyUnverify(User user, string currentUser, out string errMessage)
        {
            errMessage = null;
            try
            {
                if (user.Username.Equals(currentUser))
                {
                    throw new Exception("You cannot unverify yourself.");
                }
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.UsersDatabaseConnectionString);
                connection.Open();
                SQLiteCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = $"UPDATE Users SET verified = {(user.IsVerified ? false : true)}" +
                $" WHERE id = {user.Id}";
                sqlCommand.ExecuteNonQuery();
                User newUser = new User();
                sqlCommand.CommandText = $"SELECT id, username, password, role, COALESCE(description, '[N/A]') as alteredDescription, verified" +
                $" FROM Users WHERE id = {user.Id}";
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        newUser.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        newUser.Username = reader.GetString(reader.GetOrdinal("username"));
                        newUser.Password = reader.GetString(reader.GetOrdinal("password"));
                        newUser.Role = reader.GetString(reader.GetOrdinal("role"));
                        newUser.Description = reader.GetString(reader.GetOrdinal("alteredDescription"));
                        newUser.IsVerified = reader.GetBoolean(reader.GetOrdinal("verified"));
                    }
                    else
                    {
                        //user not existent
                    }
                }
                connection.Close();
                return newUser;
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
                return user;
            }
        }

        public static User UpdatePassword(User user, string newPassword, out string errMessage)
        {
            errMessage = null;
            try
            {
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.UsersDatabaseConnectionString);
                connection.Open();
                SQLiteCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = $"UPDATE Users SET password = @password" +
                $" WHERE id = {user.Id}";
                sqlCommand.Parameters.Add(new SQLiteParameter("@password") { DbType = DbType.String, Value = newPassword });
                sqlCommand.ExecuteNonQuery();
                User newUser = new User();
                sqlCommand.CommandText = $"SELECT id, username, password, role, COALESCE(description, '[N/A]') as alteredDescription, verified" +
                $" FROM Users WHERE id = {user.Id}";
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        newUser.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        newUser.Username = reader.GetString(reader.GetOrdinal("username"));
                        newUser.Password = reader.GetString(reader.GetOrdinal("password"));
                        newUser.Role = reader.GetString(reader.GetOrdinal("role"));
                        newUser.Description = reader.GetString(reader.GetOrdinal("alteredDescription"));
                        newUser.IsVerified = reader.GetBoolean(reader.GetOrdinal("verified"));
                    }
                    else
                    {
                        //user not existent
                    }
                }
                connection.Close();
                return newUser;
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
                return user;
            }
        }

        public static void DeleteUser(User user, string currentUser, out string errMessage)
        {
            errMessage = null;
            try
            {
                if (user.Username.Equals(currentUser))
                {
                    throw new Exception("You cannot delete your account.");
                }
                SQLiteConnection connection = new SQLiteConnection(Constants.DatabaseConstants.UsersDatabaseConnectionString);
                connection.Open();
                SQLiteCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = $"DELETE FROM Users WHERE id = {user.Id}";
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {
                errMessage = ex.Message;
            }
        }
    }
}
