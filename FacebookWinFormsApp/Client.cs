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
        private static readonly object sr_CreatingClientLock = new object();

        private Client() { }

        internal string AccessToken
        {
            get
            {
                return s_LoginResult.AccessToken;
            }
        }

        internal FacebookCollectionWrapper<User> MyFriendsList
        {
            get
            {
                return new FacebookCollectionWrapper<User>(s_LoggedInUser.Friends.ToArray());
            }
        }

        internal FacebookCollectionWrapper<Album> ClientAlbums
        {
            get
            {
                return new FacebookCollectionWrapper<Album>(s_LoggedInUser.Albums.ToArray());
            }
        }

        public static Client Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_CreatingClientLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new Client();
                        }
                    }
                }

                return s_Instance;
            }
        }

        internal string ProfilePictureUrl
        {
            get
            {
                return s_LoggedInUser.PictureLargeURL;
            }
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

        internal void LoginAndInit(in string i_AccessToken = default)
        {
            if (!string.IsNullOrEmpty(i_AccessToken))
            {
                s_LoginResult = FacebookService.Connect(i_AccessToken);
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
            string statusText;
            try
            {
                while (string.IsNullOrEmpty(s_LoggedInUser.Posts[postIndex].Message))
                {
                    postIndex++;
                }
                statusText = string.Format("\"{0}\"", s_LoggedInUser.Posts[postIndex].Message);
            }
            catch (Exception)
            {
                statusText = "No Status to show";
            }

            return statusText;
        }

        internal void LogoutClient()
        {
            try
            {
                FacebookService.LogoutWithUI();
            }
            catch
            {
                ErrorHandler.Invoke(new Exception("Logout Failed"));
            }
            finally
            {
                s_LoggedInUser = null;
            }
        }

        internal void PostFutureStatus(in DateTime i_FuturePost, in string i_Text)
        {
            if (i_FuturePost <= DateTime.Now)
            {
                throw new Exception("The time you entered already passed");
            }
            else
            {
                DateTime currentTime = DateTime.Now;
                TimeSpan timeDifference = i_FuturePost - currentTime;
                double interval = timeDifference.TotalMilliseconds;
                m_CurrentStatus = i_Text;

                futurePostAction.Invoke(timeDifference);
                try
                {
                    System.Threading.Timer timer = new System.Threading.Timer(timerCallback, null, (int)interval, Timeout.Infinite);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void timerCallback(object i_State)
        {
            try
            {
                PostStatus(m_CurrentStatus);
            }
            catch (Exception)
            {
                ErrorHandler.Invoke(new Exception("future status didn't post because of an error"));
            }
        }

        internal void DownloadSelectedAlbum(in int i_Index, in string i_SelectedFolderPath)
        {
            object DownloadSelectedAlbumLock = new object();
            lock (DownloadSelectedAlbumLock)
            {
                Album selectedAlbum = s_LoggedInUser.Albums[i_Index];
                string newFolderPath = Path.Combine(i_SelectedFolderPath, selectedAlbum.Name);
                byte photoIndex = 0;
                try
                {
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
                catch (Exception)
                {
                    throw;
                }
            }
        }

        internal void PostStatus(in string i_Text)
        {
            try
            {
                Status postedStatus = s_LoggedInUser.PostStatus(i_Text);
            }
            catch (Exception)
            {
                ErrorHandler.Invoke(new Exception("Upload Post Failed"));
            }
        }

        public void SortCollection(in string i_Attribute)
        {
            string attributeName = i_Attribute;

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
