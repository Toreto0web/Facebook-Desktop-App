
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
            // button1
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(12, 71);
            this.buttonLogin.Name = "button1";
            this.buttonLogin.Size = new System.Drawing.Size(75, 35);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(103, 71);
            this.buttonLogout.Name = "button2";
            this.buttonLogout.Size = new System.Drawing.Size(75, 35);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(710, 9);
            this.pictureBoxProfile.Name = "pictureBox1";
            this.pictureBoxProfile.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxProfile.TabIndex = 3;
            this.pictureBoxProfile.TabStop = false;
            // 
            // label1
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAppName.ForeColor = System.Drawing.Color.White;
            this.labelAppName.Location = new System.Drawing.Point(4, 9);
            this.labelAppName.Name = "label1";
            this.labelAppName.Size = new System.Drawing.Size(477, 48);
            this.labelAppName.TabIndex = 5;
            this.labelAppName.Text = "FaceBook Desktop App";
            // 
            // label2
            // 
            this.labelCreatePost.AutoSize = true;
            this.labelCreatePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCreatePost.ForeColor = System.Drawing.Color.White;
            this.labelCreatePost.Location = new System.Drawing.Point(18, 139);
            this.labelCreatePost.Name = "label2";
            this.labelCreatePost.Size = new System.Drawing.Size(297, 39);
            this.labelCreatePost.TabIndex = 6;
            this.labelCreatePost.Text = "Create your Post!";
            this.labelCreatePost.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBoxPost.Location = new System.Drawing.Point(17, 181);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBox1";
            this.textBoxPost.Size = new System.Drawing.Size(298, 127);
            this.textBoxPost.TabIndex = 7;
            this.textBoxPost.Text = "write your thought...";
            // 
            // button3
            // 
            this.buttonPostNow.BackColor = System.Drawing.Color.White;
            this.buttonPostNow.FlatAppearance.BorderSize = 0;
            this.buttonPostNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostNow.Location = new System.Drawing.Point(17, 314);
            this.buttonPostNow.Name = "button3";
            this.buttonPostNow.Size = new System.Drawing.Size(143, 48);
            this.buttonPostNow.TabIndex = 8;
            this.buttonPostNow.Text = "Post Now!";
            this.buttonPostNow.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.buttonFuture.BackColor = System.Drawing.Color.White;
            this.buttonFuture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFuture.FlatAppearance.BorderSize = 0;
            this.buttonFuture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFuture.Location = new System.Drawing.Point(168, 314);
            this.buttonFuture.Name = "button4";
            this.buttonFuture.Size = new System.Drawing.Size(147, 48);
            this.buttonFuture.TabIndex = 9;
            this.buttonFuture.Text = "Schedule for later!";
            this.buttonFuture.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.buttonDownloadPhotos.BackColor = System.Drawing.Color.White;
            this.buttonDownloadPhotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDownloadPhotos.FlatAppearance.BorderSize = 0;
            this.buttonDownloadPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadPhotos.Location = new System.Drawing.Point(710, 215);
            this.buttonDownloadPhotos.Name = "button5";
            this.buttonDownloadPhotos.Size = new System.Drawing.Size(200, 58);
            this.buttonDownloadPhotos.TabIndex = 12;
            this.buttonDownloadPhotos.Text = "Download your FaceBook Albums!";
            this.buttonDownloadPhotos.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(86)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(922, 635);
            this.Controls.Add(this.buttonDownloadPhotos);
            this.Controls.Add(this.buttonFuture);
            this.Controls.Add(this.buttonPostNow);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.labelCreatePost);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDownloadPhotos;
    }
}