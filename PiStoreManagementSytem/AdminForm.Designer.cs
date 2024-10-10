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
            logoutBtn = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
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
            avtBtn = new PictureBox();
            timerPanel = new System.Windows.Forms.Timer(components);
            employeePanel = new Panel();
            btnDESC = new Button();
            btnASC = new Button();
            txtSearch = new TextBox();
            cmbSearchCriteria = new ComboBox();
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
            settingPanel = new Panel();
            logout2_Btn = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label4 = new Label();
            changepassBtn = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label3 = new Label();
            profileBtn = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            navPanel.SuspendLayout();
            logoutBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)avtBtn).BeginInit();
            employeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)printEmBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteEmBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editEmBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addEmBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).BeginInit();
            settingPanel.SuspendLayout();
            logout2_Btn.SuspendLayout();
            changepassBtn.SuspendLayout();
            profileBtn.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.White;
            navPanel.Controls.Add(logoutBtn);
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
            navPanel.MouseDown += DragApplication;
            // 
            // logoutBtn
            // 
            logoutBtn.Controls.Add(panel3);
            logoutBtn.Controls.Add(label1);
            logoutBtn.Controls.Add(pictureBox1);
            logoutBtn.Location = new Point(0, 578);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(200, 75);
            logoutBtn.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Location = new Point(200, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(243, 66, 53);
            label1.Location = new Point(79, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 24);
            label1.TabIndex = 5;
            label1.Text = "Log out";
            label1.Click += logoutBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(22, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 32);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += logoutBtn_Click;
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
            billBtn.MouseEnter += BillHover;
            billBtn.MouseLeave += BillLeave;
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
            billLabel.MouseEnter += BillHover;
            billLabel.MouseLeave += BillLeave;
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
            billImg.MouseEnter += BillHover;
            billImg.MouseLeave += BillLeave;
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
            orderBtn.MouseEnter += OrderHover;
            orderBtn.MouseLeave += OrderLeave;
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
            orderLabel.MouseEnter += OrderHover;
            orderLabel.MouseLeave += OrderLeave;
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
            orderImg.MouseEnter += OrderHover;
            orderImg.MouseLeave += OrderLeave;
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
            productBtn.MouseEnter += ProductHover;
            productBtn.MouseLeave += ProductLeave;
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
            productLabel.MouseEnter += ProductHover;
            productLabel.MouseLeave += ProductLeave;
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
            productImg.MouseEnter += ProductHover;
            productImg.MouseLeave += ProductLeave;
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
            clientBtn.MouseEnter += ClientHover;
            clientBtn.MouseLeave += ClientLeave;
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
            clientLabel.MouseEnter += ClientHover;
            clientLabel.MouseLeave += ClientLeave;
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
            clientImg.MouseEnter += ClientHover;
            clientImg.MouseLeave += ClientLeave;
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
            employeeBtn.MouseEnter += EmployeeHover;
            employeeBtn.MouseLeave += EmployeeLeave;
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
            employeeLabel.MouseEnter += EmployeeHover;
            employeeLabel.MouseLeave += EmployeeLeave;
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
            employeeImg.MouseEnter += EmployeeHover;
            employeeImg.MouseLeave += EmployeeLeave;
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
            homeBtn.MouseEnter += HomeHover;
            homeBtn.MouseLeave += HomeLeave;
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
            homeLabel.MouseEnter += HomeHover;
            homeLabel.MouseLeave += HomeLeave;
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
            homeImg.MouseEnter += HomeHover;
            homeImg.MouseLeave += HomeLeave;
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
            headerPanel.MouseDown += DragApplication;
            // 
            // menuBtn
            // 
            menuBtn.BackgroundImage = (Image)resources.GetObject("menuBtn.BackgroundImage");
            menuBtn.BackgroundImageLayout = ImageLayout.Zoom;
            menuBtn.Cursor = Cursors.Hand;
            menuBtn.Location = new Point(16, 15);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(43, 36);
            menuBtn.TabIndex = 0;
            menuBtn.TabStop = false;
            menuBtn.Click += MenuBtn_Click;
            // 
            // avtBtn
            // 
            avtBtn.BackColor = Color.White;
            avtBtn.BackgroundImage = (Image)resources.GetObject("avtBtn.BackgroundImage");
            avtBtn.BackgroundImageLayout = ImageLayout.Stretch;
            avtBtn.Cursor = Cursors.Hand;
            avtBtn.Location = new Point(930, 15);
            avtBtn.Name = "avtBtn";
            avtBtn.Size = new Size(32, 32);
            avtBtn.TabIndex = 1;
            avtBtn.TabStop = false;
            avtBtn.Click += avtBtn_Click;
            // 
            // timerPanel
            // 
            timerPanel.Interval = 15;
            timerPanel.Tick += TimerPanel_Tick;
            // 
            // employeePanel
            // 
            employeePanel.Controls.Add(btnDESC);
            employeePanel.Controls.Add(btnASC);
            employeePanel.Controls.Add(txtSearch);
            employeePanel.Controls.Add(cmbSearchCriteria);
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
            employeePanel.MouseDown += DragApplication;
            // 
            // btnDESC
            // 
            btnDESC.BackgroundImage = (Image)resources.GetObject("btnDESC.BackgroundImage");
            btnDESC.BackgroundImageLayout = ImageLayout.Stretch;
            btnDESC.Location = new Point(452, 254);
            btnDESC.Name = "btnDESC";
            btnDESC.Size = new Size(34, 29);
            btnDESC.TabIndex = 31;
            btnDESC.UseVisualStyleBackColor = true;
            btnDESC.Click += btnDESC_Click;
            // 
            // btnASC
            // 
            btnASC.BackgroundImage = (Image)resources.GetObject("btnASC.BackgroundImage");
            btnASC.BackgroundImageLayout = ImageLayout.Stretch;
            btnASC.Location = new Point(412, 254);
            btnASC.Name = "btnASC";
            btnASC.Size = new Size(34, 29);
            btnASC.TabIndex = 30;
            btnASC.UseVisualStyleBackColor = true;
            btnASC.Click += btnASC_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(130, 256);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(276, 27);
            txtSearch.TabIndex = 29;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbSearchCriteria
            // 
            cmbSearchCriteria.FormattingEnabled = true;
            cmbSearchCriteria.Items.AddRange(new object[] { "Name", "Email", "Phone", "Address" });
            cmbSearchCriteria.Location = new Point(16, 256);
            cmbSearchCriteria.Name = "cmbSearchCriteria";
            cmbSearchCriteria.Size = new Size(108, 28);
            cmbSearchCriteria.TabIndex = 28;
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
            employeeGridView.Location = new Point(0, 290);
            employeeGridView.Name = "employeeGridView";
            employeeGridView.ReadOnly = true;
            employeeGridView.RowHeadersWidth = 51;
            employeeGridView.Size = new Size(782, 303);
            employeeGridView.TabIndex = 1;
            employeeGridView.CellClick += EmployeeCellClick;
            // 
            // settingPanel
            // 
            settingPanel.BackColor = Color.White;
            settingPanel.Controls.Add(logout2_Btn);
            settingPanel.Controls.Add(changepassBtn);
            settingPanel.Controls.Add(profileBtn);
            settingPanel.Location = new Point(800, 50);
            settingPanel.Name = "settingPanel";
            settingPanel.Size = new Size(163, 146);
            settingPanel.TabIndex = 1;
            // 
            // logout2_Btn
            // 
            logout2_Btn.BackColor = Color.White;
            logout2_Btn.Controls.Add(flowLayoutPanel4);
            logout2_Btn.Controls.Add(label4);
            logout2_Btn.Cursor = Cursors.Hand;
            logout2_Btn.Location = new Point(3, 99);
            logout2_Btn.Name = "logout2_Btn";
            logout2_Btn.Size = new Size(157, 41);
            logout2_Btn.TabIndex = 7;
            logout2_Btn.Click += logoutBtn_Click;
            logout2_Btn.MouseEnter += logout2_Btn_MouseEnter;
            logout2_Btn.MouseLeave += logout2_Btn_MouseLeave;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Location = new Point(0, 51);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(250, 125);
            flowLayoutPanel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(49, 8);
            label4.Name = "label4";
            label4.Size = new Size(60, 24);
            label4.TabIndex = 3;
            label4.Text = "Log out";
            label4.Click += logoutBtn_Click;
            label4.MouseEnter += logout2_Btn_MouseEnter;
            label4.MouseLeave += logout2_Btn_MouseLeave;
            // 
            // changepassBtn
            // 
            changepassBtn.BackColor = Color.White;
            changepassBtn.Controls.Add(flowLayoutPanel3);
            changepassBtn.Controls.Add(label3);
            changepassBtn.Cursor = Cursors.Hand;
            changepassBtn.Location = new Point(3, 52);
            changepassBtn.Name = "changepassBtn";
            changepassBtn.Size = new Size(157, 41);
            changepassBtn.TabIndex = 6;
            changepassBtn.Click += changepassBtn_Click;
            changepassBtn.MouseEnter += changepassBtn_MouseEnter;
            changepassBtn.MouseLeave += changepassBtn_MouseLeave;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(0, 51);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(250, 125);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 9);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 3;
            label3.Text = "Change Password";
            label3.Click += changepassBtn_Click;
            label3.MouseEnter += changepassBtn_MouseEnter;
            label3.MouseLeave += changepassBtn_MouseLeave;
            // 
            // profileBtn
            // 
            profileBtn.BackColor = Color.White;
            profileBtn.Controls.Add(flowLayoutPanel2);
            profileBtn.Controls.Add(label2);
            profileBtn.Cursor = Cursors.Hand;
            profileBtn.Location = new Point(3, 6);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(157, 41);
            profileBtn.TabIndex = 5;
            profileBtn.Click += profileBtn_Click;
            profileBtn.MouseEnter += profileBtn_MouseEnter;
            profileBtn.MouseLeave += profileBtn_MouseLeave;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(0, 51);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(250, 125);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(58, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 24);
            label2.TabIndex = 3;
            label2.Text = "Profile";
            label2.Click += profileBtn_Click;
            label2.MouseEnter += profileBtn_MouseEnter;
            label2.MouseLeave += profileBtn_MouseLeave;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(982, 653);
            Controls.Add(settingPanel);
            Controls.Add(avtBtn);
            Controls.Add(employeePanel);
            Controls.Add(headerPanel);
            Controls.Add(navPanel);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            logoutBtn.ResumeLayout(false);
            logoutBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)avtBtn).EndInit();
            employeePanel.ResumeLayout(false);
            employeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)printEmBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteEmBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)editEmBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)addEmBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).EndInit();
            settingPanel.ResumeLayout(false);
            logout2_Btn.ResumeLayout(false);
            logout2_Btn.PerformLayout();
            changepassBtn.ResumeLayout(false);
            changepassBtn.PerformLayout();
            profileBtn.ResumeLayout(false);
            profileBtn.PerformLayout();
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
        private Panel logoutBtn;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox avtBtn;
        private Panel settingPanel;
        private Panel profileBtn;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private Panel logout2_Btn;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label4;
        private Panel changepassBtn;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label3;
        private TextBox txtSearch;
        private ComboBox cmbSearchCriteria;
        private Button btnDESC;
        private Button btnASC;
    }
}