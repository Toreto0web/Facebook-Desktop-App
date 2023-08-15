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
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureLargeURL);
            fetchAlbumNames();
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
            Album SelectedAlbum = getselectedAlbum();
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select where you want the ALbum will be save";
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                string selectedFolderPath = folderBrowser.SelectedPath;
                string newFolderPath = Path.Combine(selectedFolderPath, "NewPhotoFolder");

                try
                {
                    Directory.CreateDirectory(newFolderPath);
                    foreach(Photo photo in SelectedAlbum.Photos)
                    {
                        string imageUrl = photo.PictureNormalURL;
                        string fileName = photo.Name + ".jpg";
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

        private Album getselectedAlbum()
        {
            string albumNameSelected = AlbumNameComboBox.SelectedIndex.ToString();

            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (album.Name == albumNameSelected)
                {
                    return album;
                }

            }

            return null;
        }
    }
}
