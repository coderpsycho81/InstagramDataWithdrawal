
namespace InstagramAsistant
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.profilePhotoDownload = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.urlInstagram = new System.Windows.Forms.Button();
            this.urlText = new System.Windows.Forms.TextBox();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.sendLabel = new System.Windows.Forms.Label();
            this.followerLabel = new System.Windows.Forms.Label();
            this.followLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.ımageContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.profilePhotoDownload);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 484);
            this.panel1.TabIndex = 0;
            // 
            // profilePhotoDownload
            // 
            this.profilePhotoDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.profilePhotoDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePhotoDownload.Enabled = false;
            this.profilePhotoDownload.FlatAppearance.BorderSize = 0;
            this.profilePhotoDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilePhotoDownload.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.profilePhotoDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(18)))), ((int)(((byte)(53)))));
            this.profilePhotoDownload.Location = new System.Drawing.Point(2, 90);
            this.profilePhotoDownload.Name = "profilePhotoDownload";
            this.profilePhotoDownload.Size = new System.Drawing.Size(203, 45);
            this.profilePhotoDownload.TabIndex = 4;
            this.profilePhotoDownload.Text = "Profile Photo Download";
            this.profilePhotoDownload.UseVisualStyleBackColor = false;
            this.profilePhotoDownload.Click += new System.EventHandler(this.profilePhotoDownload_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 73);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(70, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instagram Asistant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODERPSYCHO";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.urlInstagram);
            this.panel2.Controls.Add(this.urlText);
            this.panel2.Location = new System.Drawing.Point(211, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 73);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Instagram User URL";
            // 
            // urlInstagram
            // 
            this.urlInstagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.urlInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urlInstagram.FlatAppearance.BorderSize = 0;
            this.urlInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urlInstagram.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.urlInstagram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(18)))), ((int)(((byte)(53)))));
            this.urlInstagram.Location = new System.Drawing.Point(497, 25);
            this.urlInstagram.Name = "urlInstagram";
            this.urlInstagram.Size = new System.Drawing.Size(76, 32);
            this.urlInstagram.TabIndex = 3;
            this.urlInstagram.Text = "URL";
            this.urlInstagram.UseVisualStyleBackColor = false;
            this.urlInstagram.Click += new System.EventHandler(this.urlInstagram_Click);
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(10, 30);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(481, 23);
            this.urlText.TabIndex = 0;
            this.urlText.Text = "https://www.instagram.com/enes_sunguc/";
            // 
            // userPicture
            // 
            this.userPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPicture.BackgroundImage")));
            this.userPicture.Location = new System.Drawing.Point(226, 94);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(128, 128);
            this.userPicture.TabIndex = 2;
            this.userPicture.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.usernameLabel.Location = new System.Drawing.Point(379, 94);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(83, 20);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // sendLabel
            // 
            this.sendLabel.AutoSize = true;
            this.sendLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.sendLabel.Location = new System.Drawing.Point(379, 132);
            this.sendLabel.Name = "sendLabel";
            this.sendLabel.Size = new System.Drawing.Size(57, 20);
            this.sendLabel.TabIndex = 3;
            this.sendLabel.Text = "0 Send";
            // 
            // followerLabel
            // 
            this.followerLabel.AutoSize = true;
            this.followerLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.followerLabel.Location = new System.Drawing.Point(487, 132);
            this.followerLabel.Name = "followerLabel";
            this.followerLabel.Size = new System.Drawing.Size(83, 20);
            this.followerLabel.TabIndex = 4;
            this.followerLabel.Text = "0 Follower";
            // 
            // followLabel
            // 
            this.followLabel.AutoSize = true;
            this.followLabel.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.followLabel.Location = new System.Drawing.Point(620, 132);
            this.followLabel.Name = "followLabel";
            this.followLabel.Size = new System.Drawing.Size(68, 20);
            this.followLabel.TabIndex = 5;
            this.followLabel.Text = "0 Follow";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.nameLabel.Location = new System.Drawing.Point(379, 172);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 19);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.explanationLabel.Location = new System.Drawing.Point(379, 201);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(92, 19);
            this.explanationLabel.TabIndex = 7;
            this.explanationLabel.Text = "Explanation";
            // 
            // ımageContainer
            // 
            this.ımageContainer.Location = new System.Drawing.Point(214, 248);
            this.ımageContainer.Name = "ımageContainer";
            this.ımageContainer.Size = new System.Drawing.Size(577, 222);
            this.ımageContainer.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 482);
            this.Controls.Add(this.ımageContainer);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.followLabel);
            this.Controls.Add(this.followerLabel);
            this.Controls.Add(this.sendLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(808, 521);
            this.MinimumSize = new System.Drawing.Size(808, 521);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button urlInstagram;
        private System.Windows.Forms.Button profilePhotoDownload;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.Label followerLabel;
        private System.Windows.Forms.Label followLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.Panel ımageContainer;
    }
}

