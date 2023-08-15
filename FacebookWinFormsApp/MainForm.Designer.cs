
namespace FacebookDApp
{
    partial class MainForm
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Klavika Bd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(22, 115);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(112, 57);
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
            this.buttonLogout.Font = new System.Drawing.Font("Klavika Bd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(178, 115);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(112, 57);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(1127, 15);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(238, 273);
            this.pictureBoxProfile.TabIndex = 3;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Klavika Bd", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppName.ForeColor = System.Drawing.Color.White;
            this.labelAppName.Location = new System.Drawing.Point(6, 15);
            this.labelAppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(364, 95);
            this.labelAppName.TabIndex = 5;
            this.labelAppName.Text = "facebook";
            // 
            // labelCreatePost
            // 
            this.labelCreatePost.AutoSize = true;
            this.labelCreatePost.Font = new System.Drawing.Font("Klavika Bd", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatePost.ForeColor = System.Drawing.Color.White;
            this.labelCreatePost.Location = new System.Drawing.Point(16, 233);
            this.labelCreatePost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreatePost.Name = "labelCreatePost";
            this.labelCreatePost.Size = new System.Drawing.Size(310, 47);
            this.labelCreatePost.TabIndex = 6;
            this.labelCreatePost.Text = "Create your Post";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(26, 294);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(445, 204);
            this.textBoxPost.TabIndex = 7;
            this.textBoxPost.Text = "write your thought...";
            // 
            // buttonPostNow
            // 
            this.buttonPostNow.BackColor = System.Drawing.Color.White;
            this.buttonPostNow.FlatAppearance.BorderSize = 0;
            this.buttonPostNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostNow.Location = new System.Drawing.Point(26, 509);
            this.buttonPostNow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPostNow.Name = "buttonPostNow";
            this.buttonPostNow.Size = new System.Drawing.Size(214, 78);
            this.buttonPostNow.TabIndex = 8;
            this.buttonPostNow.Text = "Post Now!";
            this.buttonPostNow.UseVisualStyleBackColor = false;
            // 
            // buttonFuture
            // 
            this.buttonFuture.BackColor = System.Drawing.Color.White;
            this.buttonFuture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFuture.FlatAppearance.BorderSize = 0;
            this.buttonFuture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFuture.Location = new System.Drawing.Point(252, 509);
            this.buttonFuture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFuture.Name = "buttonFuture";
            this.buttonFuture.Size = new System.Drawing.Size(220, 78);
            this.buttonFuture.TabIndex = 9;
            this.buttonFuture.Text = "Schedule for later!";
            this.buttonFuture.UseVisualStyleBackColor = false;
            // 
            // GetNextEventLabel
            // 
            this.GetNextEventLabel.AutoSize = true;
            this.GetNextEventLabel.Font = new System.Drawing.Font("Klavika Bd", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetNextEventLabel.ForeColor = System.Drawing.Color.White;
            this.GetNextEventLabel.Location = new System.Drawing.Point(523, 27);
            this.GetNextEventLabel.Name = "GetNextEventLabel";
            this.GetNextEventLabel.Size = new System.Drawing.Size(305, 38);
            this.GetNextEventLabel.TabIndex = 15;
            this.GetNextEventLabel.Text = "Get Your Next Event";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Enabled = false;
            this.RefreshButton.Font = new System.Drawing.Font("Klavika Bd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(923, 27);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(117, 39);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Refresh!";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // EventNameLabel
            // 
            this.EventNameLabel.AutoSize = true;
            this.EventNameLabel.Font = new System.Drawing.Font("Klavika Bd", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventNameLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.EventNameLabel.Location = new System.Drawing.Point(523, 105);
            this.EventNameLabel.Name = "EventNameLabel";
            this.EventNameLabel.Size = new System.Drawing.Size(98, 38);
            this.EventNameLabel.TabIndex = 17;
            this.EventNameLabel.Text = "name";
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.AutoSize = true;
            this.EventDateLabel.Font = new System.Drawing.Font("Klavika Bd", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDateLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.EventDateLabel.Location = new System.Drawing.Point(702, 105);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(124, 38);
            this.EventDateLabel.TabIndex = 18;
            this.EventDateLabel.Text = "dd/mm";
            // 
            // AlbumNameComboBox
            // 
            this.AlbumNameComboBox.Enabled = false;
            this.AlbumNameComboBox.Font = new System.Drawing.Font("Klavika Lt", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumNameComboBox.FormattingEnabled = true;
            this.AlbumNameComboBox.Location = new System.Drawing.Point(1101, 355);
            this.AlbumNameComboBox.Name = "AlbumNameComboBox";
            this.AlbumNameComboBox.Size = new System.Drawing.Size(244, 27);
            this.AlbumNameComboBox.TabIndex = 19;
            this.AlbumNameComboBox.Text = "SelectAlbum";
            this.AlbumNameComboBox.SelectedIndexChanged += new System.EventHandler(this.dowLoadAlbumLabel_SelectedIndexChanged);
            // 
            // DowLoadAlbumLabel
            // 
            this.DowLoadAlbumLabel.AutoSize = true;
            this.DowLoadAlbumLabel.Font = new System.Drawing.Font("Klavika Bd", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DowLoadAlbumLabel.ForeColor = System.Drawing.Color.White;
            this.DowLoadAlbumLabel.Location = new System.Drawing.Point(1096, 324);
            this.DowLoadAlbumLabel.Name = "DowLoadAlbumLabel";
            this.DowLoadAlbumLabel.Size = new System.Drawing.Size(257, 28);
            this.DowLoadAlbumLabel.TabIndex = 20;
            this.DowLoadAlbumLabel.Text = "Download Your Albums";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(86)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1383, 1025);
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
            this.Font = new System.Drawing.Font("Klavika Bd", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}