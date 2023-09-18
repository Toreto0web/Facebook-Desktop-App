using System;
using System.Linq;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;
using System.Threading;
using System.Net;
using System.Reflection;

namespace FacebookDAppLogics
{
    public sealed class Client
    {
        public event Action<TimeSpan> futurePostAction;
        public event Action<Exception> ErrorHandler;

        private static User s_LoggedInUser;
        private static LoginResult s_LoginResult;
        private static Client s_Instance;
        private string m_CurrentStatus;

        private Client() { }

        public bool isLoggedIn { get { return s_Instance != null; } }

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

            catch (Exception e)
            {
               throw e;
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
                throw new Exception("The time you entered already passed");
            }
            else
            {
                DateTime currentTime = DateTime.Now;
                TimeSpan timeDifference = i_futurePost - currentTime;
                double interval = timeDifference.TotalMilliseconds;
                m_CurrentStatus = text;
                
                futurePostAction.Invoke(timeDifference);
                try
                {
                    System.Threading.Timer timer = new System.Threading.Timer(TimerCallback, null, (int)interval, Timeout.Infinite);
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        private void TimerCallback(object state)
        {
            try
            {
                PostStatus(m_CurrentStatus);
            }
            catch(Exception)
            {
                ErrorHandler.Invoke(new Exception("future status didn't post because of an error"));
            }
        }

        public void DownloadSelectedAlbum(in int i_index, in string i_selectedFolderPath)
        {
            object DownloadSelectedAlbumLock = new object();
            lock (DownloadSelectedAlbumLock)
            {
                Album selectedAlbum = s_LoggedInUser.Albums[i_index];
                string newFolderPath = Path.Combine(i_selectedFolderPath, selectedAlbum.Name);
                byte photoIndex = 0;
                Directory.CreateDirectory(newFolderPath);

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
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SortCollection(in string i_attribute)
        {
            string attributeName = i_attribute;

            FacebookCollectionWrapper<User> myFriends = new FacebookCollectionWrapper<User>(s_LoggedInUser.Friends.ToArray(), (user1, user2) =>
            {
                PropertyInfo property = typeof(User).GetProperty(attributeName);
                if (property != null)
                {
                    IComparable value1 = (IComparable)property.GetValue(user1);
                    IComparable value2 = (IComparable)property.GetValue(user2);
                    return value1.CompareTo(value2);
                }
                else
                {
                    throw new Exception("Attribute not exist");
                }

            });

            myFriends.SortCollection();
        }

    }
}
