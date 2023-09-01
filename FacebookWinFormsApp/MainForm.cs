using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

 namespace FacebookDApp
{
    public partial class MainForm : Form
    {
        private string[] m_sortableAttributes = { "Gender", "Name", "Birthday" };
        private Client m_Client;
        private AppSettings m_AppSettings;

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
                new Thread(logInProccess).Start();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_Client.LogoutClient();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            new Thread(logInProccess).Start();
        }

        private void fetchClosestsEvent()
        {
            Event lastEvent = m_Client.LastEvent;
            eventBindingSource.DataSource = lastEvent;
        }

        private void buttonFuture_Click(object sender, EventArgs e)
        {
            this.Controls.Add(this.postFuturePostButton);
            this.postFuturePostButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Controls.Add(this.dateTimePicker);
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F);
        }

        private void postFuturePost_Click(object sender, EventArgs e)
        {
            m_Client.PostFuturePost(this.dateTimePicker.Value, this.textBoxPost.Text);
        }

        private void buttonPostNow_Click(object sender, EventArgs e)
        {
            m_Client.PostPost(this.textBoxPost.Text);
        }

        private void fetchProfilePicture()
        {
            pictureBoxProfile.Invoke(new Action(() => pictureBoxProfile.BackgroundImage = null));
            pictureBoxProfile.Invoke(new Action(() => pictureBoxProfile.LoadAsync(m_Client.ProfilePictureUrl)));
        }

        private void fetchAlbumNames()
        {
            albumBindingSource.DataSource = m_Client.ClientAlbums;
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
                m_AppSettings.m_LastAccessToken = m_Client.AccessToken;
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
            { // Yoav access token : EAALu5L7eeuoBOxHXZAcvtyYPHcFLiknT6rbqgLU7rImXXHvmc01IKrjxMEQ20h6y5UBzMNsS8KGDLmzz5wR50JkdZAQ7S8mbUPIKViVzE7AQ1EWXFej7c57phsVXjqZCIGuAgZAOi3MmQ79fZCYSfbhIZAWO2sVYjZC4cbxy2BTRzT5ZCBGEdkYNsUJnMe51FWmZCIBJC5zj1CgZDZD
                m_Client.LoginAndInit(m_AppSettings.m_LastAccessToken);
                fetchFacebookContent();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            enableButtonsAfterFetchSucceeded();
        }

        private void sortableAttributesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = m_sortableAttributes[sortableAttributesComboBox.SelectedIndex];

            m_Client.SortCollection(result);

            myFriendsListBox.Items.Clear();

            foreach (User user in m_Client.MyFriendsList)
            {
                myFriendsListBox.Items.Add(user.FirstName + " " + user.LastName);
            }
        }

        private void fillSortableAttributesComboBox(string[] strArr)
        {
            foreach (string str in strArr)
            {
                sortableAttributesComboBox.Invoke(new Action(() => sortableAttributesComboBox.Items.Add(str)));
            }
        }

        private void buttonDownloadSelectedAlbum_Click(object sender, EventArgs e)
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

        private void fetchFacebookContent()
        {
            FetchLastStatusTextAdapter statusTextAdapter = new FetchLastStatusTextAdapter { Client = m_Client, TextBox = PostTextLabel };
            
            fillSortableAttributesComboBox(m_sortableAttributes);
            
            fetchAlbumNames();
            new Thread(fetchProfilePicture).Start();
            new Thread(statusTextAdapter.FetchLastStatusText);
            
            //fetchClosestsEvent();
            //PostTextLabel.Text = m_Client.FetchLastStatusText();
        }

        private void enableButtonsAfterFetchSucceeded() 
        {
            AlbumNameComboBox.Invoke(new Action(() => AlbumNameComboBox.Enabled = true));
            sortableAttributesComboBox.Invoke(new Action(() => sortableAttributesComboBox.Enabled = true));
        }
    }
}
