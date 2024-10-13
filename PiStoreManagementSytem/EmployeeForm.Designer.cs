namespace PiStoreManagementSytem
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            fNameLabel = new Label();
            lNameLabl = new Label();
            fullNameLabel = new Label();
            addressLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            hDateLabel = new Label();
            salaryLabel = new Label();
            fNameTxt = new TextBox();
            lNameTxt = new TextBox();
            fullNameTxt = new TextBox();
            addressTxt = new TextBox();
            hDatePicker = new DateTimePicker();
            imgEmployee = new PictureBox();
            phoneTxt = new TextBox();
            emailTxt = new TextBox();
            salaryTxt = new NumericUpDown();
            eraseEmBtn = new Button();
            addEmBtn = new Button();
            saveEmBtn = new Button();
            resetEmBtn = new Button();
            label1 = new Label();
            idTxt = new TextBox();
            exitBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salaryTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitBtn).BeginInit();
            SuspendLayout();
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fNameLabel.Location = new Point(28, 109);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new Size(93, 20);
            fNameLabel.TabIndex = 0;
            fNameLabel.Text = "First Name";
            // 
            // lNameLabl
            // 
            lNameLabl.AutoSize = true;
            lNameLabl.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNameLabl.Location = new Point(28, 153);
            lNameLabl.Name = "lNameLabl";
            lNameLabl.Size = new Size(90, 20);
            lNameLabl.TabIndex = 1;
            lNameLabl.Text = "Last Name";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullNameLabel.Location = new Point(28, 197);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(88, 20);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Full Name";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressLabel.Location = new Point(28, 281);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(74, 20);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(28, 410);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(54, 20);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.Location = new Point(28, 366);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(59, 20);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Phone";
            // 
            // hDateLabel
            // 
            hDateLabel.AutoSize = true;
            hDateLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hDateLabel.Location = new Point(28, 490);
            hDateLabel.Name = "hDateLabel";
            hDateLabel.Size = new Size(83, 20);
            hDateLabel.TabIndex = 9;
            hDateLabel.Text = "Hire Date";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salaryLabel.Location = new Point(28, 534);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(58, 20);
            salaryLabel.TabIndex = 8;
            salaryLabel.Text = "Salary";
            // 
            // fNameTxt
            // 
            fNameTxt.BorderStyle = BorderStyle.FixedSingle;
            fNameTxt.Location = new Point(139, 106);
            fNameTxt.Name = "fNameTxt";
            fNameTxt.Size = new Size(237, 27);
            fNameTxt.TabIndex = 10;
            fNameTxt.TextChanged += UpdateFullName;
            // 
            // lNameTxt
            // 
            lNameTxt.BorderStyle = BorderStyle.FixedSingle;
            lNameTxt.Location = new Point(139, 150);
            lNameTxt.Name = "lNameTxt";
            lNameTxt.Size = new Size(237, 27);
            lNameTxt.TabIndex = 11;
            lNameTxt.TextChanged += UpdateFullName;
            // 
            // fullNameTxt
            // 
            fullNameTxt.BorderStyle = BorderStyle.FixedSingle;
            fullNameTxt.Enabled = false;
            fullNameTxt.Location = new Point(139, 194);
            fullNameTxt.Name = "fullNameTxt";
            fullNameTxt.ReadOnly = true;
            fullNameTxt.Size = new Size(237, 27);
            fullNameTxt.TabIndex = 12;
            // 
            // addressTxt
            // 
            addressTxt.BorderStyle = BorderStyle.FixedSingle;
            addressTxt.Location = new Point(139, 278);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(378, 27);
            addressTxt.TabIndex = 13;
            // 
            // hDatePicker
            // 
            hDatePicker.Location = new Point(139, 487);
            hDatePicker.Name = "hDatePicker";
            hDatePicker.Size = new Size(378, 27);
            hDatePicker.TabIndex = 20;
            // 
            // imgEmployee
            // 
            imgEmployee.BackgroundImage = (Image)resources.GetObject("imgEmployee.BackgroundImage");
            imgEmployee.BackgroundImageLayout = ImageLayout.Zoom;
            imgEmployee.BorderStyle = BorderStyle.FixedSingle;
            imgEmployee.Location = new Point(395, 106);
            imgEmployee.Name = "imgEmployee";
            imgEmployee.Size = new Size(122, 118);
            imgEmployee.TabIndex = 21;
            imgEmployee.TabStop = false;
            // 
            // phoneTxt
            // 
            phoneTxt.BorderStyle = BorderStyle.FixedSingle;
            phoneTxt.Location = new Point(139, 363);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(378, 27);
            phoneTxt.TabIndex = 22;
            phoneTxt.KeyPress += phoneTxt_KeyPress;
            // 
            // emailTxt
            // 
            emailTxt.BorderStyle = BorderStyle.FixedSingle;
            emailTxt.Location = new Point(139, 407);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(378, 27);
            emailTxt.TabIndex = 23;
            // 
            // salaryTxt
            // 
            salaryTxt.BorderStyle = BorderStyle.FixedSingle;
            salaryTxt.Increment = new decimal(new int[] { 500000, 0, 0, 0 });
            salaryTxt.Location = new Point(139, 531);
            salaryTxt.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            salaryTxt.Minimum = new decimal(new int[] { 1000000, 0, 0, 0 });
            salaryTxt.Name = "salaryTxt";
            salaryTxt.Size = new Size(378, 27);
            salaryTxt.TabIndex = 25;
            salaryTxt.ThousandsSeparator = true;
            salaryTxt.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // eraseEmBtn
            // 
            eraseEmBtn.BackColor = Color.FromArgb(238, 238, 238);
            eraseEmBtn.BackgroundImageLayout = ImageLayout.None;
            eraseEmBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            eraseEmBtn.FlatAppearance.BorderSize = 0;
            eraseEmBtn.FlatStyle = FlatStyle.Flat;
            eraseEmBtn.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eraseEmBtn.ForeColor = Color.Black;
            eraseEmBtn.Image = (Image)resources.GetObject("eraseEmBtn.Image");
            eraseEmBtn.ImageAlign = ContentAlignment.MiddleLeft;
            eraseEmBtn.Location = new Point(441, 588);
            eraseEmBtn.Name = "eraseEmBtn";
            eraseEmBtn.Size = new Size(76, 36);
            eraseEmBtn.TabIndex = 26;
            eraseEmBtn.Text = "Clear";
            eraseEmBtn.TextAlign = ContentAlignment.MiddleRight;
            eraseEmBtn.UseVisualStyleBackColor = false;
            eraseEmBtn.Click += eraseEmBtn_Click;
            // 
            // addEmBtn
            // 
            addEmBtn.BackColor = Color.FromArgb(238, 238, 238);
            addEmBtn.BackgroundImageLayout = ImageLayout.None;
            addEmBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            addEmBtn.FlatAppearance.BorderSize = 0;
            addEmBtn.FlatStyle = FlatStyle.Flat;
            addEmBtn.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmBtn.ForeColor = Color.Black;
            addEmBtn.Image = (Image)resources.GetObject("addEmBtn.Image");
            addEmBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addEmBtn.Location = new Point(353, 588);
            addEmBtn.Name = "addEmBtn";
            addEmBtn.Size = new Size(66, 36);
            addEmBtn.TabIndex = 28;
            addEmBtn.Text = "Add";
            addEmBtn.TextAlign = ContentAlignment.MiddleRight;
            addEmBtn.UseVisualStyleBackColor = false;
            addEmBtn.Click += addEmBtn_Click;
            // 
            // saveEmBtn
            // 
            saveEmBtn.BackColor = Color.FromArgb(238, 238, 238);
            saveEmBtn.BackgroundImageLayout = ImageLayout.None;
            saveEmBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            saveEmBtn.FlatAppearance.BorderSize = 0;
            saveEmBtn.FlatStyle = FlatStyle.Flat;
            saveEmBtn.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveEmBtn.ForeColor = Color.Black;
            saveEmBtn.Image = (Image)resources.GetObject("saveEmBtn.Image");
            saveEmBtn.ImageAlign = ContentAlignment.MiddleLeft;
            saveEmBtn.Location = new Point(139, 588);
            saveEmBtn.Name = "saveEmBtn";
            saveEmBtn.Size = new Size(137, 36);
            saveEmBtn.TabIndex = 30;
            saveEmBtn.Text = "Save Changes";
            saveEmBtn.TextAlign = ContentAlignment.MiddleRight;
            saveEmBtn.UseVisualStyleBackColor = false;
            saveEmBtn.Click += saveEmBtn_Click;
            // 
            // resetEmBtn
            // 
            resetEmBtn.BackColor = Color.FromArgb(238, 238, 238);
            resetEmBtn.BackgroundImageLayout = ImageLayout.None;
            resetEmBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            resetEmBtn.FlatAppearance.BorderSize = 0;
            resetEmBtn.FlatStyle = FlatStyle.Flat;
            resetEmBtn.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetEmBtn.ForeColor = Color.Black;
            resetEmBtn.Image = (Image)resources.GetObject("resetEmBtn.Image");
            resetEmBtn.ImageAlign = ContentAlignment.MiddleLeft;
            resetEmBtn.Location = new Point(282, 588);
            resetEmBtn.Name = "resetEmBtn";
            resetEmBtn.Size = new Size(137, 36);
            resetEmBtn.TabIndex = 31;
            resetEmBtn.Text = "Reset Changes";
            resetEmBtn.TextAlign = ContentAlignment.MiddleRight;
            resetEmBtn.UseVisualStyleBackColor = false;
            resetEmBtn.Click += resetEmBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 37);
            label1.Name = "label1";
            label1.Size = new Size(196, 38);
            label1.TabIndex = 32;
            label1.Text = "EMPLOYEE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idTxt
            // 
            idTxt.Enabled = false;
            idTxt.Location = new Point(12, 12);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(25, 27);
            idTxt.TabIndex = 33;
            idTxt.Visible = false;
            // 
            // exitBtn
            // 
            exitBtn.BackgroundImage = (Image)resources.GetObject("exitBtn.BackgroundImage");
            exitBtn.BackgroundImageLayout = ImageLayout.Zoom;
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(507, 7);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(32, 32);
            exitBtn.TabIndex = 34;
            exitBtn.TabStop = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(551, 653);
            Controls.Add(exitBtn);
            Controls.Add(idTxt);
            Controls.Add(label1);
            Controls.Add(resetEmBtn);
            Controls.Add(saveEmBtn);
            Controls.Add(addEmBtn);
            Controls.Add(eraseEmBtn);
            Controls.Add(salaryTxt);
            Controls.Add(emailTxt);
            Controls.Add(phoneTxt);
            Controls.Add(imgEmployee);
            Controls.Add(hDatePicker);
            Controls.Add(addressTxt);
            Controls.Add(fullNameTxt);
            Controls.Add(lNameTxt);
            Controls.Add(fNameTxt);
            Controls.Add(hDateLabel);
            Controls.Add(salaryLabel);
            Controls.Add(phoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(addressLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(lNameLabl);
            Controls.Add(fNameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += EmployeeForm_Load;
            MouseDown += DragApplication;
            ((System.ComponentModel.ISupportInitialize)imgEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)salaryTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fNameLabel;
        private Label lNameLabl;
        private Label fullNameLabel;
        private Label addressLabel;
        private Label emailLabel;
        private Label phoneLabel;
        private Label hDateLabel;
        private Label salaryLabel;
        private PictureBox pictureBox1;
        private Button eraseEmBtn;
        private Label label1;
        public Button addEmBtn;
        public Button saveEmBtn;
        public Button resetEmBtn;
        public TextBox fNameTxt;
        public TextBox lNameTxt;
        public TextBox fullNameTxt;
        public TextBox addressTxt;
        public DateTimePicker hDatePicker;
        public TextBox phoneTxt;
        public TextBox emailTxt;
        public NumericUpDown salaryTxt;
        public TextBox idTxt;
        private PictureBox exitBtn;
        public PictureBox imgEmployee;
    }
}