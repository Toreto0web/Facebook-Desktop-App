using System;
using System.Windows.Forms;
using System.Drawing;


namespace WinFormUI
{
    public partial class MainForm : Form
    {
        private static FacebookDAppLogics.Facade s_LogicFacade;

        public MainForm()
        {
            InitializeComponent();
            s_LogicFacade = new FacebookDAppLogics.Facade();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.Manual;
            Location = s_LogicFacade.LastWindowLocation;
            checkBox.Checked = s_LogicFacade.isUserWantToBeRemember;

            if(s_LogicFacade.isUserAccessible())
            {
                LogIN();
            }
        }

        private void LogIN()
        {
            try
            {
                s_LogicFacade.LogInProcess();
                fetchFacebookContent();
                enableButtonsAfterFetchSucceeded();
                fillSortableAttributesComboBox(s_LogicFacade.SortableAttributes);


            }
            catch (Exception)
            {
                MessageBox.Show("Login Failed!");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            s_LogicFacade.Logout();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LogIN();
        }

        private void fetchClosestsEvent()
        {
            try
            {
                s_LogicFacade.UpdateEventDataSource(eventBindingSource);
            }
            catch (Exception)
            {
                NextEventNameLabel1.Text = "No farther events";
                NextEventLocationLabel1.Text = "-";
                NextEventstartTimeLabel1.Text = "_/_/_";
            }
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
            s_LogicFacade.PostFuturePost(this.dateTimePicker.Value, this.textBoxPost.Text);
        }

        private void buttonPostNow_Click(object sender, EventArgs e)
        {
            s_LogicFacade.PostStatus(textBoxPost.Text);
        }

        private void fetchProfilePicture()
        {
            pictureBoxProfile.BackgroundImage = null;
            pictureBoxProfile.LoadAsync(s_LogicFacade.ProfilePictureUrl);
        }

        private void fetchAlbumNames()
        {
            albumBindingSource.DataSource = s_LogicFacade.ClientAlbums;
        }

        private void fetchFacebookContent()
        {
            //FetchLastStatusTextAdapter statusTextAdapter = new FetchLastStatusTextAdapter { Client = m_Client, TextBox = new TextBoxProxy(PostTextLabel) };
            fetchAlbumNames();
            fetchProfilePicture();
            fetchClosestsEvent();
            //statusTextAdapter.FetchLastStatusText();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            s_LogicFacade.isUserWantToBeRemember = checkBox.Checked;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            s_LogicFacade.UpdateSettings(Location, checkBox.Checked);
        }

        private void sortableAttributesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = s_LogicFacade.SortableAttributes[sortableAttributesComboBox.SelectedIndex];

           s_LogicFacade.Sort(result);

            myFriendsListBox.Items.Clear();

            foreach (FacebookWrapper.ObjectModel.User user in s_LogicFacade.Friends)
            {
                myFriendsListBox.Items.Add(user.FirstName + " " + user.LastName);
            }
        }

        private void fillSortableAttributesComboBox(string[] strArr)
        {
            foreach (string str in strArr)
            {
                sortableAttributesComboBox.Items.Add(str);
            }
        }

        private void buttonDownloadSelectedAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                s_LogicFacade.DownloadSelectedAlbum(AlbumNameComboBox.SelectedIndex);
                MessageBox.Show("New folder created and photos saved.");
            }
            catch
            {
                MessageBox.Show("Failed to download Album to the computer");
            }

        }


        private void enableButtonsAfterFetchSucceeded()
        {
            AlbumNameComboBox.Enabled = true;
            sortableAttributesComboBox.Enabled = true;
        }
    }
}
