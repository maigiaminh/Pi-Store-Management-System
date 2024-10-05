namespace PiStoreManagementSytem
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            navPanel = new Panel();
            billBtn = new Panel();
            panel1 = new Panel();
            billLabel = new Label();
            billImg = new PictureBox();
            orderBtn = new Panel();
            orderLabel = new Label();
            orderImg = new PictureBox();
            productBtn = new Panel();
            productLabel = new Label();
            productImg = new PictureBox();
            clientBtn = new Panel();
            clientLabel = new Label();
            clientImg = new PictureBox();
            employeeBtn = new Panel();
            employeeLabel = new Label();
            employeeImg = new PictureBox();
            homeBtn = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            homeLabel = new Label();
            homeImg = new PictureBox();
            logoLabel = new Label();
            logoImg = new PictureBox();
            headerPanel = new Panel();
            menuBtn = new PictureBox();
            timerPanel = new System.Windows.Forms.Timer(components);
            employeePanel = new Panel();
            printEmLabel = new Label();
            printEmBtn = new PictureBox();
            deleteEmLabel = new Label();
            deleteEmBtn = new PictureBox();
            editEmLabel = new Label();
            editEmBtn = new PictureBox();
            addELabel = new Label();
            addEmBtn = new PictureBox();
            employeeTitle = new Label();
            employeeGridView = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            navPanel.SuspendLayout();
            billBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)billImg).BeginInit();
            orderBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderImg).BeginInit();
            productBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productImg).BeginInit();
            clientBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientImg).BeginInit();
            employeeBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeImg).BeginInit();
            homeBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homeImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoImg).BeginInit();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuBtn).BeginInit();
            employeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)printEmBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteEmBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editEmBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addEmBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).BeginInit();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.White;
            navPanel.Controls.Add(billBtn);
            navPanel.Controls.Add(orderBtn);
            navPanel.Controls.Add(productBtn);
            navPanel.Controls.Add(clientBtn);
            navPanel.Controls.Add(employeeBtn);
            navPanel.Controls.Add(homeBtn);
            navPanel.Controls.Add(logoLabel);
            navPanel.Controls.Add(logoImg);
            navPanel.Dock = DockStyle.Left;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(200, 653);
            navPanel.TabIndex = 0;
            // 
            // billBtn
            // 
            billBtn.Controls.Add(panel1);
            billBtn.Controls.Add(billLabel);
            billBtn.Controls.Add(billImg);
            billBtn.Cursor = Cursors.Hand;
            billBtn.Location = new Point(0, 362);
            billBtn.Name = "billBtn";
            billBtn.Size = new Size(200, 52);
            billBtn.TabIndex = 9;
            billBtn.Click += BillClick;
            billBtn.MouseLeave += BillLeave;
            billBtn.MouseHover += BillHover;
            // 
            // panel1
            // 
            panel1.Location = new Point(200, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 2;
            // 
            // billLabel
            // 
            billLabel.AutoSize = true;
            billLabel.Cursor = Cursors.Hand;
            billLabel.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billLabel.ForeColor = Color.Black;
            billLabel.Location = new Point(79, 25);
            billLabel.Name = "billLabel";
            billLabel.Size = new Size(31, 24);
            billLabel.TabIndex = 5;
            billLabel.Text = "Bill";
            billLabel.Click += BillClick;
            // 
            // billImg
            // 
            billImg.BackgroundImage = Properties.Resources.bills;
            billImg.BackgroundImageLayout = ImageLayout.Zoom;
            billImg.Cursor = Cursors.Hand;
            billImg.Location = new Point(22, 17);
            billImg.Name = "billImg";
            billImg.Size = new Size(42, 32);
            billImg.TabIndex = 0;
            billImg.TabStop = false;
            billImg.Click += BillClick;
            // 
            // orderBtn
            // 
            orderBtn.Controls.Add(orderLabel);
            orderBtn.Controls.Add(orderImg);
            orderBtn.Cursor = Cursors.Hand;
            orderBtn.Location = new Point(0, 307);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(200, 52);
            orderBtn.TabIndex = 8;
            orderBtn.Click += OrderClick;
            orderBtn.MouseLeave += OrderLeave;
            orderBtn.MouseHover += OrderHover;
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderLabel.ForeColor = Color.Black;
            orderLabel.Location = new Point(79, 25);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(45, 24);
            orderLabel.TabIndex = 5;
            orderLabel.Text = "Order";
            orderLabel.Click += OrderClick;
            // 
            // orderImg
            // 
            orderImg.BackgroundImage = Properties.Resources.orders;
            orderImg.BackgroundImageLayout = ImageLayout.Zoom;
            orderImg.Location = new Point(22, 17);
            orderImg.Name = "orderImg";
            orderImg.Size = new Size(42, 32);
            orderImg.TabIndex = 0;
            orderImg.TabStop = false;
            orderImg.Click += OrderClick;
            // 
            // productBtn
            // 
            productBtn.Controls.Add(productLabel);
            productBtn.Controls.Add(productImg);
            productBtn.Cursor = Cursors.Hand;
            productBtn.Location = new Point(0, 252);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(200, 52);
            productBtn.TabIndex = 7;
            productBtn.Click += ProductClick;
            productBtn.MouseLeave += ProductLeave;
            productBtn.MouseHover += ProductHover;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Cursor = Cursors.Hand;
            productLabel.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productLabel.ForeColor = Color.Black;
            productLabel.Location = new Point(79, 25);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(59, 24);
            productLabel.TabIndex = 5;
            productLabel.Text = "Product";
            productLabel.Click += ProductClick;
            // 
            // productImg
            // 
            productImg.BackgroundImage = Properties.Resources.products;
            productImg.BackgroundImageLayout = ImageLayout.Zoom;
            productImg.Cursor = Cursors.Hand;
            productImg.Location = new Point(22, 17);
            productImg.Name = "productImg";
            productImg.Size = new Size(42, 32);
            productImg.TabIndex = 0;
            productImg.TabStop = false;
            productImg.Click += ProductClick;
            // 
            // clientBtn
            // 
            clientBtn.Controls.Add(clientLabel);
            clientBtn.Controls.Add(clientImg);
            clientBtn.Cursor = Cursors.Hand;
            clientBtn.Location = new Point(0, 197);
            clientBtn.Name = "clientBtn";
            clientBtn.Size = new Size(200, 52);
            clientBtn.TabIndex = 6;
            clientBtn.Click += ClientClick;
            clientBtn.MouseLeave += ClientLeave;
            clientBtn.MouseHover += ClientHover;
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientLabel.ForeColor = Color.Black;
            clientLabel.Location = new Point(79, 25);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(46, 24);
            clientLabel.TabIndex = 5;
            clientLabel.Text = "Client";
            clientLabel.Click += ClientClick;
            // 
            // clientImg
            // 
            clientImg.BackgroundImage = Properties.Resources.customer;
            clientImg.BackgroundImageLayout = ImageLayout.Zoom;
            clientImg.Location = new Point(22, 17);
            clientImg.Name = "clientImg";
            clientImg.Size = new Size(42, 32);
            clientImg.TabIndex = 0;
            clientImg.TabStop = false;
            clientImg.Click += ClientClick;
            // 
            // employeeBtn
            // 
            employeeBtn.Controls.Add(employeeLabel);
            employeeBtn.Controls.Add(employeeImg);
            employeeBtn.Cursor = Cursors.Hand;
            employeeBtn.Location = new Point(0, 142);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(200, 52);
            employeeBtn.TabIndex = 3;
            employeeBtn.Click += EmployeeClick;
            employeeBtn.MouseLeave += EmployeeLeave;
            employeeBtn.MouseHover += EmployeeHover;
            // 
            // employeeLabel
            // 
            employeeLabel.AutoSize = true;
            employeeLabel.Cursor = Cursors.Hand;
            employeeLabel.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeLabel.ForeColor = Color.Black;
            employeeLabel.Location = new Point(79, 25);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new Size(70, 24);
            employeeLabel.TabIndex = 5;
            employeeLabel.Text = "Employee";
            employeeLabel.Click += EmployeeClick;
            // 
            // employeeImg
            // 
            employeeImg.BackgroundImage = Properties.Resources.employee;
            employeeImg.BackgroundImageLayout = ImageLayout.Zoom;
            employeeImg.Cursor = Cursors.Hand;
            employeeImg.Location = new Point(22, 17);
            employeeImg.Name = "employeeImg";
            employeeImg.Size = new Size(42, 32);
            employeeImg.TabIndex = 0;
            employeeImg.TabStop = false;
            employeeImg.Click += EmployeeClick;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.White;
            homeBtn.Controls.Add(flowLayoutPanel1);
            homeBtn.Controls.Add(homeLabel);
            homeBtn.Controls.Add(homeImg);
            homeBtn.Cursor = Cursors.Hand;
            homeBtn.Location = new Point(0, 88);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(200, 52);
            homeBtn.TabIndex = 2;
            homeBtn.Click += HomeClick;
            homeBtn.MouseLeave += HomeLeave;
            homeBtn.MouseHover += HomeHover;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 125);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // homeLabel
            // 
            homeLabel.AutoSize = true;
            homeLabel.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeLabel.ForeColor = Color.Black;
            homeLabel.Location = new Point(79, 24);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(44, 24);
            homeLabel.TabIndex = 3;
            homeLabel.Text = "Home";
            homeLabel.Click += HomeClick;
            homeLabel.MouseLeave += HomeLeave;
            homeLabel.MouseHover += HomeHover;
            // 
            // homeImg
            // 
            homeImg.BackgroundImage = Properties.Resources.home;
            homeImg.BackgroundImageLayout = ImageLayout.Zoom;
            homeImg.Location = new Point(22, 16);
            homeImg.Name = "homeImg";
            homeImg.Size = new Size(42, 32);
            homeImg.TabIndex = 2;
            homeImg.TabStop = false;
            homeImg.Click += HomeClick;
            homeImg.MouseLeave += HomeLeave;
            homeImg.MouseHover += HomeHover;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoLabel.ForeColor = Color.FromArgb(69, 123, 157);
            logoLabel.Location = new Point(93, 22);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(84, 24);
            logoLabel.TabIndex = 1;
            logoLabel.Text = "Pi Store";
            // 
            // logoImg
            // 
            logoImg.BackgroundImage = (Image)resources.GetObject("logoImg.BackgroundImage");
            logoImg.BackgroundImageLayout = ImageLayout.Zoom;
            logoImg.Location = new Point(0, 0);
            logoImg.Name = "logoImg";
            logoImg.Size = new Size(87, 73);
            logoImg.TabIndex = 0;
            logoImg.TabStop = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(menuBtn);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(200, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(782, 60);
            headerPanel.TabIndex = 1;
            // 
            // menuBtn
            // 
            menuBtn.BackgroundImage = (Image)resources.GetObject("menuBtn.BackgroundImage");
            menuBtn.BackgroundImageLayout = ImageLayout.Zoom;
            menuBtn.Cursor = Cursors.Hand;
            menuBtn.Location = new Point(6, 12);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(43, 36);
            menuBtn.TabIndex = 0;
            menuBtn.TabStop = false;
            menuBtn.Click += MenuBtn_Click;
            // 
            // timerPanel
            // 
            timerPanel.Interval = 15;
            timerPanel.Tick += TimerPanel_Tick;
            // 
            // employeePanel
            // 
            employeePanel.Controls.Add(printEmLabel);
            employeePanel.Controls.Add(printEmBtn);
            employeePanel.Controls.Add(deleteEmLabel);
            employeePanel.Controls.Add(deleteEmBtn);
            employeePanel.Controls.Add(editEmLabel);
            employeePanel.Controls.Add(editEmBtn);
            employeePanel.Controls.Add(addELabel);
            employeePanel.Controls.Add(addEmBtn);
            employeePanel.Controls.Add(employeeTitle);
            employeePanel.Controls.Add(employeeGridView);
            employeePanel.Dock = DockStyle.Fill;
            employeePanel.Location = new Point(200, 60);
            employeePanel.Name = "employeePanel";
            employeePanel.Size = new Size(782, 593);
            employeePanel.TabIndex = 2;
            // 
            // printEmLabel
            // 
            printEmLabel.AutoSize = true;
            printEmLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            printEmLabel.ForeColor = Color.FromArgb(255, 163, 0);
            printEmLabel.Location = new Point(631, 192);
            printEmLabel.Name = "printEmLabel";
            printEmLabel.Size = new Size(64, 20);
            printEmLabel.TabIndex = 27;
            printEmLabel.Text = "PRINT";
            // 
            // printEmBtn
            // 
            printEmBtn.BackgroundImage = (Image)resources.GetObject("printEmBtn.BackgroundImage");
            printEmBtn.BackgroundImageLayout = ImageLayout.Zoom;
            printEmBtn.Cursor = Cursors.Hand;
            printEmBtn.Location = new Point(628, 115);
            printEmBtn.Name = "printEmBtn";
            printEmBtn.Size = new Size(72, 62);
            printEmBtn.TabIndex = 26;
            printEmBtn.TabStop = false;
            printEmBtn.Click += printEmBtn_Click;
            // 
            // deleteEmLabel
            // 
            deleteEmLabel.AutoSize = true;
            deleteEmLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            deleteEmLabel.ForeColor = Color.Silver;
            deleteEmLabel.Location = new Point(442, 192);
            deleteEmLabel.Name = "deleteEmLabel";
            deleteEmLabel.Size = new Size(79, 20);
            deleteEmLabel.TabIndex = 25;
            deleteEmLabel.Text = "DELETE";
            // 
            // deleteEmBtn
            // 
            deleteEmBtn.BackgroundImage = Properties.Resources.remove_unactive;
            deleteEmBtn.BackgroundImageLayout = ImageLayout.Zoom;
            deleteEmBtn.Cursor = Cursors.Hand;
            deleteEmBtn.Location = new Point(448, 115);
            deleteEmBtn.Name = "deleteEmBtn";
            deleteEmBtn.Size = new Size(69, 62);
            deleteEmBtn.TabIndex = 24;
            deleteEmBtn.TabStop = false;
            deleteEmBtn.Click += deleteEmBtn_Click;
            // 
            // editEmLabel
            // 
            editEmLabel.AutoSize = true;
            editEmLabel.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            editEmLabel.ForeColor = Color.Silver;
            editEmLabel.Location = new Point(276, 192);
            editEmLabel.Name = "editEmLabel";
            editEmLabel.Size = new Size(53, 20);
            editEmLabel.TabIndex = 23;
            editEmLabel.Text = "EDIT";
            // 
            // editEmBtn
            // 
            editEmBtn.BackgroundImage = Properties.Resources.pen_unactive;
            editEmBtn.BackgroundImageLayout = ImageLayout.Zoom;
            editEmBtn.Cursor = Cursors.Hand;
            editEmBtn.Location = new Point(269, 115);
            editEmBtn.Name = "editEmBtn";
            editEmBtn.Size = new Size(68, 62);
            editEmBtn.TabIndex = 22;
            editEmBtn.TabStop = false;
            editEmBtn.Click += editEmBtn_Click;
            // 
            // addELabel
            // 
            addELabel.AutoSize = true;
            addELabel.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            addELabel.ForeColor = Color.FromArgb(75, 174, 79);
            addELabel.Location = new Point(97, 192);
            addELabel.Name = "addELabel";
            addELabel.Size = new Size(49, 20);
            addELabel.TabIndex = 21;
            addELabel.Text = "ADD";
            // 
            // addEmBtn
            // 
            addEmBtn.BackgroundImage = (Image)resources.GetObject("addEmBtn.BackgroundImage");
            addEmBtn.BackgroundImageLayout = ImageLayout.Zoom;
            addEmBtn.Cursor = Cursors.Hand;
            addEmBtn.Location = new Point(86, 115);
            addEmBtn.Name = "addEmBtn";
            addEmBtn.Size = new Size(70, 62);
            addEmBtn.TabIndex = 20;
            addEmBtn.TabStop = false;
            addEmBtn.Click += addEmBtn_Click;
            // 
            // employeeTitle
            // 
            employeeTitle.AutoSize = true;
            employeeTitle.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeTitle.ForeColor = Color.FromArgb(69, 123, 157);
            employeeTitle.Location = new Point(230, 25);
            employeeTitle.Name = "employeeTitle";
            employeeTitle.Size = new Size(371, 38);
            employeeTitle.TabIndex = 19;
            employeeTitle.Text = "Employee Management";
            // 
            // employeeGridView
            // 
            employeeGridView.AllowUserToAddRows = false;
            employeeGridView.AllowUserToDeleteRows = false;
            employeeGridView.BackgroundColor = Color.White;
            employeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeGridView.Dock = DockStyle.Bottom;
            employeeGridView.Location = new Point(0, 247);
            employeeGridView.Name = "employeeGridView";
            employeeGridView.ReadOnly = true;
            employeeGridView.RowHeadersWidth = 51;
            employeeGridView.Size = new Size(782, 346);
            employeeGridView.TabIndex = 1;
            employeeGridView.CellClick += EmployeeCellClick;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(982, 653);
            Controls.Add(employeePanel);
            Controls.Add(headerPanel);
            Controls.Add(navPanel);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            billBtn.ResumeLayout(false);
            billBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)billImg).EndInit();
            orderBtn.ResumeLayout(false);
            orderBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderImg).EndInit();
            productBtn.ResumeLayout(false);
            productBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productImg).EndInit();
            clientBtn.ResumeLayout(false);
            clientBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientImg).EndInit();
            employeeBtn.ResumeLayout(false);
            employeeBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeImg).EndInit();
            homeBtn.ResumeLayout(false);
            homeBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)homeImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoImg).EndInit();
            headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuBtn).EndInit();
            employeePanel.ResumeLayout(false);
            employeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)printEmBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteEmBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)editEmBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)addEmBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Panel headerPanel;
        private Label logoLabel;
        private PictureBox logoImg;
        private Panel homeBtn;
        private Label homeLabel;
        private PictureBox homeImg;
        private PictureBox menuBtn;
        private System.Windows.Forms.Timer timerPanel;
        private Panel employeeBtn;
        private PictureBox employeeImg;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel billBtn;
        private Label billLabel;
        private PictureBox billImg;
        private Panel orderBtn;
        private Label orderLabel;
        private PictureBox orderImg;
        private Panel productBtn;
        private Label productLabel;
        private PictureBox productImg;
        private Panel clientBtn;
        private Label clientLabel;
        private PictureBox clientImg;
        private Label employeeLabel;
        private Panel employeePanel;
        private DataGridView employeeGridView;
        private Panel panel1;
        private Label printEmLabel;
        private PictureBox printEmBtn;
        private Label deleteEmLabel;
        private PictureBox deleteEmBtn;
        private Label editEmLabel;
        private PictureBox editEmBtn;
        private Label addELabel;
        private PictureBox addEmBtn;
        private Label employeeTitle;
        private System.Windows.Forms.Timer timer1;
    }
}