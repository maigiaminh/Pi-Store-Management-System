namespace PiStoreManagementSytem
{
    partial class BillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            cmbOrderList = new ComboBox();
            lblSelectOrder = new Label();
            orderItemsGridView = new DataGridView();
            lblOrderItems = new Label();
            btnGenerateBill = new Button();
            btnPrintBill = new Button();
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).BeginInit();
            SuspendLayout();
            // 
            // cmbOrderList
            // 
            cmbOrderList.FormattingEnabled = true;
            cmbOrderList.Location = new Point(124, 20);
            cmbOrderList.Name = "cmbOrderList";
            cmbOrderList.Size = new Size(178, 28);
            cmbOrderList.TabIndex = 0;
            // 
            // lblSelectOrder
            // 
            lblSelectOrder.AutoSize = true;
            lblSelectOrder.Location = new Point(27, 23);
            lblSelectOrder.Name = "lblSelectOrder";
            lblSelectOrder.Size = new Size(94, 20);
            lblSelectOrder.TabIndex = 1;
            lblSelectOrder.Text = "Select Order:";
            // 
            // orderItemsGridView
            // 
            orderItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderItemsGridView.Location = new Point(27, 80);
            orderItemsGridView.Name = "orderItemsGridView";
            orderItemsGridView.RowHeadersWidth = 62;
            orderItemsGridView.RowTemplate.Height = 28;
            orderItemsGridView.Size = new Size(444, 300);
            orderItemsGridView.TabIndex = 2;
            // 
            // lblOrderItems
            // 
            lblOrderItems.AutoSize = true;
            lblOrderItems.Location = new Point(27, 57);
            lblOrderItems.Name = "lblOrderItems";
            lblOrderItems.Size = new Size(90, 20);
            lblOrderItems.TabIndex = 4;
            lblOrderItems.Text = "Order Items:";
            // 
            // btnGenerateBill
            // 
            btnGenerateBill.BackColor = Color.FromArgb(238, 238, 238);
            btnGenerateBill.BackgroundImageLayout = ImageLayout.None;
            btnGenerateBill.FlatAppearance.BorderColor = Color.DarkGreen;
            btnGenerateBill.FlatAppearance.BorderSize = 0;
            btnGenerateBill.FlatStyle = FlatStyle.Flat;
            btnGenerateBill.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateBill.ForeColor = Color.Black;
            btnGenerateBill.Image = (Image)resources.GetObject("btnGenerateBill.Image");
            btnGenerateBill.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerateBill.Location = new Point(214, 400);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(133, 36);
            btnGenerateBill.TabIndex = 29;
            btnGenerateBill.Text = "Generate Bill";
            btnGenerateBill.TextAlign = ContentAlignment.MiddleRight;
            btnGenerateBill.UseVisualStyleBackColor = false;
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = Color.FromArgb(238, 238, 238);
            btnPrintBill.BackgroundImageLayout = ImageLayout.None;
            btnPrintBill.FlatAppearance.BorderColor = Color.DarkGreen;
            btnPrintBill.FlatAppearance.BorderSize = 0;
            btnPrintBill.FlatStyle = FlatStyle.Flat;
            btnPrintBill.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrintBill.ForeColor = Color.Black;
            btnPrintBill.Image = (Image)resources.GetObject("btnPrintBill.Image");
            btnPrintBill.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrintBill.Location = new Point(373, 400);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(98, 36);
            btnPrintBill.TabIndex = 30;
            btnPrintBill.Text = "Print Bill";
            btnPrintBill.TextAlign = ContentAlignment.MiddleRight;
            btnPrintBill.UseVisualStyleBackColor = false;
            // 
            // BillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 458);
            Controls.Add(btnPrintBill);
            Controls.Add(btnGenerateBill);
            Controls.Add(lblOrderItems);
            Controls.Add(orderItemsGridView);
            Controls.Add(lblSelectOrder);
            Controls.Add(cmbOrderList);
            Name = "BillForm";
            Text = "BillForm";
            ((System.ComponentModel.ISupportInitialize)orderItemsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrderList;
        private System.Windows.Forms.Label lblSelectOrder;
        private System.Windows.Forms.DataGridView orderItemsGridView;
        private System.Windows.Forms.Label lblOrderItems;
        public Button btnGenerateBill;
        public Button btnPrintBill;
    }
}