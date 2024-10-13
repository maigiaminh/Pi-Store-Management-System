namespace PiStoreManagementSytem
{
    partial class ProductForm
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
            txtName = new TextBox();
            txtDescription = new TextBox();
            numPrice = new NumericUpDown();
            numQuantity = new NumericUpDown();
            lblName = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 130);
            txtName.Name = "txtName";
            txtName.Size = new Size(320, 27);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(174, 170);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(320, 60);
            txtDescription.TabIndex = 1;
            // 
            // numPrice
            // 
            numPrice.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            numPrice.Location = new Point(174, 250);
            numPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPrice.Minimum = new decimal(new int[] { 500000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(320, 27);
            numPrice.TabIndex = 2;
            numPrice.ThousandsSeparator = true;
            numPrice.Value = new decimal(new int[] { 500000, 0, 0, 0 });
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(174, 290);
            numQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(320, 27);
            numQuantity.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Rockwell", 10.2F);
            lblName.Location = new Point(37, 130);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Rockwell", 10.2F);
            lblDescription.Location = new Point(37, 170);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 20);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Rockwell", 10.2F);
            lblPrice.Location = new Point(37, 250);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 20);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Rockwell", 10.2F);
            lblQuantity.Location = new Point(37, 290);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(77, 20);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(361, 353);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 46);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(174, 353);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 46);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 45);
            label1.Name = "label1";
            label1.Size = new Size(177, 38);
            label1.TabIndex = 34;
            label1.Text = "PRODUCT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductForm
            // 
            ClientSize = new Size(564, 443);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(numQuantity);
            Controls.Add(numPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Form";
            Load += ProductForm_Load;
            MouseDown += DragApplication;
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        public TextBox txtName;
        public TextBox txtDescription;
        public NumericUpDown numPrice;
        public NumericUpDown numQuantity;
    }
}