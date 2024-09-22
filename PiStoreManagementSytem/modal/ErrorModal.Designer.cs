namespace PiStoreManagementSytem.modal
{
    partial class ErrorModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorModal));
            label1 = new Label();
            errorTxt = new Label();
            closeBtn = new Button();
            closeTimer = new System.Windows.Forms.Timer(components);
            openTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(42, 231);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 1;
            label1.Text = "Oh mannn!";
            // 
            // errorTxt
            // 
            errorTxt.AutoSize = true;
            errorTxt.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorTxt.ForeColor = Color.Gray;
            errorTxt.Location = new Point(42, 280);
            errorTxt.Name = "errorTxt";
            errorTxt.Size = new Size(152, 24);
            errorTxt.TabIndex = 2;
            errorTxt.Text = "An error has occured";
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.FromArgb(250, 80, 62);
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Dock = DockStyle.Bottom;
            closeBtn.Font = new Font("Rockwell Condensed", 12F);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(0, 367);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(800, 83);
            closeBtn.TabIndex = 3;
            closeBtn.Text = "DISSMISS";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // closeTimer
            // 
            closeTimer.Tick += closeTimer_Tick;
            // 
            // openTimer
            // 
            openTimer.Tick += openTimer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(249, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ErrorModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(errorTxt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ErrorModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErrorModal";
            Load += ErrorModal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        public Label errorTxt;
        private Button closeBtn;
        private System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Timer openTimer;
        private PictureBox pictureBox1;
    }
}