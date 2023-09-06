using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms;

namespace FacebookDAppLogics
{
    public class Facade
    {
        private Client m_Client;
        public AppSettings AppSettings { get; }
        private string[] m_sortableAttributes = { "Gender", "Name", "Birthday" };

        public Facade()
        {
            AppSettings = AppSettings.LoadFromFile();
        }

        public string[] SortableAttributes { get { return m_sortableAttributes; } }

        public string ProfilePictureUrl
        {   
            get
            {
                return m_Client.ProfilePictureUrl;
            }
        }

        public FacebookObjectCollection<Album> ClientAlbums 
        {
            get { return m_Client.ClientAlbums;}
        }

        public bool isUserAccessible()
        {
            return AppSettings.RememberUser && !string.IsNullOrEmpty(AppSettings.LastAccessToken); 
        }

        public void UpdateEventDataSource(BindingSource o_dataSource)
        {
            try
            {
                o_dataSource.DataSource = m_Client.LastEvent;
            }
            catch
            {
                throw new Exception();
            }
        }

        public void Logout()
        {
            m_Client.LogoutClient();
        }

        public void PostFuturePost(DateTime i_time, string i_text)
        {
            m_Client.PostFutureStatus(i_time, i_text);
        }

        public void PostStatus(string i_text)
        {
            m_Client.PostStatus(i_text);
        }

        public FacebookObjectCollection<User> Friends
        {
            get { return m_Client.MyFriendsList; }
        }

        public void UpdateSettings(in bool i_Checked)
        {
            AppSettings.RememberUser = i_Checked;

            if (AppSettings.RememberUser)
            {
                AppSettings.LastAccessToken = m_Client.AccessToken;
            }
            else
            {
                AppSettings.LastAccessToken = null;
            }

            AppSettings.SaveToFile();
        }

        public void LogInProcess()
        {
            m_Client = Client.Instance;

            try
            { // Yoav access token : EAALu5L7eeuoBOxHXZAcvtyYPHcFLiknT6rbqgLU7rImXXHvmc01IKrjxMEQ20h6y5UBzMNsS8KGDLmzz5wR50JkdZAQ7S8mbUPIKViVzE7AQ1EWXFej7c57phsVXjqZCIGuAgZAOi3MmQ79fZCYSfbhIZAWO2sVYjZC4cbxy2BTRzT5ZCBGEdkYNsUJnMe51FWmZCIBJC5zj1CgZDZD
                m_Client.LoginAndInit(AppSettings.LastAccessToken);
            }
            catch (Exception)
            {
                
                throw new Exception();
            }

        }

      
        public void DownloadSelectedAlbum(int i_SelectedIndex)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select where you want the Album will be save";
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                m_Client.DownloadSelectedAlbum(i_SelectedIndex, folderBrowser.SelectedPath);
            }
            else
            {
                throw new Exception();
            }

        }

        public void Sort(in string i_result)
        {
            m_Client.SortCollection(i_result);
        }

        
    }

   
}
