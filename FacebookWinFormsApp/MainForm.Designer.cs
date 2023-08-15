
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
            this.buttonDownloadPhotos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(14, 89);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(84, 44);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(116, 89);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(84, 44);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(799, 11);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(225, 250);
            this.pictureBoxProfile.TabIndex = 3;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAppName.ForeColor = System.Drawing.Color.White;
            this.labelAppName.Location = new System.Drawing.Point(4, 11);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(570, 58);
            this.labelAppName.TabIndex = 5;
            this.labelAppName.Text = "FaceBook Desktop App";
            // 
            // labelCreatePost
            // 
            this.labelCreatePost.AutoSize = true;
            this.labelCreatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCreatePost.ForeColor = System.Drawing.Color.White;
            this.labelCreatePost.Location = new System.Drawing.Point(20, 174);
            this.labelCreatePost.Name = "labelCreatePost";
            this.labelCreatePost.Size = new System.Drawing.Size(348, 46);
            this.labelCreatePost.TabIndex = 6;
            this.labelCreatePost.Text = "Create your Post!";
            this.labelCreatePost.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(19, 226);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(335, 158);
            this.textBoxPost.TabIndex = 7;
            this.textBoxPost.Text = "write your thought...";
            // 
            // buttonPostNow
            // 
            this.buttonPostNow.BackColor = System.Drawing.Color.White;
            this.buttonPostNow.FlatAppearance.BorderSize = 0;
            this.buttonPostNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostNow.Location = new System.Drawing.Point(19, 392);
            this.buttonPostNow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPostNow.Name = "buttonPostNow";
            this.buttonPostNow.Size = new System.Drawing.Size(161, 60);
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
            this.buttonFuture.Location = new System.Drawing.Point(189, 392);
            this.buttonFuture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFuture.Name = "buttonFuture";
            this.buttonFuture.Size = new System.Drawing.Size(165, 60);
            this.buttonFuture.TabIndex = 9;
            this.buttonFuture.Text = "Schedule for later!";
            this.buttonFuture.UseVisualStyleBackColor = false;
            // 
            // buttonDownloadPhotos
            // 
            this.buttonDownloadPhotos.BackColor = System.Drawing.Color.White;
            this.buttonDownloadPhotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDownloadPhotos.FlatAppearance.BorderSize = 0;
            this.buttonDownloadPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadPhotos.Location = new System.Drawing.Point(799, 269);
            this.buttonDownloadPhotos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDownloadPhotos.Name = "buttonDownloadPhotos";
            this.buttonDownloadPhotos.Size = new System.Drawing.Size(225, 72);
            this.buttonDownloadPhotos.TabIndex = 12;
            this.buttonDownloadPhotos.Text = "Download your FaceBook Albums!";
            this.buttonDownloadPhotos.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(86)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1037, 794);
            this.Controls.Add(this.buttonDownloadPhotos);
            this.Controls.Add(this.buttonFuture);
            this.Controls.Add(this.buttonPostNow);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.labelCreatePost);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "FaceBook Desktop App";
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
        private System.Windows.Forms.Button buttonDownloadPhotos;
    }
}