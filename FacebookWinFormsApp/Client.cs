using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private Client()
        {

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
                fetchUserInfo();
            }

            else
            {
                throw new Exception();
            }
           
        }

        private void fetchUserInfo()
        {
            fetchLastStatusText();
        }

        private void fetchLastStatusText()
        {
            byte postIndex = 0;
            while (string.IsNullOrEmpty(s_LoggedInUser.Posts[postIndex].Message))
            {
                postIndex++;
            }

            PostTextLabel.Text = string.Format("\"{0}\"", m_LoggedInUser.Posts[postIndex].Message);
        }




    }
}
