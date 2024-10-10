namespace PiStoreManagementSytem.modal
{
    partial class SuccessModal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessModal));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            closeBtn = new Button();
            successTxt = new Label();
            panel1 = new Panel();
            successLb = new Label();
            closeTimer = new System.Windows.Forms.Timer(components);
            openTimer = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 196);
            panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(248, -30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Transparent;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Font = new Font("Rockwell Condensed", 12F);
            closeBtn.ForeColor = Color.FromArgb(49, 213, 84);
            closeBtn.Location = new Point(379, 393);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(41, 45);
            closeBtn.TabIndex = 8;
            closeBtn.Text = "OK";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // successTxt
            // 
            successTxt.AutoSize = true;
            successTxt.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            successTxt.ForeColor = Color.Gray;
            successTxt.Location = new Point(97, 286);
            successTxt.Name = "successTxt";
            successTxt.Size = new Size(223, 24);
            successTxt.TabIndex = 7;
            successTxt.Text = "Your request has been executed";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(99, 364);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 2);
            panel1.TabIndex = 9;
            // 
            // successLb
            // 
            successLb.AutoSize = true;
            successLb.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            successLb.ForeColor = Color.FromArgb(49, 213, 84);
            successLb.Location = new Point(97, 237);
            successLb.Name = "successLb";
            successLb.Size = new Size(81, 27);
            successLb.TabIndex = 6;
            successLb.Text = "SUCCESS!";
            // 
            // closeTimer
            // 
            closeTimer.Tick += closeTimer_Tick_1;
            // 
            // openTimer
            // 
            openTimer.Tick += openTimer_Tick_1;
            // 
            // SuccessModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(closeBtn);
            Controls.Add(successTxt);
            Controls.Add(panel1);
            Controls.Add(successLb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuccessModal";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += SuccessModal_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Button closeBtn;
        public Label successTxt;
        private Panel panel1;
        private Label successLb;
        private System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Timer openTimer;
    }
}