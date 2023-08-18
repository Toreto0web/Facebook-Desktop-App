﻿using System;
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
        string[] m_sortableAttributes = {"Gender", "Name", "Birthday"};
        Client m_Client;
        AppSettings m_AppSettings;

        public MainForm()
        {
            InitializeComponent();
            
            m_AppSettings = AppSettings.LoadFromFile();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = m_AppSettings.m_LastWindowLocation;
            this.checkBox.Checked = m_AppSettings.m_RememberUser;

            if(m_AppSettings.m_RememberUser &&
                !string.IsNullOrEmpty(m_AppSettings.m_LastAccessToken)) 
            {
                logInProccess();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_Client.LogoutClient();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            logInProccess();
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
            this.Controls.Add(this.postFuturePostButton);
            this.postFuturePostButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Controls.Add(this.dateTimePicker);
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F);

        }

        private void PostFuturePost_Click(object sender, EventArgs e)
        {
            m_Client.PostFuturePost(this.dateTimePicker.Value, this.textBoxPost.Text);
        }

        private void buttonPostNow_Click(object sender, EventArgs e)
        {
            m_Client.postPost(this.textBoxPost.Text);
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

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            m_AppSettings.m_RememberUser = checkBox.Checked;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            m_AppSettings.m_LastWindowLocation = this.Location;
            m_AppSettings.m_LastWindowSize = this.Size;
            m_AppSettings.m_RememberUser = this.checkBox.Checked;

            if (m_AppSettings.m_RememberUser) 
            {
                m_AppSettings.m_LastAccessToken = m_Client.AccesToken;
            }
            else 
            {
                m_AppSettings.m_LastAccessToken = null;
            }

            m_AppSettings.SaveToFile();
        }

        private void logInProccess() 
        {
            m_Client = Client.Instance;

            try
            { // yoav access token : EAALu5L7eeuoBOxHXZAcvtyYPHcFLiknT6rbqgLU7rImXXHvmc01IKrjxMEQ20h6y5UBzMNsS8KGDLmzz5wR50JkdZAQ7S8mbUPIKViVzE7AQ1EWXFej7c57phsVXjqZCIGuAgZAOi3MmQ79fZCYSfbhIZAWO2sVYjZC4cbxy2BTRzT5ZCBGEdkYNsUJnMe51FWmZCIBJC5zj1CgZDZD
                m_Client.LoginAndInit(m_AppSettings.m_LastAccessToken);
                fetchAlbumNames();
                fetchProfilePicture();
                fillComboBox(m_sortableAttributes);
                PostTextLabel.Text = m_Client.FetchLastStatusText();
            }
            catch (Exception)
            {
                MessageBox.Show("Login Failed");
            }

            AlbumNameComboBox.Enabled = true;
            sortableAttributesComboBox.Enabled = true;
            RefreshButton.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sortableAttributesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = m_sortableAttributes[sortableAttributesComboBox.SelectedIndex];

            m_Client.sortCollection<>
        }

        private void fillComboBox(string[] strArr)
        {
            foreach (string str in strArr)
            {
                sortableAttributesComboBox.Items.Add(str);
            }
        }
    }
}
