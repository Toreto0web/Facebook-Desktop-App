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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label NumOfSelectAlbumLabel;
            System.Windows.Forms.Label SelectedAlbumPicLabel;
            System.Windows.Forms.Label NextEventLocationLabel;
            System.Windows.Forms.Label NextEventNameLabel;
            System.Windows.Forms.Label NextEventstartTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SelectedAlbumTimeLabel1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelCreatePost = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPostNow = new System.Windows.Forms.Button();
            this.buttonFuture = new System.Windows.Forms.Button();
            this.GetNextEventLabel = new System.Windows.Forms.Label();
            this.AlbumNameComboBox = new System.Windows.Forms.ComboBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DowLoadAlbumLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postFuturePostButton = new System.Windows.Forms.Button();
            this.lastPostLabel = new System.Windows.Forms.Label();
            this.PostTextLabel = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sortableAttributesComboBox = new System.Windows.Forms.ComboBox();
            this.myFriendsListBox = new System.Windows.Forms.ListBox();
            this.SelectedAlbumPanel = new System.Windows.Forms.Panel();
            this.buttonDownloadSelectedAlbum = new System.Windows.Forms.Button();
            this.SelectedAlbumCountLabel = new System.Windows.Forms.Label();
            this.SelectedAlbumtimeLabel = new System.Windows.Forms.Label();
            this.SelectedAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.NextEventPanel = new System.Windows.Forms.Panel();
            this.NextEventLocationLabel1 = new System.Windows.Forms.Label();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NextEventNameLabel1 = new System.Windows.Forms.Label();
            this.NextEventstartTimeLabel1 = new System.Windows.Forms.Label();
            NumOfSelectAlbumLabel = new System.Windows.Forms.Label();
            SelectedAlbumPicLabel = new System.Windows.Forms.Label();
            NextEventLocationLabel = new System.Windows.Forms.Label();
            NextEventNameLabel = new System.Windows.Forms.Label();
            NextEventstartTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SelectedAlbumPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedAlbumPictureBox)).BeginInit();
            this.NextEventPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NumOfSelectAlbumLabel
            // 
            NumOfSelectAlbumLabel.AutoSize = true;
            NumOfSelectAlbumLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NumOfSelectAlbumLabel.ForeColor = System.Drawing.Color.White;
            NumOfSelectAlbumLabel.Location = new System.Drawing.Point(1, 0);
            NumOfSelectAlbumLabel.Name = "NumOfSelectAlbumLabel";
            NumOfSelectAlbumLabel.Size = new System.Drawing.Size(209, 30);
            NumOfSelectAlbumLabel.TabIndex = 0;
            NumOfSelectAlbumLabel.Text = "Number of photos:";
            // 
            // SelectedAlbumPicLabel
            // 
            SelectedAlbumPicLabel.AutoSize = true;
            SelectedAlbumPicLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SelectedAlbumPicLabel.ForeColor = System.Drawing.Color.White;
            SelectedAlbumPicLabel.Location = new System.Drawing.Point(1, 63);
            SelectedAlbumPicLabel.Name = "SelectedAlbumPicLabel";
            SelectedAlbumPicLabel.Size = new System.Drawing.Size(167, 30);
            SelectedAlbumPicLabel.TabIndex = 4;
            SelectedAlbumPicLabel.Text = "Album Picture:";
            // 
            // NextEventLocationLabel
            // 
            NextEventLocationLabel.AutoSize = true;
            NextEventLocationLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            NextEventLocationLabel.ForeColor = System.Drawing.Color.White;
            NextEventLocationLabel.Location = new System.Drawing.Point(-5, 63);
            NextEventLocationLabel.Name = "NextEventLocationLabel";
            NextEventLocationLabel.Size = new System.Drawing.Size(107, 30);
            NextEventLocationLabel.TabIndex = 0;
            NextEventLocationLabel.Text = "Location:";
            // 
            // NextEventNameLabel
            // 
            NextEventNameLabel.AutoSize = true;
            NextEventNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            NextEventNameLabel.ForeColor = System.Drawing.Color.White;
            NextEventNameLabel.Location = new System.Drawing.Point(-4, 0);
            NextEventNameLabel.Name = "NextEventNameLabel";
            NextEventNameLabel.Size = new System.Drawing.Size(80, 30);
            NextEventNameLabel.TabIndex = 2;
            NextEventNameLabel.Text = "Name:";
            // 
            // NextEventstartTimeLabel
            // 
            NextEventstartTimeLabel.AutoSize = true;
            NextEventstartTimeLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            NextEventstartTimeLabel.ForeColor = System.Drawing.Color.White;
            NextEventstartTimeLabel.Location = new System.Drawing.Point(-4, 36);
            NextEventstartTimeLabel.Name = "NextEventstartTimeLabel";
            NextEventstartTimeLabel.Size = new System.Drawing.Size(68, 30);
            NextEventstartTimeLabel.TabIndex = 4;
            NextEventstartTimeLabel.Text = "Date:";
            // 
            // SelectedAlbumTimeLabel1
            // 
            this.SelectedAlbumTimeLabel1.AutoSize = true;
            this.SelectedAlbumTimeLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedAlbumTimeLabel1.ForeColor = System.Drawing.Color.White;
            this.SelectedAlbumTimeLabel1.Location = new System.Drawing.Point(1, 30);
            this.SelectedAlbumTimeLabel1.Name = "SelectedAlbumTimeLabel1";
            this.SelectedAlbumTimeLabel1.Size = new System.Drawing.Size(158, 30);
            this.SelectedAlbumTimeLabel1.TabIndex = 2;
            this.SelectedAlbumTimeLabel1.Text = "Created Time:";
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
            this.labelAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold);
            this.labelAppName.ForeColor = System.Drawing.Color.White;
            this.labelAppName.Location = new System.Drawing.Point(13, 9);
            this.labelAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(416, 102);
            this.labelAppName.TabIndex = 5;
            this.labelAppName.Text = "facebook";
            // 
            // labelCreatePost
            // 
            this.labelCreatePost.AutoSize = true;
            this.labelCreatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatePost.ForeColor = System.Drawing.Color.White;
            this.labelCreatePost.Location = new System.Drawing.Point(23, 336);
            this.labelCreatePost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreatePost.Name = "labelCreatePost";
            this.labelCreatePost.Size = new System.Drawing.Size(303, 40);
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
            this.GetNextEventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetNextEventLabel.ForeColor = System.Drawing.Color.White;
            this.GetNextEventLabel.Location = new System.Drawing.Point(380, 177);
            this.GetNextEventLabel.Name = "GetNextEventLabel";
            this.GetNextEventLabel.Size = new System.Drawing.Size(365, 40);
            this.GetNextEventLabel.TabIndex = 15;
            this.GetNextEventLabel.Text = "Get Your Next Event";
            // 
            // AlbumNameComboBox
            // 
            this.AlbumNameComboBox.DataSource = this.albumBindingSource;
            this.AlbumNameComboBox.DisplayMember = "Name";
            this.AlbumNameComboBox.Enabled = false;
            this.AlbumNameComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AlbumNameComboBox.FormattingEnabled = true;
            this.AlbumNameComboBox.Location = new System.Drawing.Point(657, 386);
            this.AlbumNameComboBox.Name = "AlbumNameComboBox";
            this.AlbumNameComboBox.Size = new System.Drawing.Size(243, 40);
            this.AlbumNameComboBox.TabIndex = 19;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // DowLoadAlbumLabel
            // 
            this.DowLoadAlbumLabel.AutoSize = true;
            this.DowLoadAlbumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DowLoadAlbumLabel.ForeColor = System.Drawing.Color.White;
            this.DowLoadAlbumLabel.Location = new System.Drawing.Point(650, 336);
            this.DowLoadAlbumLabel.Name = "DowLoadAlbumLabel";
            this.DowLoadAlbumLabel.Size = new System.Drawing.Size(412, 40);
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
            this.lastPostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPostLabel.ForeColor = System.Drawing.Color.White;
            this.lastPostLabel.Location = new System.Drawing.Point(23, 177);
            this.lastPostLabel.Name = "lastPostLabel";
            this.lastPostLabel.Size = new System.Drawing.Size(288, 40);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(380, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 40);
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
            this.myFriendsListBox.Size = new System.Drawing.Size(243, 132);
            this.myFriendsListBox.TabIndex = 28;
            // 
            // SelectedAlbumPanel
            // 
            this.SelectedAlbumPanel.Controls.Add(this.buttonDownloadSelectedAlbum);
            this.SelectedAlbumPanel.Controls.Add(NumOfSelectAlbumLabel);
            this.SelectedAlbumPanel.Controls.Add(this.SelectedAlbumCountLabel);
            this.SelectedAlbumPanel.Controls.Add(this.SelectedAlbumTimeLabel1);
            this.SelectedAlbumPanel.Controls.Add(this.SelectedAlbumtimeLabel);
            this.SelectedAlbumPanel.Controls.Add(SelectedAlbumPicLabel);
            this.SelectedAlbumPanel.Controls.Add(this.SelectedAlbumPictureBox);
            this.SelectedAlbumPanel.Location = new System.Drawing.Point(657, 432);
            this.SelectedAlbumPanel.Name = "SelectedAlbumPanel";
            this.SelectedAlbumPanel.Size = new System.Drawing.Size(280, 157);
            this.SelectedAlbumPanel.TabIndex = 27;
            // 
            // buttonDownloadSelectedAlbum
            // 
            this.buttonDownloadSelectedAlbum.BackColor = System.Drawing.Color.White;
            this.buttonDownloadSelectedAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDownloadSelectedAlbum.FlatAppearance.BorderSize = 0;
            this.buttonDownloadSelectedAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadSelectedAlbum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadSelectedAlbum.Location = new System.Drawing.Point(6, 116);
            this.buttonDownloadSelectedAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDownloadSelectedAlbum.Name = "buttonDownloadSelectedAlbum";
            this.buttonDownloadSelectedAlbum.Size = new System.Drawing.Size(129, 36);
            this.buttonDownloadSelectedAlbum.TabIndex = 28;
            this.buttonDownloadSelectedAlbum.Text = "Download";
            this.buttonDownloadSelectedAlbum.UseVisualStyleBackColor = false;
            this.buttonDownloadSelectedAlbum.Click += new System.EventHandler(this.buttonDownloadSelectedAlbum_Click);
            // 
            // SelectedAlbumCountLabel
            // 
            this.SelectedAlbumCountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Count", true));
            this.SelectedAlbumCountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedAlbumCountLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedAlbumCountLabel.Location = new System.Drawing.Point(179, 2);
            this.SelectedAlbumCountLabel.Name = "SelectedAlbumCountLabel";
            this.SelectedAlbumCountLabel.Size = new System.Drawing.Size(34, 32);
            this.SelectedAlbumCountLabel.TabIndex = 1;
            this.SelectedAlbumCountLabel.Text = "0";
            // 
            // SelectedAlbumtimeLabel
            // 
            this.SelectedAlbumtimeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.SelectedAlbumtimeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedAlbumtimeLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedAlbumtimeLabel.Location = new System.Drawing.Point(147, 32);
            this.SelectedAlbumtimeLabel.Name = "SelectedAlbumtimeLabel";
            this.SelectedAlbumtimeLabel.Size = new System.Drawing.Size(100, 23);
            this.SelectedAlbumtimeLabel.TabIndex = 3;
            this.SelectedAlbumtimeLabel.Text = "date";
            // 
            // SelectedAlbumPictureBox
            // 
            this.SelectedAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageSmall", true));
            this.SelectedAlbumPictureBox.Location = new System.Drawing.Point(151, 63);
            this.SelectedAlbumPictureBox.Name = "SelectedAlbumPictureBox";
            this.SelectedAlbumPictureBox.Size = new System.Drawing.Size(92, 81);
            this.SelectedAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectedAlbumPictureBox.TabIndex = 5;
            this.SelectedAlbumPictureBox.TabStop = false;
            // 
            // NextEventPanel
            // 
            this.NextEventPanel.Controls.Add(NextEventLocationLabel);
            this.NextEventPanel.Controls.Add(this.NextEventLocationLabel1);
            this.NextEventPanel.Controls.Add(NextEventNameLabel);
            this.NextEventPanel.Controls.Add(this.NextEventNameLabel1);
            this.NextEventPanel.Controls.Add(NextEventstartTimeLabel);
            this.NextEventPanel.Controls.Add(this.NextEventstartTimeLabel1);
            this.NextEventPanel.Location = new System.Drawing.Point(386, 231);
            this.NextEventPanel.Name = "NextEventPanel";
            this.NextEventPanel.Size = new System.Drawing.Size(264, 88);
            this.NextEventPanel.TabIndex = 29;
            // 
            // NextEventLocationLabel1
            // 
            this.NextEventLocationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.NextEventLocationLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.NextEventLocationLabel1.ForeColor = System.Drawing.Color.White;
            this.NextEventLocationLabel1.Location = new System.Drawing.Point(119, 63);
            this.NextEventLocationLabel1.Name = "NextEventLocationLabel1";
            this.NextEventLocationLabel1.Size = new System.Drawing.Size(100, 23);
            this.NextEventLocationLabel1.TabIndex = 1;
            this.NextEventLocationLabel1.Text = "Location";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // NextEventNameLabel1
            // 
            this.NextEventNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.NextEventNameLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.NextEventNameLabel1.ForeColor = System.Drawing.Color.White;
            this.NextEventNameLabel1.Location = new System.Drawing.Point(119, 2);
            this.NextEventNameLabel1.Name = "NextEventNameLabel1";
            this.NextEventNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.NextEventNameLabel1.TabIndex = 3;
            this.NextEventNameLabel1.Text = "Name";
            // 
            // NextEventstartTimeLabel1
            // 
            this.NextEventstartTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "StartTime", true));
            this.NextEventstartTimeLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.NextEventstartTimeLabel1.ForeColor = System.Drawing.Color.White;
            this.NextEventstartTimeLabel1.Location = new System.Drawing.Point(119, 36);
            this.NextEventstartTimeLabel1.Name = "NextEventstartTimeLabel1";
            this.NextEventstartTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.NextEventstartTimeLabel1.TabIndex = 5;
            this.NextEventstartTimeLabel1.Text = "Date";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(86)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.NextEventPanel);
            this.Controls.Add(this.SelectedAlbumPanel);
            this.Controls.Add(this.myFriendsListBox);
            this.Controls.Add(this.sortableAttributesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.PostTextLabel);
            this.Controls.Add(this.lastPostLabel);
            this.Controls.Add(this.DowLoadAlbumLabel);
            this.Controls.Add(this.AlbumNameComboBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.SelectedAlbumPanel.ResumeLayout(false);
            this.SelectedAlbumPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedAlbumPictureBox)).EndInit();
            this.NextEventPanel.ResumeLayout(false);
            this.NextEventPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Panel SelectedAlbumPanel;
        private System.Windows.Forms.Label SelectedAlbumCountLabel;
        private System.Windows.Forms.Label SelectedAlbumtimeLabel;
        private System.Windows.Forms.PictureBox SelectedAlbumPictureBox;
        private System.Windows.Forms.Button buttonDownloadSelectedAlbum;
        private System.Windows.Forms.Label SelectedAlbumTimeLabel1;
        private System.Windows.Forms.Panel NextEventPanel;
        private System.Windows.Forms.Label NextEventLocationLabel1;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label NextEventNameLabel1;
        private System.Windows.Forms.Label NextEventstartTimeLabel1;
    }
}