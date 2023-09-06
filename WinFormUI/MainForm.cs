﻿using System;
using System.Windows.Forms;
using System.Threading;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        private static FacebookDAppLogics.Facade s_LogicFacade;

        public MainForm()
        {
            InitializeComponent();
            s_LogicFacade = new FacebookDAppLogics.Facade();
            FacebookDAppLogics.Client.Instance.ErrorHandler += Instance_ErrorHandler;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.Manual;
            checkBoxRememberMe.Checked = s_LogicFacade.AppSettings.RememberUser;

            if (s_LogicFacade.isUserAccessible())
            {
                new Thread(LogIN).Start();
            }
        }

        private void Instance_ErrorHandler(Exception obj)
        {
            MessageBox.Show(obj.Message);
        }

        private void LogIN()
        {
            object LogInLock = new object();

            lock (LogInLock)
            {
                try
                {
                    buttonLogin.Enabled = false;
                    s_LogicFacade.LogInProcess();
                    fetchFacebookContent();
                    enableButtonsAfterFetchSucceeded();
                }
                catch (Exception)
                {
                    MessageBox.Show("Login Failed...");
                    buttonLogin.Invoke(new Action(() => buttonLogin.Enabled = true));
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            s_LogicFacade.Logout();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonLogin.Enabled = false;
            new Thread(LogIN).Start();
        }

        private void fetchClosestsEvent()
        {
            try
            {
                eventBindingSource.DataSource = s_LogicFacade.LastEvent;
            }
            catch (Exception)
            {
                NextEventNameLabel1.Invoke(new Action(() => NextEventNameLabel1.Text = "No farther events"));
                NextEventNameLabel1.Invoke(new Action(() => NextEventLocationLabel1.Text = "-"));
                NextEventNameLabel1.Invoke(new Action(() => NextEventstartTimeLabel1.Text = "_/_/_"));
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
            FacebookDAppLogics.Client.Instance.futurePostAction += Instance_futurePostAction;
            try
            {
                s_LogicFacade.PostFuturePost(this.dateTimePicker.Value, this.textBoxPost.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Instance_futurePostAction(TimeSpan i_time)
        {
            string timeLeft;
            if (i_time.TotalDays > 1)
            {
                timeLeft = i_time.TotalDays.ToString("0") + " days";
            }
            else if(i_time.TotalHours > 1)
            {
                timeLeft = i_time.TotalHours.ToString("0") + " hours";
            }
            else
            {
                timeLeft = i_time.TotalSeconds.ToString("0") + " seconds";
            }


            MessageBox.Show($"the post will upload in {timeLeft}");
        }

        private void buttonPostNow_Click(object sender, EventArgs e)
        {
            try
            {
                s_LogicFacade.PostStatus(textBoxPost.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchProfilePicture()
        {
            pictureBoxProfile.BackgroundImage = null;
            pictureBoxProfile.LoadAsync(s_LogicFacade.ProfilePictureUrl);
        }

        private void fetchAlbumNames()
        {
            AlbumNameComboBox.Invoke(new Action(() => albumBindingSource.DataSource = s_LogicFacade.ClientAlbums));
        }

        private void fetchLastStatus()
        {
            try
            {
                TextBoxProxy textBox = new TextBoxProxy(s_LogicFacade.LastStatus, LastPostTextBox);
                textBox.AlignStatus();
            }
            catch
            {
                MessageBox.Show("fetching status failed");
            }
        }

        private void fetchFacebookContent()
        {
            new Thread(() => fillSortableAttributesComboBox(s_LogicFacade.SortableAttributes)).Start();
            new Thread(fetchLastStatus).Start();
            new Thread(fetchAlbumNames).Start();
            new Thread(fetchProfilePicture).Start();
            new Thread(fetchClosestsEvent).Start();
        }

        private void fillSortableAttributesComboBox(in string[] i_AttributesList)
        {
            foreach (string str in i_AttributesList)
            {
                sortableAttributesComboBox.Invoke(new Action(() => sortableAttributesComboBox.Items.Add(str)));
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            s_LogicFacade.AppSettings.RememberUser = checkBoxRememberMe.Checked;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            s_LogicFacade.UpdateSettings(checkBoxRememberMe.Checked);
        }

        private void sortableAttributesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = s_LogicFacade.SortableAttributes[sortableAttributesComboBox.SelectedIndex];

            new Thread(() => s_LogicFacade.Sort(result));

            myFriendsListBox.Items.Clear();

            foreach (FacebookWrapper.ObjectModel.User user in s_LogicFacade.Friends)
            {
                myFriendsListBox.Items.Add(user.FirstName + " " + user.LastName);
            }
        }
        
        private void buttonDownloadSelectedAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                folderBrowser.Description = "Select where you want the Album will be save";
                DialogResult result = folderBrowser.ShowDialog();
                s_LogicFacade.DownloadSelectedAlbum(AlbumNameComboBox.SelectedIndex, folderBrowser.SelectedPath, result == DialogResult.OK);
                MessageBox.Show("New folder created and photos saved.");
            }
            catch
            {
                MessageBox.Show("Failed to download Album to the computer");
            }

        }

        private void TextBoxPost_Leave(object sender, System.EventArgs e)
        {
            if (textBoxPost.Text.Length == 0)
            {
                textBoxPost.Text = "write your thought...";
            }
        }

        private void TextBoxPost_Enter(object sender, System.EventArgs e)
        {
            textBoxPost.Text = default;
        }

        private void TextBoxPost_TextChanged(object sender, System.EventArgs e)
        {
            if (textBoxPost.Text.Length != 0 && textBoxPost.Text != "write your thought...")
            {
                buttonFuture.Enabled = true;
                buttonPostNow.Enabled = true;
            }
            else
            {
                buttonFuture.Enabled = false;
                buttonPostNow.Enabled = false;
            }
            
        }

        private void enableButtonsAfterFetchSucceeded()
        {
            AlbumNameComboBox.Invoke(new Action(() => AlbumNameComboBox.Enabled = true));
            sortableAttributesComboBox.Invoke(new Action(() => sortableAttributesComboBox.Enabled = true));
            buttonLogout.Invoke(new Action(() => buttonLogout.Enabled = true));
            buttonDownloadSelectedAlbum.Invoke(new Action(() => buttonDownloadSelectedAlbum.Enabled = true));
            checkBoxRememberMe.Invoke(new Action(() => checkBoxRememberMe.Enabled = true));
            textBoxPost.Invoke(new Action(() => textBoxPost.Enabled = true));
        }
    }
}
