using System;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;
using System.Net;
using System.Threading;

namespace FacebookDAppLogics
{
    internal sealed class Client
    {
        private static User s_LoggedInUser;
        private static LoginResult s_LoginResult;
        private static Client s_Instance;

        private Client()
        {
            FacebookService.s_UseForamttedToStrings = true;
        }

        internal bool isLoggedIn { get { return s_Instance != null; } }

        internal string AccessToken
        {
            get
            {
                return s_LoginResult.AccessToken;
            }
        }

        internal FacebookObjectCollection<User> MyFriendsList 
        {
            get 
            {
                return s_LoggedInUser.Friends;
            }
        }

        internal static Client Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new Client();
                }

                return s_Instance;
            }
        }

        internal void LoginAndInit(in string i_accessToken = default)
        {
            if (!string.IsNullOrEmpty(i_accessToken))
            {
                s_LoginResult = FacebookService.Connect(i_accessToken);
            }
            else
            {
                s_LoginResult = FacebookService.Login("825616175626986",
                               "public_profile",
                               "user_age_range",
                               "user_birthday",
                               "user_events",
                               "user_friends",
                               "user_gender",
                               "user_photos",
                               "user_posts",
                               "user_videos");
            }

            if (!string.IsNullOrEmpty(s_LoginResult.AccessToken))
            {
                s_LoggedInUser = s_LoginResult.LoggedInUser;
            }

            else
            {
                throw new Exception();
            }

        }

        internal string FetchLastStatusText()
        {
            byte postIndex = 0;

            try
            {
                while (string.IsNullOrEmpty(s_LoggedInUser.Posts[postIndex].Message))
                {
                    postIndex++;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("fetching status failed");
            }

            return string.Format("\"{0}\"", s_LoggedInUser.Posts[postIndex].Message);
        }

        internal void LogoutClient()
        {
            FacebookService.LogoutWithUI();
            s_LoginResult = null;
        }

        internal Event LastEvent
        {
            get
            {
                if (s_LoggedInUser.Events.Count == 0)
                {
                    throw new Exception("No Events");
                }
                else
                {
                    Event closesestEvent = s_LoggedInUser.Events[0];

                    foreach (Event fbEvent in s_LoggedInUser.Events)
                    {
                        if (fbEvent.StartTime < closesestEvent.StartTime)
                        {
                            closesestEvent = fbEvent;
                        }
                    }
                    return closesestEvent;
                }
            }
        }

        internal void PostFutureStatus(in DateTime i_futurePost, in string text)
        {
            if (i_futurePost <= DateTime.Now)
            {
                MessageBox.Show("The time you entered already passed");
            }
            else
            {
                DateTime currentTime = DateTime.Now;

                TimeSpan timeDifference = i_futurePost - currentTime;
                MessageBox.Show($"please wait {timeDifference.TotalSeconds.ToString("0.00")} seconds");
                Thread.Sleep((int)timeDifference.TotalMilliseconds);

                PostStatus(text);
            }
        }

        internal void DownloadSelectedAlbum(in int i_index, in string i_selectedFolderPath)
        {
            Album selectedAlbum = s_LoggedInUser.Albums[i_index];
            string newFolderPath = Path.Combine(i_selectedFolderPath, selectedAlbum.Name);
            Directory.CreateDirectory(newFolderPath);
            byte photoIndex = 0;
            foreach (Photo photo in selectedAlbum.Photos)
            {
                string imageUrl = photo.PictureNormalURL;
                string fileName = (++photoIndex).ToString() + ".jpg";
                string fullPath = Path.Combine(newFolderPath, fileName);

                using (WebClient webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(imageUrl);

                    File.WriteAllBytes(fullPath, imageBytes);
                }
            }
        }

        internal string ProfilePictureUrl
        {
            get
            {
                return s_LoggedInUser.PictureLargeURL;
            }
        }

        internal FacebookObjectCollection<Album> ClientAlbums
        {
            get
            {
                return s_LoggedInUser.Albums;
            }
        }

        internal void PostStatus(in string text)
        {
            try
            {
                Status postedStatus = s_LoggedInUser.PostStatus(text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception)
            {
                MessageBox.Show("Done!");
            }
        }

        internal void SortCollection(in string i_attribute)
        {
            FacebookUserCollection myFriends = new FacebookUserCollection(s_LoggedInUser.Friends.ToArray<User>());
            myFriends.SortCollection(i_attribute);
        }

    }
}
