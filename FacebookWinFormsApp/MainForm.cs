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
            m_Client.LogoutClient();
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
            Event lastEvent = m_Client.LastEvent;
            if (lastEvent == null)
            {
                EventNameLabel.Text = "No events";
                EventDateLabel.Text = " ";
            }
            else
            {
                EventNameLabel.Text = lastEvent.Name;
                EventDateLabel.Text = lastEvent.StartTime.ToString();
            }
        }

        private void dowLoadAlbumLabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select where you want the Album will be save";
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                try
                {
                    m_Client.DownloadSelectedAlbum(AlbumNameComboBox.SelectedIndex, folderBrowser.SelectedPath);
                    MessageBox.Show("New folder created and photos saved.");
                }
                catch
                {
                   MessageBox.Show("Failed to download Album to the computer");
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


        void fetchProfilePicture()
        {
            pictureBoxProfile.BackgroundImage = null;
            pictureBoxProfile.LoadAsync(m_Client.ProfilePictureUrl);
        }

        private void fetchAlbumNames()
        {
            foreach (Album album in m_Client.ClientAlbums)
            {
                AlbumNameComboBox.Items.Add(album.Name);
            }
        }



    }
}
