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
        Client m_Client;

        public MainForm()
        {
            InitializeComponent();
        }



        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_Client = Client.Instance;
            try 
            {
                m_Client.LoginAndInit("EAALu5L7eeuoBOxHXZAcvtyYPHcFLiknT6rbqgLU7rImXXHvmc01IKrjxMEQ20h6y5UBzMNsS8KGDLmzz5wR50JkdZAQ7S8mbUPIKViVzE7AQ1EWXFej7c57phsVXjqZCIGuAgZAOi3MmQ79fZCYSfbhIZAWO2sVYjZC4cbxy2BTRzT5ZCBGEdkYNsUJnMe51FWmZCIBJC5zj1CgZDZD");
            }
            catch(Exception)
            {
                MessageBox.Show("Login Failed");
            }

            AlbumNameComboBox.Enabled = true;
            RefreshButton.Enabled = true;
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
            if(this.dateTimePicker.Value <= DateTime.Now) 
            {
                MessageBox.Show("The time you entered already passed");
            }
            else 
            {
                DateTime currentTime = DateTime.Now;

                TimeSpan timeDifference = this.dateTimePicker.Value - currentTime;
                MessageBox.Show($"please wait {timeDifference.TotalSeconds.ToString()} seconds");
                Thread.Sleep((int)timeDifference.TotalMilliseconds);

                postPost();
            }
        }

        private void buttonPostNow_Click(object sender, EventArgs e)
        {
            postPost();
        }

        private void postPost() 
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(textBoxPost.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Done!");
            }
        }

        void fetchProfilePicture()
        {
            pictureBoxProfile.BackgroundImage = null;
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureLargeURL);
        }

        private void fetchAlbumNames()
        {
            foreach (Album album in m_Client.m_LoggedInUser.Albums)
            {
                AlbumNameComboBox.Items.Add(album.Name);
            }
        }



    }
}
