using System;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;
using System.Net;
using System.Threading;

namespace FacebookDApp
{
    public sealed class Client
    {
        private static User s_LoggedInUser;
        private static LoginResult s_LoginResult;
        private static Client s_Instance;
        private static Event s_closesestEvent = null;

        private Client() { }

        public string AccessToken
        {
            get
            {
                return s_LoginResult.AccessToken;
            }
        }

        public FacebookObjectCollection<User> MyFriendsList 
        {
            get 
            {
                return s_LoggedInUser.Friends;
            }
        }

        public static Client Instance
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

        public void LoginAndInit(in string i_accessToken = default)
        {
            if (!string.IsNullOrEmpty(i_accessToken))
            {
                s_LoginResult = FacebookService.Connect(i_accessToken);
            }
            else
            {
                s_LoginResult = FacebookService.Login("825616175626986",
                               "email",
                               "public_profile",
                               "user_age_range",
                               "user_birthday",
                               "user_events",
                               "user_friends",
                               "user_gender",
                               "user_hometown",
                               "user_likes",
                               "user_link",
                               "user_location",
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

        public string FetchLastStatusText()
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

        public void LogoutClient()
        {
            FacebookService.LogoutWithUI();
            s_LoginResult = null;
        }

        public Event LastEvent
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

        public void PostFutureStatus(in DateTime i_futurePost, in string text)
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

        public void DownloadSelectedAlbum(in int i_index, in string i_selectedFolderPath)
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

        public string ProfilePictureUrl
        {
            get
            {
                return s_LoggedInUser.PictureLargeURL;
            }
        }

        public FacebookObjectCollection<Album> ClientAlbums
        {
            get
            {
                return s_LoggedInUser.Albums;
            }
        }

        public void PostStatus(in string text)
        {
            try
            {
                Status postedStatus = s_LoggedInUser.PostStatus(text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Done!");
            }
        }

        public void SortCollection(in string i_attribute)
        {
            FacebookUserCollection myFriends = new FacebookUserCollection(s_LoggedInUser.Friends.ToArray<User>());
            myFriends.SortCollection(i_attribute);
        }

    }
}
