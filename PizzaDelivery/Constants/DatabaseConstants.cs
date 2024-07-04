using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery.Constants
{
    public static class DatabaseConstants
    {
        public static string UsersDatabasePath = $@"{PathConstants.UsersDatabaseSubfolder}\UsersDatabase.db";
        public static string UsersDatabaseConnectionString
        {
            get
            {
                return $"Data Source={UsersDatabasePath};Version=3;";
            }
        }
        public static string MainDatabasePath = $@"{PathConstants.MainDatabaseSubfolder}\MainDatabase.db";
        public static string MainDatabaseConnectionString
        {
            get
            {
                return $"Data Source={MainDatabasePath};Version=3;";
            }
        }
    }
}
