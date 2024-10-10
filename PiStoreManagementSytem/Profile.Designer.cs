namespace PiStoreManagementSytem
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label hireDateLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label titleLabel;
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            avatarPictureBox = new PictureBox();
            titleLabel = new Label();
            nameLabel = new Label();
            hireDateLabel = new Label();
            addressLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            panel1 = new Panel();
            label1 = new Label();
            creditLabel = new Label();
            lblName = new Label();
            lblHireDate = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            exitBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitBtn).BeginInit();
            SuspendLayout();
            // 
            // avatarPictureBox
            // 
            avatarPictureBox.BackgroundImage = (Image)resources.GetObject("avatarPictureBox.BackgroundImage");
            avatarPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            avatarPictureBox.Location = new Point(37, 86);
            avatarPictureBox.Name = "avatarPictureBox";
            avatarPictureBox.Size = new Size(126, 126);
            avatarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            avatarPictureBox.TabIndex = 0;
            avatarPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(69, 123, 157);
            titleLabel.Location = new Point(317, 35);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(216, 38);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Profile Detail";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Rockwell Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(247, 120);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(41, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // hireDateLabel
            // 
            hireDateLabel.AutoSize = true;
            hireDateLabel.Font = new Font("Rockwell Condensed", 10.2F);
            hireDateLabel.Location = new Point(247, 156);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new Size(64, 20);
            hireDateLabel.TabIndex = 3;
            hireDateLabel.Text = "Hire Date:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Rockwell Condensed", 10.2F);
            addressLabel.Location = new Point(247, 264);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(53, 20);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Rockwell Condensed", 10.2F);
            emailLabel.Location = new Point(247, 228);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(41, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Rockwell Condensed", 10.2F);
            phoneLabel.Location = new Point(247, 192);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(44, 20);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Phone:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(69, 123, 157);
            panel1.Location = new Point(198, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 430);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(69, 123, 157);
            label1.Location = new Point(47, 231);
            label1.Name = "label1";
            label1.Size = new Size(107, 24);
            label1.TabIndex = 8;
            label1.Text = "Employee";
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.Font = new Font("Rockwell", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creditLabel.ForeColor = SystemColors.ControlDarkDark;
            creditLabel.Location = new Point(276, 355);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new Size(298, 16);
            creditLabel.TabIndex = 14;
            creditLabel.Text = "Pi Store Management System v1.0 by Mai Gia Minh";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(336, 120);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 15;
            lblName.Text = "label2";
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Location = new Point(336, 156);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(50, 20);
            lblHireDate.TabIndex = 16;
            lblHireDate.Text = "label2";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(336, 192);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 17;
            lblPhone.Text = "label2";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(336, 228);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "label2";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(336, 264);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(50, 20);
            lblAddress.TabIndex = 19;
            lblAddress.Text = "label2";
            // 
            // exitBtn
            // 
            exitBtn.BackgroundImage = (Image)resources.GetObject("exitBtn.BackgroundImage");
            exitBtn.BackgroundImageLayout = ImageLayout.Zoom;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(577, 12);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(32, 32);
            exitBtn.TabIndex = 20;
            exitBtn.TabStop = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // Profile
            // 
            BackColor = Color.White;
            ClientSize = new Size(621, 394);
            Controls.Add(exitBtn);
            Controls.Add(lblAddress);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblHireDate);
            Controls.Add(lblName);
            Controls.Add(creditLabel);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(avatarPictureBox);
            Controls.Add(titleLabel);
            Controls.Add(nameLabel);
            Controls.Add(hireDateLabel);
            Controls.Add(addressLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            Paint += Profile_Paint;
            MouseDown += DragApplication;
            ((System.ComponentModel.ISupportInitialize)avatarPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label creditLabel;
        private Label lblName;
        private Label lblHireDate;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private PictureBox exitBtn;
    }
}