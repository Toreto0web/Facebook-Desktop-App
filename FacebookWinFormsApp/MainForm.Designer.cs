namespace FacebookDApp
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelCreatePost = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPostNow = new System.Windows.Forms.Button();
            this.buttonFuture = new System.Windows.Forms.Button();
            this.GetNextEventLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.EventNameLabel = new System.Windows.Forms.Label();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.AlbumNameComboBox = new System.Windows.Forms.ComboBox();
            this.DowLoadAlbumLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postFuturePostButton = new System.Windows.Forms.Button();
            this.lastPostLabel = new System.Windows.Forms.Label();
            this.PostTextLabel = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sortableAttributesComboBox = new System.Windows.Forms.ComboBox();
            this.myFriendsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(34, 82);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(82, 40);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(124, 82);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(82, 40);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.BackgroundImage")));
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(703, 14);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(234, 234);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 3;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Klavika Bd", 45F, System.Drawing.FontStyle.Bold);
            this.labelAppName.ForeColor = System.Drawing.Color.White;
            this.labelAppName.Location = new System.Drawing.Point(13, 9);
            this.labelAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(390, 101);
            this.labelAppName.TabIndex = 5;
            this.labelAppName.Text = "facebook";
            // 
            // labelCreatePost
            // 
            this.labelCreatePost.AutoSize = true;
            this.labelCreatePost.Font = new System.Drawing.Font("Klavika Bd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatePost.ForeColor = System.Drawing.Color.White;
            this.labelCreatePost.Location = new System.Drawing.Point(23, 336);
            this.labelCreatePost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreatePost.Name = "labelCreatePost";
            this.labelCreatePost.Size = new System.Drawing.Size(268, 41);
            this.labelCreatePost.TabIndex = 6;
            this.labelCreatePost.Text = "Create your Post";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPost.Location = new System.Drawing.Point(30, 386);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(332, 152);
            this.textBoxPost.TabIndex = 7;
            this.textBoxPost.Text = "write your thought...";
            // 
            // buttonPostNow
            // 
            this.buttonPostNow.BackColor = System.Drawing.Color.White;
            this.buttonPostNow.FlatAppearance.BorderSize = 0;
            this.buttonPostNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostNow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonPostNow.Location = new System.Drawing.Point(30, 548);
            this.buttonPostNow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPostNow.Name = "buttonPostNow";
            this.buttonPostNow.Size = new System.Drawing.Size(164, 35);
            this.buttonPostNow.TabIndex = 8;
            this.buttonPostNow.Text = "Post Now!";
            this.buttonPostNow.UseVisualStyleBackColor = false;
            this.buttonPostNow.Click += new System.EventHandler(this.buttonPostNow_Click);
            // 
            // buttonFuture
            // 
            this.buttonFuture.BackColor = System.Drawing.Color.White;
            this.buttonFuture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFuture.FlatAppearance.BorderSize = 0;
            this.buttonFuture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFuture.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonFuture.Location = new System.Drawing.Point(202, 548);
            this.buttonFuture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFuture.Name = "buttonFuture";
            this.buttonFuture.Size = new System.Drawing.Size(160, 35);
            this.buttonFuture.TabIndex = 9;
            this.buttonFuture.Text = "Schedule for later!";
            this.buttonFuture.UseVisualStyleBackColor = false;
            this.buttonFuture.Click += new System.EventHandler(this.buttonFuture_Click);
            // 
            // GetNextEventLabel
            // 
            this.GetNextEventLabel.AutoSize = true;
            this.GetNextEventLabel.Font = new System.Drawing.Font("Klavika Bd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetNextEventLabel.ForeColor = System.Drawing.Color.White;
            this.GetNextEventLabel.Location = new System.Drawing.Point(380, 177);
            this.GetNextEventLabel.Name = "GetNextEventLabel";
            this.GetNextEventLabel.Size = new System.Drawing.Size(321, 41);
            this.GetNextEventLabel.TabIndex = 15;
            this.GetNextEventLabel.Text = "Get Your Next Event";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.White;
            this.RefreshButton.Enabled = false;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RefreshButton.Location = new System.Drawing.Point(426, 261);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(117, 29);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Refresh!";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.AutoSize = true;
            this.EventNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNameLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.EventNameLabel.Location = new System.Drawing.Point(380, 218);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(94, 40);
            this.EventNameLabel.TabIndex = 17;
            this.EventNameLabel.Text = "name";
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.AutoSize = true;
            this.EventDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDateLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.EventDateLabel.Location = new System.Drawing.Point(480, 218);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(120, 40);
            this.EventDateLabel.TabIndex = 18;
            this.EventDateLabel.Text = "dd/mm";
            // 
            // AlbumNameComboBox
            // 
            this.AlbumNameComboBox.Enabled = false;
            this.AlbumNameComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AlbumNameComboBox.FormattingEnabled = true;
            this.AlbumNameComboBox.Location = new System.Drawing.Point(657, 386);
            this.AlbumNameComboBox.Name = "AlbumNameComboBox";
            this.AlbumNameComboBox.Size = new System.Drawing.Size(243, 40);
            this.AlbumNameComboBox.TabIndex = 19;
            this.AlbumNameComboBox.Text = "Select Album";
            this.AlbumNameComboBox.SelectedIndexChanged += new System.EventHandler(this.dowLoadAlbumLabel_SelectedIndexChanged);
            // 
            // DowLoadAlbumLabel
            // 
            this.DowLoadAlbumLabel.AutoSize = true;
            this.DowLoadAlbumLabel.Font = new System.Drawing.Font("Klavika Bd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DowLoadAlbumLabel.ForeColor = System.Drawing.Color.White;
            this.DowLoadAlbumLabel.Location = new System.Drawing.Point(650, 336);
            this.DowLoadAlbumLabel.Name = "DowLoadAlbumLabel";
            this.DowLoadAlbumLabel.Size = new System.Drawing.Size(373, 41);
            this.DowLoadAlbumLabel.TabIndex = 20;
            this.DowLoadAlbumLabel.Text = "Download Your Albums";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(30, 591);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(187, 39);
            this.dateTimePicker.TabIndex = 21;
            // 
            // postFuturePostButton
            // 
            this.postFuturePostButton.BackColor = System.Drawing.Color.White;
            this.postFuturePostButton.FlatAppearance.BorderSize = 0;
            this.postFuturePostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postFuturePostButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.postFuturePostButton.Location = new System.Drawing.Point(219, 591);
            this.postFuturePostButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.postFuturePostButton.Name = "postFuturePostButton";
            this.postFuturePostButton.Size = new System.Drawing.Size(143, 28);
            this.postFuturePostButton.TabIndex = 22;
            this.postFuturePostButton.Text = "Future Post";
            this.postFuturePostButton.UseVisualStyleBackColor = false;
            // 
            // lastPostLabel
            // 
            this.lastPostLabel.AutoSize = true;
            this.lastPostLabel.Font = new System.Drawing.Font("Klavika Bd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPostLabel.ForeColor = System.Drawing.Color.White;
            this.lastPostLabel.Location = new System.Drawing.Point(23, 177);
            this.lastPostLabel.Name = "lastPostLabel";
            this.lastPostLabel.Size = new System.Drawing.Size(255, 41);
            this.lastPostLabel.TabIndex = 21;
            this.lastPostLabel.Text = "Your Last Post: ";
            // 
            // PostTextLabel
            // 
            this.PostTextLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostTextLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.PostTextLabel.Location = new System.Drawing.Point(30, 231);
            this.PostTextLabel.Multiline = true;
            this.PostTextLabel.Name = "PostTextLabel";
            this.PostTextLabel.ReadOnly = true;
            this.PostTextLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PostTextLabel.Size = new System.Drawing.Size(323, 89);
            this.PostTextLabel.TabIndex = 22;
            this.PostTextLabel.Text = "Post text";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox.ForeColor = System.Drawing.Color.White;
            this.checkBox.Location = new System.Drawing.Point(37, 130);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(245, 44);
            this.checkBox.TabIndex = 23;
            this.checkBox.Text = "Remember Me";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Klavika Bd", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(380, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 41);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sort Friends By";
            // 
            // sortableAttributesComboBox
            // 
            this.sortableAttributesComboBox.Enabled = false;
            this.sortableAttributesComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sortableAttributesComboBox.FormattingEnabled = true;
            this.sortableAttributesComboBox.Location = new System.Drawing.Point(387, 386);
            this.sortableAttributesComboBox.Name = "sortableAttributesComboBox";
            this.sortableAttributesComboBox.Size = new System.Drawing.Size(243, 40);
            this.sortableAttributesComboBox.TabIndex = 25;
            this.sortableAttributesComboBox.Text = "Select Parameter";
            this.sortableAttributesComboBox.SelectedIndexChanged += new System.EventHandler(this.sortableAttributesComboBox_SelectedIndexChanged);
            // 
            // myFriendsListBox
            // 
            this.myFriendsListBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.myFriendsListBox.FormattingEnabled = true;
            this.myFriendsListBox.ItemHeight = 32;
            this.myFriendsListBox.Location = new System.Drawing.Point(387, 432);
            this.myFriendsListBox.Name = "myFriendsListBox";
            this.myFriendsListBox.Size = new System.Drawing.Size(243, 100);
            this.myFriendsListBox.TabIndex = 26;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(86)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(950, 640);
            this.Controls.Add(this.myFriendsListBox);
            this.Controls.Add(this.sortableAttributesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.PostTextLabel);
            this.Controls.Add(this.lastPostLabel);
            this.Controls.Add(this.DowLoadAlbumLabel);
            this.Controls.Add(this.AlbumNameComboBox);
            this.Controls.Add(this.EventDateLabel);
            this.Controls.Add(this.EventNameLabel);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.GetNextEventLabel);
            this.Controls.Add(this.buttonFuture);
            this.Controls.Add(this.buttonPostNow);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.labelCreatePost);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "facebook Desktop App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelCreatePost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonPostNow;
        private System.Windows.Forms.Button buttonFuture;
        private System.Windows.Forms.Label GetNextEventLabel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label EventNameLabel;
        private System.Windows.Forms.Label EventDateLabel;
        private System.Windows.Forms.ComboBox AlbumNameComboBox;
        private System.Windows.Forms.Label DowLoadAlbumLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button postFuturePostButton;
        private System.Windows.Forms.Label lastPostLabel;
        private System.Windows.Forms.TextBox PostTextLabel;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sortableAttributesComboBox;
        private System.Windows.Forms.ListBox myFriendsListBox;
    }
}