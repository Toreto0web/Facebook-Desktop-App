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

namespace FacebookDApp
{
    public partial class MainForm : Form
    {

        User m_LoggedInUser;
        LoginResult m_LoginResult;

        public MainForm()
        {
            InitializeComponent();
        }

        private void FetchClosestsEvent() 
        {
            Event nearestEvent = new Event();
            nearestEvent.UpdateTime = DateTime.Now;
            m_LoggedInUser.Events.Add(new Event());

          
            if(m_LoggedInUser.Events.Count == 0) 
            {
                label1.Text = "No events";
                label2.Text = " ";
            }
            else 
            {
                nearestEvent = m_LoggedInUser.Events[0];
            
                foreach(Event fbEvent in m_LoggedInUser.Events) 
                {
                    if(fbEvent.StartTime < nearestEvent.StartTime) 
                    {
                        nearestEvent = fbEvent;
                    }
                }

                label1.Text = nearestEvent.Name;
                label2.Text = nearestEvent.StartTime.ToString();
            }
        }

        private void loginAndInit()
        {
            m_LoginResult = FacebookService.Login("825616175626986",
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

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FetchClosestsEvent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
