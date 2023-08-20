using System;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;

namespace FacebookDApp
{
    public class AppSettings
    {
        public Point m_LastWindowLocation { get; set; }

        public Size m_LastWindowSize { get; set; }

        public bool m_RememberUser { get; set; }

        public string m_LastAccessToken { get; set; }

        private AppSettings()
        {
            m_LastWindowLocation = new Point(20, 50);
            m_LastWindowSize = new Size(1100, 520);
            m_RememberUser = false;
            m_LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = new AppSettings();

            if (File.Exists(AppSettings.giveDesktopPath()))
            {
                using (Stream stream = new FileStream(AppSettings.giveDesktopPath(), FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return appSettings;
        }

        private static string giveDesktopPath()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "appSettings.xml");

            return filePath;
        }

        public void SaveToFile() 
        {
            if (File.Exists(giveDesktopPath())) 
            {
                using (Stream stream = new FileStream(giveDesktopPath(), FileMode.Truncate)) 
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }            
            }
            else 
            {
                using (Stream stream = new FileStream(giveDesktopPath(), FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }
    }
}
