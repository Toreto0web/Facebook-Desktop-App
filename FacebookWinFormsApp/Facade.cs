using System;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace FacebookDAppLogics
{
    public class Facade
    {
        private Client m_Client;


        private string[] m_sortableAttributes = { "Gender", "Name", "Birthday" };

        public string LastStatus { get { return m_Client.FetchLastStatusText(); } }

        public AppSettings AppSettings { get; }

        public string[] SortableAttributes { get { return m_sortableAttributes; } }

        public Event LastEvent { get { return m_Client.LastEvent; } }

        public string ProfilePictureUrl { get { return m_Client.ProfilePictureUrl; } }

        public FacebookCollectionWrapper<Album> ClientAlbums { get { return m_Client.ClientAlbums; } }

        public FacebookCollectionWrapper<User> Friends { get { return m_Client.MyFriendsList; } }

        public Facade()
        {
            AppSettings = AppSettings.LoadFromFile();
        }
        
        public bool isUserAccessible()
        {
            return AppSettings.RememberUser && !string.IsNullOrEmpty(AppSettings.LastAccessToken); 
        }

        public void Logout()
        {
            m_Client.LogoutClient();
        }

        public void PostFuturePost(DateTime i_Time, string i_Text)
        {
            m_Client.PostFutureStatus(i_Time, i_Text);
        }

        public void PostStatus(string i_Text)
        {
            m_Client.PostStatus(i_Text);
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
            { //Yoav access token : EAALu5L7eeuoBOxHXZAcvtyYPHcFLiknT6rbqgLU7rImXXHvmc01IKrjxMEQ20h6y5UBzMNsS8KGDLmzz5wR50JkdZAQ7S8mbUPIKViVzE7AQ1EWXFej7c57phsVXjqZCIGuAgZAOi3MmQ79fZCYSfbhIZAWO2sVYjZC4cbxy2BTRzT5ZCBGEdkYNsUJnMe51FWmZCIBJC5zj1CgZDZD
                m_Client.LoginAndInit(AppSettings.LastAccessToken);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void DownloadSelectedAlbum(int i_SelectedIndex, string i_SelectedPath, bool i_IsOK)
        {

            if (i_IsOK && !string.IsNullOrWhiteSpace(i_SelectedPath))
            {
                new Thread(() => m_Client.DownloadSelectedAlbum(i_SelectedIndex, i_SelectedPath)).Start();
            }
            else
            {
                throw new Exception();
            }

        }

        public void Sort(in string i_Result)
        {
            object SortCollectionLock = new object();

            lock (SortCollectionLock) 
            {
                m_Client.SortCollection(i_Result);
            }
        }

    }

   
}
