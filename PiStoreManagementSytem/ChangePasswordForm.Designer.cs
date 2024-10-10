namespace PiStoreManagementSytem
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            lblCurrentPassword = new Label();
            lblNewPassword = new Label();
            lblConfirmNewPassword = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmNewPassword = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMsg = new Label();
            exitBtn = new PictureBox();
            showCurPassBtn = new PictureBox();
            showNewPassBtn = new PictureBox();
            showConfirmPassBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)exitBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showCurPassBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showNewPassBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showConfirmPassBtn).BeginInit();
            SuspendLayout();
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Rockwell", 10.2F);
            lblCurrentPassword.Location = new Point(52, 227);
            lblCurrentPassword.Margin = new Padding(4, 0, 4, 0);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(150, 20);
            lblCurrentPassword.TabIndex = 0;
            lblCurrentPassword.Text = "Current Password";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Rockwell", 10.2F);
            lblNewPassword.Location = new Point(52, 319);
            lblNewPassword.Margin = new Padding(4, 0, 4, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(123, 20);
            lblNewPassword.TabIndex = 1;
            lblNewPassword.Text = "New Password";
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Font = new Font("Rockwell", 10.2F);
            lblConfirmNewPassword.Location = new Point(52, 419);
            lblConfirmNewPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(192, 20);
            lblConfirmNewPassword.TabIndex = 2;
            lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BackColor = Color.FromArgb(250, 250, 250);
            txtCurrentPassword.Font = new Font("Rockwell", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.ForeColor = Color.Gray;
            txtCurrentPassword.Location = new Point(52, 252);
            txtCurrentPassword.Margin = new Padding(4, 5, 4, 5);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(362, 23);
            txtCurrentPassword.TabIndex = 3;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(250, 250, 250);
            txtNewPassword.Font = new Font("Rockwell", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.Gray;
            txtNewPassword.Location = new Point(52, 344);
            txtNewPassword.Margin = new Padding(4, 5, 4, 5);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(362, 23);
            txtNewPassword.TabIndex = 4;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.BackColor = Color.FromArgb(250, 250, 250);
            txtConfirmNewPassword.Font = new Font("Rockwell", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmNewPassword.ForeColor = Color.Gray;
            txtConfirmNewPassword.Location = new Point(52, 444);
            txtConfirmNewPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(362, 23);
            txtConfirmNewPassword.TabIndex = 5;
            txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 155, 50);
            btnSave.Font = new Font("Rockwell", 10.2F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(52, 504);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(397, 54);
            btnSave.TabIndex = 6;
            btnSave.Text = "CHANGE PASSWORD";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 106);
            label1.Name = "label1";
            label1.Size = new Size(333, 33);
            label1.TabIndex = 8;
            label1.Text = "Change your password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(52, 156);
            label2.Name = "label2";
            label2.Size = new Size(378, 24);
            label2.TabIndex = 9;
            label2.Text = "Enter a new password below to change your password";
            // 
            // txtMsg
            // 
            txtMsg.BackColor = Color.FromArgb(192, 255, 192);
            txtMsg.Font = new Font("Rockwell Condensed", 12F);
            txtMsg.ForeColor = Color.Green;
            txtMsg.Location = new Point(52, 156);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(397, 46);
            txtMsg.TabIndex = 10;
            txtMsg.Text = "Password change successful";
            txtMsg.TextAlign = ContentAlignment.MiddleCenter;
            txtMsg.Visible = false;
            // 
            // exitBtn
            // 
            exitBtn.BackgroundImage = (Image)resources.GetObject("exitBtn.BackgroundImage");
            exitBtn.BackgroundImageLayout = ImageLayout.Zoom;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(446, 12);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(32, 32);
            exitBtn.TabIndex = 11;
            exitBtn.TabStop = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // showCurPassBtn
            // 
            showCurPassBtn.BackgroundImage = Properties.Resources.eye_gray_hidden;
            showCurPassBtn.BackgroundImageLayout = ImageLayout.Zoom;
            showCurPassBtn.Cursor = Cursors.Hand;
            showCurPassBtn.Location = new Point(425, 252);
            showCurPassBtn.Name = "showCurPassBtn";
            showCurPassBtn.Size = new Size(24, 24);
            showCurPassBtn.TabIndex = 13;
            showCurPassBtn.TabStop = false;
            showCurPassBtn.Click += showCurPassBtn_Click;
            // 
            // showNewPassBtn
            // 
            showNewPassBtn.BackgroundImage = Properties.Resources.eye_gray_hidden;
            showNewPassBtn.BackgroundImageLayout = ImageLayout.Zoom;
            showNewPassBtn.Cursor = Cursors.Hand;
            showNewPassBtn.Location = new Point(425, 343);
            showNewPassBtn.Name = "showNewPassBtn";
            showNewPassBtn.Size = new Size(24, 24);
            showNewPassBtn.TabIndex = 14;
            showNewPassBtn.TabStop = false;
            showNewPassBtn.Click += showNewPassBtn_Click;
            // 
            // showConfirmPassBtn
            // 
            showConfirmPassBtn.BackgroundImage = Properties.Resources.eye_gray_hidden;
            showConfirmPassBtn.BackgroundImageLayout = ImageLayout.Zoom;
            showConfirmPassBtn.Cursor = Cursors.Hand;
            showConfirmPassBtn.Location = new Point(425, 443);
            showConfirmPassBtn.Name = "showConfirmPassBtn";
            showConfirmPassBtn.Size = new Size(24, 24);
            showConfirmPassBtn.TabIndex = 15;
            showConfirmPassBtn.TabStop = false;
            showConfirmPassBtn.Click += showConfirmPassBtn_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(490, 588);
            Controls.Add(showConfirmPassBtn);
            Controls.Add(showNewPassBtn);
            Controls.Add(showCurPassBtn);
            Controls.Add(exitBtn);
            Controls.Add(txtMsg);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblConfirmNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblCurrentPassword);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            Load += ChangePasswordForm_Load;
            MouseDown += DragApplication;
            ((System.ComponentModel.ISupportInitialize)exitBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)showCurPassBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)showNewPassBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)showConfirmPassBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Button btnSave;
        private Label label1;
        private Label label2;
        private Label txtMsg;
        private PictureBox exitBtn;
        private PictureBox showCurPassBtn;
        private PictureBox showNewPassBtn;
        private PictureBox showConfirmPassBtn;
    }
}