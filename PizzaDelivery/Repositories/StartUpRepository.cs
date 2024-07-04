using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery.Repositories
{
    public static class StartUpRepository
    {
        public static void GenerateFolders()
        {
            if (!Directory.Exists(Constants.PathConstants.DatabasesRootFolder))
            {
                Directory.CreateDirectory(Constants.PathConstants.DatabasesRootFolder);
            }
            if (!Directory.Exists(Constants.PathConstants.MainDatabaseSubfolder))
            {
                Directory.CreateDirectory(Constants.PathConstants.MainDatabaseSubfolder);
            }
            if (!Directory.Exists(Constants.PathConstants.UsersDatabaseSubfolder))
            {
                Directory.CreateDirectory(Constants.PathConstants.UsersDatabaseSubfolder);
            }
            if (!Directory.Exists(Constants.PathConstants.MusicRootFolder))
            {
                Directory.CreateDirectory(Constants.PathConstants.MusicRootFolder);
            }
            if (!File.Exists(Constants.PathConstants.MusicInfoFile))
            {
                File.WriteAllText(Constants.PathConstants.MusicInfoFile, "You need to attach a music file named 'start.wav'\nin this folder for the music to work.");
            }
        }
    }
}
