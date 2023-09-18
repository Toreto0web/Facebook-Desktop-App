using System;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace FacebookDAppLogics
{
    public class Facade
    {
        public Client Client { get { return Client.Instance;}}

        private Client privateFlexableClient { get; set; }

        private string[] m_SortableAttributes = { "Gender", "Name", "Birthday" };

        public string LastStatus { get { return privateFlexableClient.FetchLastStatusText(); } }

        public AppSettings AppSettings { get; }

        public string[] SortableAttributes { get { return m_SortableAttributes; } }

        public Event LastEvent { get { return privateFlexableClient.LastEvent; } }

        public string ProfilePictureUrl { get { return privateFlexableClient.ProfilePictureUrl; } }

        public FacebookCollectionWrapper<Album> ClientAlbums { get { return Client.ClientAlbums; } }

        public FacebookCollectionWrapper<User> Friends { get { return Client.MyFriendsList; } }

        public Facade()
        {
            AppSettings = AppSettings.LoadFromFile();
        }
        
        public bool IsUserAccessible()
        {
            return AppSettings.RememberUser && !string.IsNullOrEmpty(AppSettings.LastAccessToken); 
        }

        public void Logout()
        {
            privateFlexableClient.LogoutClient();
        }

        public void PostFuturePost(DateTime i_Time, string i_Text)
        {
            privateFlexableClient.PostFutureStatus(i_Time, i_Text);
        }

        public void PostStatus(string i_Text)
        {
            privateFlexableClient.PostStatus(i_Text);
        }

        public void UpdateSettings(in bool i_Checked)
        {
            AppSettings.RememberUser = i_Checked;

            if (AppSettings.RememberUser)
            {
                AppSettings.LastAccessToken = privateFlexableClient.AccessToken;
            }
            else
            {
                AppSettings.LastAccessToken = null;
            }

            AppSettings.SaveToFile();
        }

        public void LogInProcess()
        {
            privateFlexableClient = Client.Instance;

            try
            { //Yoav access token : EAALu5L7eeuoBOxHXZAcvtyYPHcFLiknT6rbqgLU7rImXXHvmc01IKrjxMEQ20h6y5UBzMNsS8KGDLmzz5wR50JkdZAQ7S8mbUPIKViVzE7AQ1EWXFej7c57phsVXjqZCIGuAgZAOi3MmQ79fZCYSfbhIZAWO2sVYjZC4cbxy2BTRzT5ZCBGEdkYNsUJnMe51FWmZCIBJC5zj1CgZDZD
                privateFlexableClient.LoginAndInit(AppSettings.LastAccessToken);
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
                new Thread(() => privateFlexableClient.DownloadSelectedAlbum(i_SelectedIndex, i_SelectedPath)).Start();
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
                privateFlexableClient.SortCollection(i_Result);
            }
        }

    }

   
}
