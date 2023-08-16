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
    public partial class MainForm : Form
    {

        User m_LoggedInUser;
        LoginResult m_LoginResult;

        public MainForm()
        {
            InitializeComponent();
        }

        private void loginAndInit()
        {
            //       m_LoginResult = FacebookService.Login("825616175626986", /// (desig patter's "Design Patterns Course App 2.4" app)
            //"email",
            //               "public_profile",
            //               "user_age_range",
            //               "user_birthday",
            //               "user_events",
            //               "user_friends",
            //               "user_gender",
            //               "user_hometown",
            //               "user_likes",
            //               "user_link",
            //               "user_location",
            //               "user_photos",
            //               "user_posts",
            //               "user_videos");


            m_LoginResult = FacebookService.Connect("EAALu5L7eeuoBOxHXZAcvtyYPHcFLiknT6rbqgLU7rImXXHvmc01IKrjxMEQ20h6y5UBzMNsS8KGDLmzz5wR50JkdZAQ7S8mbUPIKViVzE7AQ1EWXFej7c57phsVXjqZCIGuAgZAOi3MmQ79fZCYSfbhIZAWO2sVYjZC4cbxy2BTRzT5ZCBGEdkYNsUJnMe51FWmZCIBJC5zj1CgZDZD");
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                fetchUserInfo();
                AlbumNameComboBox.Enabled = true;
                RefreshButton.Enabled = true;
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void fetchUserInfo()
        {
            fetchLastStatusText();
            fetchProfilePicture();
            fetchAlbumNames();
        }

        void fetchProfilePicture()
        {
            pictureBoxProfile.BackgroundImage = null;
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureLargeURL);
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

        private void FetchClosestsEvent()
        {

            if (m_LoggedInUser.Events.Count == 0)
            {
                EventNameLabel.Text = "No events";
                EventDateLabel.Text = " ";
            }
            else
            {
                Event closesestEvent = m_LoggedInUser.Events[0];

                foreach (Event fbEvent in m_LoggedInUser.Events)
                {
                    if (fbEvent.StartTime < closesestEvent.StartTime)
                    {
                        closesestEvent = fbEvent;
                    }
                }

                EventNameLabel.Text = closesestEvent.Name;
                EventDateLabel.Text = closesestEvent.StartTime.ToString();
            }
        }

        private void fetchAlbumNames()
        {
            foreach (Album album in m_LoggedInUser.Albums)
            {
                AlbumNameComboBox.Items.Add(album.Name);
            }
        }

        private void dowLoadAlbumLabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album SelectedAlbum = m_LoggedInUser.Albums[AlbumNameComboBox.SelectedIndex];
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select where you want the Album will be save";
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                string selectedFolderPath = folderBrowser.SelectedPath;
                string newFolderPath = Path.Combine(selectedFolderPath, SelectedAlbum.Name);

                try
                {
                    Directory.CreateDirectory(newFolderPath);
                    byte photoIndex = 0;
                    foreach(Photo photo in SelectedAlbum.Photos)
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
                    MessageBox.Show("New folder created and photos saved.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
        }

        private void buttonFuture_Click(object sender, EventArgs e)
        {
            this.Controls.Add(this.postFuturePost);
            this.Controls.Add(this.dateTimePicker);
        }

        private void PostFuturePost_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonPostNow_Click(object sender, EventArgs e)
        {
            Post post = new Post();
            post.postPost(this.textBoxPost.Text);
        }


        private void fetchLastStatusText()
        {
            byte postIndex = 0;
            while (string.IsNullOrEmpty(m_LoggedInUser.Posts[postIndex].Message))
            {
                postIndex++;
            }

            PostTextLabel.Text = string.Format("\"{0}\"",m_LoggedInUser.Posts[postIndex].Message);
        }

    }
}
