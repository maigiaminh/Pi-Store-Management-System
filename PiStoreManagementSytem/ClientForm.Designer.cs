namespace PiStoreManagementSytem
{
    partial class ClientForm
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
            txtClientName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            lblClientName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtClientName
            // 
            txtClientName.Font = new Font("Segoe UI", 9F);
            txtClientName.Location = new Point(174, 105);
            txtClientName.Margin = new Padding(4, 5, 4, 5);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(320, 27);
            txtClientName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(174, 166);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9F);
            txtPhone.Location = new Point(174, 228);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(320, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.Location = new Point(174, 289);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(320, 90);
            txtAddress.TabIndex = 3;
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientName.Location = new Point(28, 108);
            lblClientName.Margin = new Padding(4, 0, 4, 0);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(115, 20);
            lblClientName.TabIndex = 4;
            lblClientName.Text = "Client Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(28, 166);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            lblPhone.Location = new Point(28, 228);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 20);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            lblAddress.Location = new Point(28, 289);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 20);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(361, 412);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(174, 412);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 46);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 34);
            label1.Name = "label1";
            label1.Size = new Size(136, 38);
            label1.TabIndex = 33;
            label1.Text = "CLIENT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 483);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblClientName);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtClientName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client Form";
            Load += ClientForm_Load;
            MouseDown += DragApplication;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnCancel;
        private Button btnSave;
        public TextBox txtClientName;
        public TextBox txtEmail;
        public TextBox txtPhone;
        public TextBox txtAddress;
        private Label label1;
    }
}