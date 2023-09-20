// Ignore Spelling: Facebook App

using System;
using System.Xml.Serialization;
using System.IO;

namespace FacebookDAppLogics
{
    public class AppSettings
    {
        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        internal static AppSettings LoadFromFile()
        {
            AppSettings appSettings = new AppSettings();
            try
            {
                if (File.Exists(giveAppFolderPath()))
                {
                    using (Stream stream = new FileStream(giveAppFolderPath(), FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        appSettings = serializer.Deserialize(stream) as AppSettings;
                    }
                }
            }
            catch
            {
                appSettings.RememberUser = false;
                appSettings.LastAccessToken = null;
            }

            return appSettings;
        }

        private static string giveAppFolderPath()
        {
            string AppFolderPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(AppFolderPath, "appSettings.xml");

            return filePath;
        }

        internal void SaveToFile() 
        {
            string filePath = giveAppFolderPath();
            try
            {
                if (File.Exists(filePath))
                {
                    using (Stream stream = new FileStream(filePath, FileMode.Truncate))
                    {
                        XmlSerializer serializer = new XmlSerializer(this.GetType());
                        serializer.Serialize(stream, this);
                    }
                }
                else
                {
                    using (Stream stream = new FileStream(giveAppFolderPath(), FileMode.Create))
                    {
                        XmlSerializer serializer = new XmlSerializer(this.GetType());
                        serializer.Serialize(stream, this);
                    }
                }
            }
            catch 
            {
            }
        }
    }
}
