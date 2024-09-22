namespace PiStoreManagementSytem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel2 = new Panel();
            panel1 = new Panel();
            creditLabel = new Label();
            showPassBtn = new PictureBox();
            passwordTxt = new TextBox();
            emailTxt = new TextBox();
            exitBtn = new PictureBox();
            resetPassBtn = new Label();
            loginBtn = new Button();
            panel4 = new Panel();
            lockImg = new PictureBox();
            panel3 = new Panel();
            userImg = new PictureBox();
            loginLb = new Label();
            logoImg = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showPassBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lockImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoImg).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 754);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(creditLabel);
            panel1.Controls.Add(showPassBtn);
            panel1.Controls.Add(passwordTxt);
            panel1.Controls.Add(emailTxt);
            panel1.Controls.Add(exitBtn);
            panel1.Controls.Add(resetPassBtn);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(lockImg);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(userImg);
            panel1.Controls.Add(loginLb);
            panel1.Controls.Add(logoImg);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 754);
            panel1.TabIndex = 2;
            panel1.MouseDown += DragApplication;
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.Font = new Font("Rockwell", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creditLabel.ForeColor = SystemColors.ControlDarkDark;
            creditLabel.Location = new Point(92, 715);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new Size(298, 16);
            creditLabel.TabIndex = 13;
            creditLabel.Text = "Pi Store Management System v1.0 by Mai Gia Minh";
            // 
            // showPassBtn
            // 
            showPassBtn.BackgroundImage = Properties.Resources.hidden;
            showPassBtn.BackgroundImageLayout = ImageLayout.Zoom;
            showPassBtn.Cursor = Cursors.Hand;
            showPassBtn.Location = new Point(408, 489);
            showPassBtn.Name = "showPassBtn";
            showPassBtn.Size = new Size(24, 24);
            showPassBtn.TabIndex = 12;
            showPassBtn.TabStop = false;
            showPassBtn.Click += showPassBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.Font = new Font("Rockwell", 12F);
            passwordTxt.ForeColor = Color.FromArgb(69, 123, 157);
            passwordTxt.Location = new Point(87, 489);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(345, 24);
            passwordTxt.TabIndex = 11;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // emailTxt
            // 
            emailTxt.BorderStyle = BorderStyle.None;
            emailTxt.Font = new Font("Rockwell", 12F);
            emailTxt.ForeColor = Color.FromArgb(69, 123, 157);
            emailTxt.Location = new Point(87, 409);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(345, 24);
            emailTxt.TabIndex = 10;
            // 
            // exitBtn
            // 
            exitBtn.BackgroundImage = (Image)resources.GetObject("exitBtn.BackgroundImage");
            exitBtn.BackgroundImageLayout = ImageLayout.Zoom;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(438, 12);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(32, 32);
            exitBtn.TabIndex = 9;
            exitBtn.TabStop = false;
            exitBtn.Click += ExitApplication;
            // 
            // resetPassBtn
            // 
            resetPassBtn.AutoSize = true;
            resetPassBtn.Cursor = Cursors.Hand;
            resetPassBtn.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetPassBtn.ForeColor = Color.FromArgb(69, 123, 157);
            resetPassBtn.Location = new Point(213, 561);
            resetPassBtn.Name = "resetPassBtn";
            resetPassBtn.Size = new Size(219, 22);
            resetPassBtn.TabIndex = 8;
            resetPassBtn.Text = "Forgot your password?";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(69, 123, 157);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(49, 598);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(383, 56);
            loginBtn.TabIndex = 7;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(69, 123, 157);
            panel4.Location = new Point(49, 523);
            panel4.Name = "panel4";
            panel4.Size = new Size(383, 3);
            panel4.TabIndex = 6;
            // 
            // lockImg
            // 
            lockImg.BackgroundImage = (Image)resources.GetObject("lockImg.BackgroundImage");
            lockImg.BackgroundImageLayout = ImageLayout.Zoom;
            lockImg.Location = new Point(49, 485);
            lockImg.Name = "lockImg";
            lockImg.Size = new Size(28, 28);
            lockImg.TabIndex = 6;
            lockImg.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(69, 123, 157);
            panel3.Location = new Point(49, 440);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 3);
            panel3.TabIndex = 5;
            // 
            // userImg
            // 
            userImg.BackgroundImage = (Image)resources.GetObject("userImg.BackgroundImage");
            userImg.BackgroundImageLayout = ImageLayout.Zoom;
            userImg.Location = new Point(49, 405);
            userImg.Name = "userImg";
            userImg.Size = new Size(28, 28);
            userImg.TabIndex = 4;
            userImg.TabStop = false;
            // 
            // loginLb
            // 
            loginLb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginLb.AutoSize = true;
            loginLb.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLb.ForeColor = Color.FromArgb(69, 123, 157);
            loginLb.Location = new Point(184, 276);
            loginLb.Name = "loginLb";
            loginLb.Size = new Size(114, 33);
            loginLb.TabIndex = 3;
            loginLb.Text = "LOGIN";
            loginLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoImg
            // 
            logoImg.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logoImg.BackgroundImage = (Image)resources.GetObject("logoImg.BackgroundImage");
            logoImg.BackgroundImageLayout = ImageLayout.Zoom;
            logoImg.Location = new Point(116, 51);
            logoImg.Name = "logoImg";
            logoImg.Size = new Size(250, 250);
            logoImg.TabIndex = 2;
            logoImg.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(482, 753);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showPassBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)lockImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)userImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoImg).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Label resetPassBtn;
        private Button loginBtn;
        private Panel panel4;
        private PictureBox lockImg;
        private Panel panel3;
        private PictureBox userImg;
        private Label loginLb;
        private PictureBox logoImg;
        private PictureBox exitBtn;
        private TextBox passwordTxt;
        private TextBox emailTxt;
        private PictureBox showPassBtn;
        private Label creditLabel;
    }
}
