using LiveCharts.Wpf;
using LiveCharts;
using Microsoft.IdentityModel.Tokens;
using PdfSharp;
using PdfSharp.Charting;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PiStoreManagementSytem.DAO;
using PiStoreManagementSytem.DTO;
using PiStoreManagementSytem.modal;
using System.Buffers;
using System.Data;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms.DataVisualization.Charting;

namespace PiStoreManagementSytem
{
    public partial class AdminForm : Form
    {
        private Client currentClientBill;
        private int clientSelectedID;
        private int orderSelectedID;
        private DataGridViewCellCollection currentClientCell;
        private int id;
        bool isPanelExpanded = true;
        bool isSettingEnable = false;
        int panelMaxWidth = 200;
        int panelMinWidth = 75;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private List<CartItem> cartItems = new List<CartItem>();
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private DataTable currentSearchResult;
        private DataTable currentOrderResult;
        public AdminForm(int id)
        {
            InitializeComponent();
            Init();
            this.id = id;
        }

        private void Init()
        {
            UnactiveAllPanel();

            menuBtn.Click += new EventHandler(MenuBtn_Click);
            timerPanel.Tick += new EventHandler(TimerPanel_Tick);
            this.FormClosing += new FormClosingEventHandler(AdminForm_FormClosing);
            this.FormBorderStyle = FormBorderStyle.None;
            homeImg.BackgroundImage = Constants.Constants.home_active;
            homeLabel.ForeColor = Constants.Constants.activeColor;

            settingPanel.Hide();

            UnactiveAllButton();
            HideAllPanel();
            homePanel.Show();

            homeImg.BackgroundImage = Constants.Constants.home_active;
            homeLabel.ForeColor = Constants.Constants.activeColor;

            cmbChartType.SelectedIndex = 0;
            chart1.Visible = true;
        }

        private void DragApplication(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            timerPanel.Start();
        }

        private void TimerPanel_Tick(object sender, EventArgs e)
        {
            if (isPanelExpanded)
            {
                navPanel.Width -= 10;
                if (navPanel.Width <= panelMinWidth)
                {
                    isPanelExpanded = false;
                    timerPanel.Stop();
                }
            }
            else
            {
                navPanel.Width += 10;
                if (navPanel.Width >= panelMaxWidth)
                {
                    isPanelExpanded = true;
                    timerPanel.Stop();
                }
            }
        }

        private void UnactiveAllButton()
        {
            homeImg.BackgroundImage = Constants.Constants.home;
            employeeImg.BackgroundImage = Constants.Constants.employee;
            clientImg.BackgroundImage = Constants.Constants.client;
            productImg.BackgroundImage = Constants.Constants.product;
            orderImg.BackgroundImage = Constants.Constants.order;
            billImg.BackgroundImage = Constants.Constants.bill;

            homeLabel.ForeColor = Constants.Constants.defaultColor;
            employeeLabel.ForeColor = Constants.Constants.defaultColor;
            clientLabel.ForeColor = Constants.Constants.defaultColor;
            productLabel.ForeColor = Constants.Constants.defaultColor;
            orderLabel.ForeColor = Constants.Constants.defaultColor;
            billLabel.ForeColor = Constants.Constants.defaultColor;
        }

        private void HideAllPanel()
        {
            employeePanel.Hide();
            clientPanel.Hide();
            productPanel.Hide();
            orderPanel.Hide();
            newOrderPanel.Hide();
            billPanel.Hide();
            homePanel.Hide();

            cmbOrderList.Items.Clear();
        }

        private void UnactiveAllPanel()
        {
            employeePanel.Hide();
        }
        private void HomeClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            HideAllPanel();
            homePanel.Show();

            homeImg.BackgroundImage = Constants.Constants.home_active;
            homeLabel.ForeColor = Constants.Constants.activeColor;

            cmbChartType.SelectedIndex = 0;
            chart1.Visible = true;
        }
        private void EmployeeClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            HideAllPanel();
            employeePanel.Show();

            employeeImg.BackgroundImage = Constants.Constants.employee_active;
            employeeLabel.ForeColor = Constants.Constants.activeColor;


            employeeGridView.DataSource = LoadEmployeeTable();
            employeeGridView.Columns["Password"].Visible = false;

            SetEmployeeButtonActive(false);
        }

        private void ClientClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            HideAllPanel();
            clientPanel.Show();

            clientImg.BackgroundImage = Constants.Constants.client_active;
            clientLabel.ForeColor = Constants.Constants.activeColor;

            clientGridView.DataSource = LoadClientTable();

            SetClientButtonActive(false);
        }

        private void ProductClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            HideAllPanel();
            productPanel.Show();

            productImg.BackgroundImage = Constants.Constants.product_active;
            productLabel.ForeColor = Constants.Constants.activeColor;

            productGridView.DataSource = LoadProductTable();

            SetProductButtonActive(false);
        }

        private void OrderClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            HideAllPanel();
            orderPanel.Show();

            orderImg.BackgroundImage = Constants.Constants.order_active;
            orderLabel.ForeColor = Constants.Constants.activeColor;

            LoadOrder();
        }

        private void BillClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            HideAllPanel();
            billPanel.Show();

            billImg.BackgroundImage = Constants.Constants.bill_active;
            billLabel.ForeColor = Constants.Constants.activeColor;

            LoadOrderList();
        }

        private void HomeHover(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.LightGray;
        }

        private void HomeLeave(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.White;
        }

        private void EmployeeHover(object sender, EventArgs e)
        {
            employeeBtn.BackColor = Color.LightGray;
        }

        private void EmployeeLeave(object sender, EventArgs e)
        {
            employeeBtn.BackColor = Color.White;
        }
        private void ClientHover(object sender, EventArgs e)
        {
            clientBtn.BackColor = Color.LightGray;
        }

        private void ClientLeave(object sender, EventArgs e)
        {
            clientBtn.BackColor = Color.White;
        }

        private void ProductHover(object sender, EventArgs e)
        {
            productBtn.BackColor = Color.LightGray;
        }

        private void ProductLeave(object sender, EventArgs e)
        {
            productBtn.BackColor = Color.White;
        }

        private void OrderHover(object sender, EventArgs e)
        {
            orderBtn.BackColor = Color.LightGray;
        }

        private void OrderLeave(object sender, EventArgs e)
        {
            orderBtn.BackColor = Color.White;
        }

        private void BillHover(object sender, EventArgs e)
        {
            billBtn.BackColor = Color.LightGray;
        }

        private void BillLeave(object sender, EventArgs e)
        {
            billBtn.BackColor = Color.White;
        }

        private DataTable LoadEmployeeTable()
        {
            return EmployeeDAO.Instance.LoadEmployeeTable();
        }

        private DataTable LoadClientTable()
        {
            return ClientDAO.Instance.LoadClientTable();
        }

        private DataTable LoadProductTable()
        {
            return ProductDAO.Instance.LoadProductTable();
        }

        private DataTable LoadOrderTable()
        {
            return OrderDAO.Instance.LoadOrderTable();
        }

        private void EmployeeCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = employeeGridView.Rows[e.RowIndex];

                if (row.Cells["ID"].Value != null && !string.IsNullOrEmpty(row.Cells["ID"].Value.ToString()))
                {
                    SetEmployeeButtonActive(true);
                }
                else
                {
                    SetEmployeeButtonActive(false);
                }
            }
        }

        private void SetEmployeeButtonActive(bool active)
        {
            if (active)
            {
                editEmBtn.Enabled = true;
                deleteEmBtn.Enabled = true;
                editEmBtn.BackgroundImage = Constants.Constants.edit;
                deleteEmBtn.BackgroundImage = Constants.Constants.delete;
                editEmLabel.ForeColor = Constants.Constants.editColor;
                deleteEmLabel.ForeColor = Constants.Constants.deleteColor;
            }
            else
            {
                editEmBtn.Enabled = false;
                deleteEmBtn.Enabled = false;
                editEmBtn.BackgroundImage = Constants.Constants.edit_unactive;
                deleteEmBtn.BackgroundImage = Constants.Constants.delete_unactive;
                editEmLabel.ForeColor = Color.Silver;
                deleteEmLabel.ForeColor = Color.Silver;
            }
        }

        private void SetClientButtonActive(bool active)
        {
            if (active)
            {
                editClientBtn.Enabled = true;
                deleteClientBtn.Enabled = true;
                editClientBtn.BackgroundImage = Constants.Constants.edit;
                deleteClientBtn.BackgroundImage = Constants.Constants.delete;
                editClientLabel.ForeColor = Constants.Constants.editColor;
                deleteClientLabel.ForeColor = Constants.Constants.deleteColor;
            }
            else
            {
                editClientBtn.Enabled = false;
                deleteClientBtn.Enabled = false;
                editClientBtn.BackgroundImage = Constants.Constants.edit_unactive;
                deleteClientBtn.BackgroundImage = Constants.Constants.delete_unactive;
                editClientLabel.ForeColor = Color.Silver;
                deleteClientLabel.ForeColor = Color.Silver;
            }
        }

        private void SetProductButtonActive(bool active)
        {
            if (active)
            {
                editProductBtn.Enabled = true;
                deleteProductBtn.Enabled = true;
                editProductBtn.BackgroundImage = Constants.Constants.edit;
                deleteProductBtn.BackgroundImage = Constants.Constants.delete;
                editProductLabel.ForeColor = Constants.Constants.editColor;
                deleteProductLabel.ForeColor = Constants.Constants.deleteColor;
            }
            else
            {
                editProductBtn.Enabled = false;
                deleteProductBtn.Enabled = false;
                editProductBtn.BackgroundImage = Constants.Constants.edit_unactive;
                deleteProductBtn.BackgroundImage = Constants.Constants.delete_unactive;
                editProductLabel.ForeColor = Color.Silver;
                deleteProductLabel.ForeColor = Color.Silver;
            }
        }
        private void editEmBtn_Click(object sender, EventArgs e)
        {
            if (employeeGridView.CurrentRow != null && employeeGridView.CurrentRow.Cells["ID"].Value != null)
            {
                EmployeeForm employeeForm = new EmployeeForm(this);
                employeeForm.imgEmployee.BackgroundImage = Constants.Constants.edit_employee;
                employeeForm.saveEmBtn.Visible = true;
                employeeForm.resetEmBtn.Visible = true;
                employeeForm.addEmBtn.Visible = false;

                DataGridViewRow row = employeeGridView.CurrentRow;
                int employeeID = Convert.ToInt32(row.Cells["ID"].Value);
                string employeeName = row.Cells["Name"].Value.ToString();
                string employeeEmail = row.Cells["Email"].Value.ToString();
                string employeePhone = row.Cells["Phone"].Value.ToString();
                string employeeAddress = row.Cells["Address"].Value.ToString();
                decimal employeeSalary = Convert.ToDecimal(row.Cells["Salary"].Value);
                DateTime hireDate = Convert.ToDateTime(row.Cells["HireDate"].Value);

                employeeForm.idTxt.Text = employeeID.ToString();
                employeeForm.fullNameTxt.Text = employeeName;
                employeeForm.emailTxt.Text = employeeEmail;
                employeeForm.phoneTxt.Text = employeePhone;
                employeeForm.addressTxt.Text = employeeAddress;
                employeeForm.salaryTxt.Value = employeeSalary;
                employeeForm.hDatePicker.Value = hireDate;

                string[] names = employeeName.Split(" ");
                string fName = names.Last();
                string lName = "";
                int index = employeeName.IndexOf(fName) - 1;
                for (int i = 0; i < index; i++)
                {
                    lName += employeeName[i];
                }

                employeeForm.fNameTxt.Text = fName;
                employeeForm.lNameTxt.Text = lName;

                Employee employee = new Employee(employeeID, employeeName, employeeEmail, employeePhone, employeeAddress, employeeSalary, hireDate);

                employeeForm.currentEm = employee;
                employeeForm.ShowDialog();
            }

        }

        private void addEmBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm(this);
            employeeForm.imgEmployee.BackgroundImage = Constants.Constants.add_employee;
            employeeForm.saveEmBtn.Visible = false;
            employeeForm.resetEmBtn.Visible = false;
            employeeForm.addEmBtn.Visible = true;

            employeeForm.ShowDialog();
        }

        public void UpdateEmployeeGridView()
        {
            employeeGridView.DataSource = LoadEmployeeTable();
        }

        public void UpdateClientGridView()
        {
            clientGridView.DataSource = LoadClientTable();
            clientOrderGridView.DataSource = clientGridView.DataSource;
        }
        public void UpdateProductGridView()
        {
            productGridView.DataSource = LoadProductTable();
            productOrderGridView.DataSource = productGridView.DataSource;
        }

        private void deleteEmBtn_Click(object sender, EventArgs e)
        {
            if (employeeGridView.CurrentRow != null && employeeGridView.CurrentRow.Cells["ID"].Value != null)
            {
                int employeeID = Convert.ToInt32(employeeGridView.CurrentRow.Cells["ID"].Value);
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (CanDeleteEmployee(employeeID))
                    {
                        if (DeleteEmployee(employeeID))
                        {
                            UpdateEmployeeGridView();
                            DisplaySuccess("Successfully Delete Employee!");
                        }
                        else
                        {
                            DisplayError("An error has orcurred while deleting employee! Please try again!");
                        }
                    }
                    else
                    {
                        DisplayError("Can not delete an Employee had orders!");
                    }

                }
            }
        }
        private bool CanDeleteEmployee(int id)
        {
            return EmployeeDAO.Instance.CanDeleteEmployee(id);
        }
        private bool DeleteEmployee(int id)
        {
            return EmployeeDAO.Instance.DeleteEmployee(id);
        }

        private void DisplayError(string msg)
        {
            ErrorModal errorModal = new ErrorModal();
            errorModal.errorTxt.Text = msg;
            errorModal.Show();
        }

        private void DisplaySuccess(string msg)
        {
            SuccessModal successModal = new SuccessModal();
            successModal.successTxt.Text = msg;
            successModal.Show();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void printEmBtn_Click(object sender, EventArgs e)
        {
            if (employeeGridView.Rows.Count > 0)
                PrintPDF(employeeGridView, "Employee");
        }

        private void PrintPDF(DataGridView gridView, string name, DataGridViewCellCollection values = null, Client client = null, Order order = null)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = $"Company {name} List";

            PdfPage page = document.AddPage();

            page.Size = PageSize.A4;
            page.Orientation = PageOrientation.Landscape;

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont titleFont = new XFont("Verdana", 24, XFontStyleEx.Bold);
            XFont companyFont = new XFont("Verdana", 14, XFontStyleEx.Bold);
            XFont headerFont = new XFont("Verdana", 12, XFontStyleEx.Bold);
            XFont cellFont = new XFont("Verdana", 10, XFontStyleEx.Regular);
            XFont infoFont = new XFont("Verdana", 10, XFontStyleEx.Bold);

            Bitmap logoBitmap = Properties.Resources.logo;

            using (MemoryStream stream = new MemoryStream())
            {
                logoBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                XImage logo = XImage.FromStream(stream);

                if (name != "Bill")
                {
                    gfx.DrawImage(logo, 20, 0, 200, 200);

                    gfx.DrawString($"{name} List", titleFont, XBrushes.Black,
                    new XRect(page.Height, 85, page.Width - 160, 50), XStringFormats.TopLeft);
                    gfx.DrawString("Company: Pi Store Sneaker", companyFont, XBrushes.Black,
                    new XRect(50, 190, page.Width - 100, 50), XStringFormats.TopLeft);
                }
                else
                {
                    gfx.DrawImage(logo, page.Height / 2 + 50, 0, 200, 200);
                    gfx.DrawString("PI STORE SNEAKER", companyFont, XBrushes.Black,
                    new XRect(page.Height / 2 + 70, 190, page.Width - 100, 50), XStringFormats.TopLeft);
                }

            }

            double tableTop = 250;
            double rowHeight = 20;
            double pageWidth = page.Width;
            double colXPos = 50;

            if (name == "ClientOrder")
            {
                double headerHeight = 40;
                gfx.DrawRectangle(XBrushes.LightGray, colXPos, tableTop, pageWidth - 100, headerHeight);
                gfx.DrawString("Client Order", headerFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop + 15, pageWidth - 100, headerHeight), XStringFormats.TopLeft);

                tableTop += headerHeight + 10;

                gfx.DrawString("Client Name:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(values["Name"].Value.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight;

                gfx.DrawString("Email:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(values["Email"].Value.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight;

                gfx.DrawString("Phone:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(values["Phone"].Value.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight;

                gfx.DrawString("Address:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(values["Address"].Value.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight + 10;

                gfx.DrawLine(new XPen(XColors.Black, 1), colXPos, tableTop, pageWidth - 50, tableTop);

                tableTop += 50;
            }
            else if (name == "OrderItem")
            {
                double headerHeight = 40;
                gfx.DrawRectangle(XBrushes.LightGray, colXPos, tableTop, pageWidth - 100, headerHeight);
                gfx.DrawString("Client Order", headerFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop + 15, pageWidth - 100, headerHeight), XStringFormats.TopLeft);

                tableTop += headerHeight + 10;

                gfx.DrawString("Client Name:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(client.Name.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight;

                gfx.DrawString("Email:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(client.Email.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight;

                gfx.DrawString("Phone:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(client.Phone.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight;

                gfx.DrawString("Address:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(client.Address.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight + 10;

                gfx.DrawLine(new XPen(XColors.Black, 1), colXPos, tableTop, pageWidth - 50, tableTop);

                tableTop += 50;
            }

            else if (name == "Bill")
            {
                double headerHeight = 40;
                gfx.DrawRectangle(XBrushes.LightGray, colXPos, tableTop, pageWidth - 100, headerHeight);
                gfx.DrawString("INVOICE", headerFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop + 15, pageWidth - 60, headerHeight), XStringFormats.TopLeft);

                gfx.DrawString($"{order.OrderDate.ToShortDateString()}", headerFont, XBrushes.Black,
                    new XRect(page.Height + 80, tableTop + 15, page.Width - 160, 50), XStringFormats.TopLeft);

                tableTop += headerHeight + 10;

                gfx.DrawString("Client Name:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(client.Name.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight;

                gfx.DrawString("Email:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(client.Email.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight;

                gfx.DrawString("Phone:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(client.Phone.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight;

                gfx.DrawString("Address:", infoFont, XBrushes.Black,
                    new XRect(colXPos + 25, tableTop, 200, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(client.Address.ToString(), cellFont, XBrushes.Black,
                    new XRect(colXPos + 150, tableTop, pageWidth - 100, rowHeight), XStringFormats.TopLeft);

                tableTop += rowHeight + 10;

                gfx.DrawLine(new XPen(XColors.Black, 1), colXPos, tableTop, pageWidth - 50, tableTop);

                tableTop += 50;
            }


            double totalGridViewWidth = 0;
            foreach (DataGridViewColumn column in gridView.Columns)
            {
                if (column.Name != "ID" && column.Name != "Password")
                {
                    totalGridViewWidth += column.Width;
                }
            }

            double scaleFactor = (pageWidth - 100) / totalGridViewWidth;

            XPen borderPen = new XPen(XColors.Black, 1);
            gfx.DrawRectangle(XBrushes.LightGray, colXPos, tableTop, totalGridViewWidth * scaleFactor, rowHeight);

            foreach (DataGridViewColumn column in gridView.Columns)
            {
                if (column.Name != "ID" && column.Name != "Password")
                {
                    double scaledColWidth = column.Width * scaleFactor;
                    gfx.DrawString(column.HeaderText, headerFont, XBrushes.Black,
                        new XRect(colXPos, tableTop, scaledColWidth, rowHeight), XStringFormats.Center);

                    gfx.DrawRectangle(borderPen, colXPos, tableTop, scaledColWidth, rowHeight);
                    colXPos += scaledColWidth;
                }
            }

            tableTop += rowHeight;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (tableTop + rowHeight > page.Height - 50)
                {
                    tableTop = 250;
                    page = document.AddPage();
                    page.Size = PageSize.A4;
                    page.Orientation = PageOrientation.Landscape;
                    gfx = XGraphics.FromPdfPage(page);

                    using (MemoryStream stream = new MemoryStream())
                    {
                        logoBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        XImage logo = XImage.FromStream(stream);

                        gfx.DrawImage(logo, 20, 0, 200, 200);
                        gfx.DrawString($"{name} List", titleFont, XBrushes.Black,
                            new XRect(page.Height, 85, page.Width - 160, 50), XStringFormats.TopLeft);

                        gfx.DrawString("Company: Pi Store Sneaker", companyFont, XBrushes.Black,
                            new XRect(50, 190, page.Width - 100, 50), XStringFormats.TopLeft);
                    }

                    colXPos = 50;
                    gfx.DrawRectangle(XBrushes.LightGray, colXPos, tableTop, totalGridViewWidth * scaleFactor, rowHeight);
                    foreach (DataGridViewColumn column in gridView.Columns)
                    {
                        if (column.Name != "ID" && column.Name != "Password")
                        {
                            double scaledColWidth = column.Width * scaleFactor;
                            gfx.DrawString(column.HeaderText, headerFont, XBrushes.Black,
                                new XRect(colXPos, tableTop, scaledColWidth, rowHeight), XStringFormats.Center);
                            gfx.DrawRectangle(borderPen, colXPos, tableTop, scaledColWidth, rowHeight);
                            colXPos += scaledColWidth;
                        }
                    }
                    tableTop += rowHeight;
                }

                colXPos = 50;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (gridView.Columns[cell.ColumnIndex].Name != "ID" && gridView.Columns[cell.ColumnIndex].Name != "Password")
                    {
                        double scaledColWidth = gridView.Columns[cell.ColumnIndex].Width * scaleFactor;
                        string cellValue = "";
                        if (name == "Employee")
                        {
                            if (cell.ColumnIndex == gridView.Columns["HireDate"].Index)
                                cellValue = Convert.ToDateTime(cell.Value).ToString("M/d/yyyy");
                            else
                                cellValue = cell.Value?.ToString();
                        }
                        else
                        {
                            cellValue = cell.Value?.ToString() ?? "";
                        }

                        string truncatedText = TruncateText(gfx, cellValue, cellFont, scaledColWidth - 10);

                        gfx.DrawString(truncatedText, cellFont, XBrushes.Black,
                            new XRect(colXPos, tableTop, scaledColWidth, rowHeight), XStringFormats.Center);

                        gfx.DrawRectangle(borderPen, colXPos, tableTop, scaledColWidth, rowHeight);
                        colXPos += scaledColWidth;
                    }
                }
                tableTop += rowHeight;
            }
            if (name == "Bill")
            {
                string total = string.Format("{0:N0} VND", order.TotalPrice);
                tableTop += 20;
                gfx.DrawString($"Total Price: {total}", companyFont, XBrushes.Black,
                                new XRect(50, tableTop, page.Width - 100, 50), XStringFormats.CenterRight);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = $"Save {name} PDF";
            saveFileDialog.FileName = $"{name}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                document.Save(filePath);
                document.Close();

                MessageBox.Show($"Print {name} Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"An error had occurred when printing PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string TruncateText(XGraphics gfx, string text, XFont font, double maxWidth)
        {
            if (gfx.MeasureString(text, font).Width <= maxWidth)
            {
                return text;
            }

            string truncatedText = text;
            while (gfx.MeasureString(truncatedText + "...", font).Width > maxWidth && truncatedText.Length > 0)
            {
                truncatedText = truncatedText.Substring(0, truncatedText.Length - 1);
            }

            return truncatedText + "...";
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void avtBtn_Click(object sender, EventArgs e)
        {
            if (!isSettingEnable)
            {
                isSettingEnable = true;
                settingPanel.Show();
                settingPanel.BringToFront();
            }
            else
            {
                isSettingEnable = false;
                settingPanel.Hide();
            }
        }

        private void profileBtn_MouseEnter(object sender, EventArgs e)
        {
            profileBtn.BackColor = Color.LightGray;
        }

        private void profileBtn_MouseLeave(object sender, EventArgs e)
        {
            profileBtn.BackColor = Color.White;
        }

        private void changepassBtn_MouseEnter(object sender, EventArgs e)
        {
            changepassBtn.BackColor = Color.LightGray;
        }

        private void changepassBtn_MouseLeave(object sender, EventArgs e)
        {
            changepassBtn.BackColor = Color.White;
        }

        private void logout2_Btn_MouseEnter(object sender, EventArgs e)
        {
            logout2_Btn.BackColor = Color.LightGray;
        }

        private void logout2_Btn_MouseLeave(object sender, EventArgs e)
        {
            logout2_Btn.BackColor = Color.White;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(id);
            profile.Show();
        }

        private void changepassBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(id);
            changePasswordForm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            string searchCriteria = cmbSearchCriteria.SelectedItem?.ToString();

            DataTable employeeTable = LoadEmployeeTable();

            if (string.IsNullOrEmpty(searchCriteria)) return;

            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dv = new DataView(employeeTable);
                dv.RowFilter = $"{searchCriteria} LIKE '%{searchValue}%'";
                currentSearchResult = dv.ToTable();
                employeeGridView.DataSource = currentSearchResult;
            }
            else
            {
                currentSearchResult = employeeTable;
                employeeGridView.DataSource = employeeTable;
            }
        }

        private void btnASC_Click(object sender, EventArgs e)
        {
            SortData("ASC");
        }

        private void btnDESC_Click(object sender, EventArgs e)
        {
            SortData("DESC");
        }

        private void SortData(string order)
        {
            string sortCriteria = cmbSearchCriteria.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(sortCriteria))
            {
                if (currentSearchResult != null)
                {
                    DataView dv = new DataView(currentSearchResult);
                    dv.Sort = $"{sortCriteria} {order}";
                    employeeGridView.DataSource = dv;
                }
                else
                {
                    DataTable employeeTable = LoadEmployeeTable();
                    DataView dv = new DataView(employeeTable);

                    dv.Sort = $"{sortCriteria} {order}";

                    employeeGridView.DataSource = dv;
                }

            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            int cornerRadius = 30;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(this.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, this.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void csvEmBtn_Click(object sender, EventArgs e)
        {
            if (employeeGridView.Rows.Count <= 0) { return; }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "Employee_Export.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToCSV(employeeGridView, sfd.FileName);
            }
        }

        public void ExportDataGridViewToCSV(DataGridView dataGridView, string filePath)
        {
            try
            {
                StringBuilder csvContent = new StringBuilder();

                bool firstColumn = true;
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    if (dataGridView.Columns[i].Name != "Password")
                    {
                        if (!firstColumn)
                        {
                            csvContent.Append(",");
                        }
                        csvContent.Append(dataGridView.Columns[i].HeaderText);
                        firstColumn = false;
                    }
                }
                csvContent.AppendLine();

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        firstColumn = true;
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            if (dataGridView.Columns[i].Name != "Password")
                            {
                                if (!firstColumn)
                                {
                                    csvContent.Append(",");
                                }
                                var cellValue = row.Cells[i].Value?.ToString().Replace(",", "");
                                if (dataGridView.Columns[i].Name == "Phone")
                                    cellValue = "(+84) " + cellValue.Substring(1, cellValue.Length - 1);
                                csvContent.Append(cellValue);
                                firstColumn = false;
                            }
                        }
                        csvContent.AppendLine();
                    }
                }

                File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
                MessageBox.Show("Export CSV Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred when exporting CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void csvClientBtn_Click(object sender, EventArgs e)
        {
            if (clientGridView.Rows.Count <= 0) { return; }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "Client_Export.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToCSV(clientGridView, sfd.FileName);
            }
        }

        private void printClientBtn_Click(object sender, EventArgs e)
        {
            if (clientGridView.Rows.Count > 0)
                PrintPDF(clientGridView, "Client");
        }

        private void searchClientTxt_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchClientTxt.Text.Trim();

            DataTable clientTable = LoadClientTable();


            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dv = new DataView(clientTable);
                dv.RowFilter = $"Phone LIKE '%{searchValue}%'";
                currentSearchResult = dv.ToTable();
                clientGridView.DataSource = currentSearchResult;
            }
            else
            {
                currentSearchResult = clientTable;
                employeeGridView.DataSource = clientTable;
            }
        }



        private void clientGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = clientGridView.Rows[e.RowIndex];

                if (row.Cells["ID"].Value != null && !string.IsNullOrEmpty(row.Cells["ID"].Value.ToString()))
                {
                    int clientId = Convert.ToInt32(clientGridView.Rows[e.RowIndex].Cells["ID"].Value);
                    clientSelectedID = clientId;
                    LoadRecentOrdersByClient(clientId);
                    currentClientCell = clientGridView.Rows[e.RowIndex].Cells;
                    SetClientButtonActive(true);
                }
                else
                {
                    SetClientButtonActive(false);
                }
            }
        }

        private void LoadRecentOrdersByClient(int clientId)
        {
            DataTable orderTable = GetRecentOrdersByClient(clientId);
            recentOrderGridView.DataSource = orderTable;
            DataView dv = new DataView(orderTable);

            dv.Sort = "OrderDate DESC";
        }

        private DataTable GetRecentOrdersByClient(int clientId)
        {
            return OrderDAO.Instance.LoadOrderTableByClientID(clientId);
        }

        private void orderDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (recentOrderGridView.DataSource == null || clientGridView.DataSource == null) return;

            DataTable table = (DataTable)GetRecentOrdersByClient(clientSelectedID);
            DataView dv = new DataView(table);

            dv.RowFilter = $"OrderDate = #{orderDatePicker.Value:MM/dd/yyyy}#";
            dv.Sort = "OrderDate DESC";

            currentSearchResult = dv.ToTable();
            recentOrderGridView.DataSource = currentSearchResult;
        }

        private void csvRecentClientOrderBtn_Click(object sender, EventArgs e)
        {
            if (recentOrderGridView.Rows.Count <= 0) { return; }


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "ClientOrder_Export.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToCSV(recentOrderGridView, sfd.FileName);
            }
        }

        private void printRecentClientOrderBtn_Click(object sender, EventArgs e)
        {
            if (recentOrderGridView.DataSource == null) return;
            if (recentOrderGridView.Rows.Count > 0)
                PrintPDF(recentOrderGridView, "ClientOrder", currentClientCell);
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm(this);

            clientForm.ShowDialog();
        }

        private void editClientBtn_Click(object sender, EventArgs e)
        {
            if (clientGridView.CurrentRow != null && clientGridView.CurrentRow.Cells["ID"].Value != null)
            {

                DataGridViewRow row = clientGridView.CurrentRow;

                int clientID = Convert.ToInt32(row.Cells["ID"].Value);
                string clientName = row.Cells["Name"].Value.ToString();
                string clientEmail = row.Cells["Email"].Value.ToString();
                string clientPhone = row.Cells["Phone"].Value.ToString();
                string clientAddress = row.Cells["Address"].Value.ToString();

                Client employee = new Client(clientID, clientName, clientEmail, clientPhone, clientAddress);

                ClientForm clientForm = new ClientForm(this, employee);

                clientForm.txtClientName.Text = clientName;
                clientForm.txtEmail.Text = clientEmail;
                clientForm.txtPhone.Text = clientPhone;
                clientForm.txtAddress.Text = clientAddress;

                clientForm.ShowDialog();
            }
        }

        private void deleteClientBtn_Click(object sender, EventArgs e)
        {
            if (clientGridView.CurrentRow != null && clientGridView.CurrentRow.Cells["ID"].Value != null)
            {
                int clientID = Convert.ToInt32(clientGridView.CurrentRow.Cells["ID"].Value);
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete this Client?", "Delete Employee", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (CanDeleteClient(clientID))
                    {
                        if (DeleteClient(clientID))
                        {
                            UpdateClientGridView();
                            DisplaySuccess("Successfully Delete Client!");
                        }
                        else
                        {
                            DisplayError("An error has orcurred while deleting client! Please try again!");
                        }
                    }
                    else
                    {
                        DisplayError("Can not delete an Client had orders!");
                    }
                }
            }
        }

        private bool CanDeleteClient(int id)
        {
            return ClientDAO.Instance.CanDeleteClient(id);
        }
        private bool DeleteClient(int id)
        {
            return ClientDAO.Instance.DeleteClient(id);
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtProductSearch.Text.Trim();

            DataTable productTable = LoadProductTable();

            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dv = new DataView(productTable);
                dv.RowFilter = $"Name LIKE '%{searchValue}%'";
                currentSearchResult = dv.ToTable();
                productGridView.DataSource = currentSearchResult;
            }
            else
            {
                currentSearchResult = productTable;
                productGridView.DataSource = productTable;
            }
        }

        private void printProductBtn_Click(object sender, EventArgs e)
        {
            if (productGridView.DataSource != null)
                PrintPDF(productGridView, "Product");
        }

        private void csvProductBtn_Click(object sender, EventArgs e)
        {
            if (productGridView.Rows.Count <= 0) { return; }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "Product_Export.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToCSV(productGridView, sfd.FileName);
            }
        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = productGridView.Rows[e.RowIndex];

                if (row.Cells["ID"].Value != null && !string.IsNullOrEmpty(row.Cells["ID"].Value.ToString()))
                {
                    SetProductButtonActive(true);
                }
                else
                {
                    SetProductButtonActive(false);
                }
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(this);

            productForm.ShowDialog();
        }

        private void editProductBtn_Click(object sender, EventArgs e)
        {
            if (productGridView.CurrentRow != null && productGridView.CurrentRow.Cells["ID"].Value != null)
            {
                DataGridViewRow row = productGridView.CurrentRow;
                int productID = Convert.ToInt32(row.Cells["ID"].Value);
                string productName = row.Cells["Name"].Value.ToString();
                string productDescription = row.Cells["Description"].Value.ToString();
                decimal productPrice = Convert.ToDecimal(row.Cells["Price"].Value);
                int productQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                ProductForm productForm = new ProductForm(this);

                productForm.productID = productID;
                productForm.txtName.Text = productName;
                productForm.txtDescription.Text = productDescription;
                productForm.numPrice.Value = productPrice;
                productForm.numQuantity.Value = productQuantity;

                productForm.ShowDialog();
            }
        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            if (productGridView.CurrentRow != null && productGridView.CurrentRow.Cells["ID"].Value != null)
            {
                int productID = Convert.ToInt32(productGridView.CurrentRow.Cells["ID"].Value);
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (CanDeleteProduct(productID))
                    {
                        if (DeleteProduct(productID))
                        {
                            UpdateProductGridView();
                            DisplaySuccess("Successfully Delete Product!");
                        }
                        else
                        {
                            DisplayError("An error has orcurred while deleting product! Please try again!");
                        }
                    }
                    else
                    {
                        DisplayError("Can not delete a Product had orders!");
                    }

                }
            }
        }

        private bool CanDeleteProduct(int id)
        {
            return ProductDAO.Instance.CanDeleteProduct(id);
        }
        private bool DeleteProduct(int id)
        {
            return ProductDAO.Instance.DeleteProduct(id);
        }

        private void LoadOrder()
        {
            orderGridView.AutoGenerateColumns = true;
            orderGridView.DataSource = LoadOrderTable();

            orderGridView.Columns[2].HeaderText = "ClientName";
            orderGridView.Columns[3].HeaderText = "ClientPhone";

            currentOrderResult = (DataTable)orderGridView.DataSource;
        }

        private void txtOrderSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtOrderSearch.Text.Trim();
            string searchCriteria = cmbOrderCriteria.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(searchCriteria)) return;

            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dv = new DataView(currentOrderResult);
                dv.RowFilter = $"{searchCriteria} LIKE '%{searchValue}%'";

                currentSearchResult = dv.ToTable();
                orderGridView.DataSource = currentSearchResult;
            }
            else
            {
                LoadOrder();
            }
        }

        private void orderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = orderGridView.Rows[e.RowIndex];

                if (row.Cells["ID"].Value != null && !string.IsNullOrEmpty(row.Cells["ID"].Value.ToString()))
                {
                    int orderId = Convert.ToInt32(orderGridView.Rows[e.RowIndex].Cells["ID"].Value);
                    orderSelectedID = orderId;
                    orderItemGridView.DataSource = LoadOrderItemByID(orderId);
                }
            }
        }

        private DataTable LoadOrderItemByID(int orderID)
        {
            DataTable orderTable = LoadOrderItemTable(orderID);
            return orderTable;
        }

        private DataTable LoadOrderItemTable(int orderID)
        {
            return OrderItemDAO.Instance.LoadOrderItemByID(orderID);
        }

        private void txtOrderItemSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtOrderItemSearch.Text.Trim();

            DataTable orderTable = LoadOrderItemTable(orderSelectedID);

            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dv = new DataView(orderTable);
                dv.RowFilter = $"ProductName LIKE '%{searchValue}%'";
                currentSearchResult = dv.ToTable();
                orderItemGridView.DataSource = dv;
            }
            else
            {
                currentSearchResult = orderTable;
                orderItemGridView.DataSource = orderTable;
            }
        }

        private void printOrderBtn_Click(object sender, EventArgs e)
        {
            if (orderGridView.Rows.Count > 0)
                PrintPDF(orderGridView, "Order");
        }

        private void csvOderBtn_Click(object sender, EventArgs e)
        {
            if (orderGridView.Rows.Count <= 0) { return; }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "Order_Export.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToCSV(orderGridView, sfd.FileName);
            }
        }

        private void csvOrderItemBtn_Click(object sender, EventArgs e)
        {
            if (orderItemGridView.Rows.Count <= 0) { return; }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "OrderItem_Export.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToCSV(orderItemGridView, sfd.FileName);
            }
        }

        private void printOrderItemBtn_Click(object sender, EventArgs e)
        {
            if (orderItemGridView.Rows.Count > 0)
            {
                Client client = ClientDAO.Instance.GetClientByPhone(orderGridView.CurrentRow.Cells["ClientPhone"].Value.ToString());

                if (client != null)
                {
                    PrintPDF(orderItemGridView, "OrderItem", null, client);
                }
            }

        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            newOrderPanel.Show();
            clientOrderGridView.DataSource = LoadClientTable();
            productOrderGridView.DataSource = LoadProductTable();

        }

        private void viewOrderBtn_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            orderPanel.Show();
            LoadOrder();
        }

        private void clientPhoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void clientOrderSearchTxt_TextChanged(object sender, EventArgs e)
        {
            string searchValue = clientOrderSearchTxt.Text.Trim();

            DataTable clientTable = LoadClientTable();

            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dv = new DataView(clientTable);
                dv.RowFilter = $"Phone LIKE '%{searchValue}%'";
                currentSearchResult = dv.ToTable();
                clientOrderGridView.DataSource = currentSearchResult;
            }
            else
            {
                currentSearchResult = clientTable;
                clientOrderGridView.DataSource = clientTable;
            }
        }

        private void productOrderSearchTxt_TextChanged(object sender, EventArgs e)
        {
            string searchValue = productOrderSearchTxt.Text.Trim();

            DataTable productTable = LoadProductTable();

            if (!string.IsNullOrEmpty(searchValue))
            {
                DataView dv = new DataView(productTable);
                dv.RowFilter = $"Name LIKE '%{searchValue}%'";
                currentSearchResult = dv.ToTable();
                productOrderGridView.DataSource = currentSearchResult;
            }
            else
            {
                currentSearchResult = productTable;
                productOrderGridView.DataSource = productTable;
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if (productOrderGridView.CurrentRow == null || productOrderGridView.CurrentRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            var selectedRow = productOrderGridView.CurrentRow;
            var productName = selectedRow.Cells["Name"].Value.ToString();
            var productId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            var quantity = Convert.ToInt32(productQuantityNum.Value);
            var price = Convert.ToInt32(selectedRow.Cells["Price"].Value);

            var cartItem = new CartItem
            {
                ProductID = productId,
                ProductName = productName,
                Quantity = quantity,
                Price = price * quantity
            };
            bool existed = false;

            foreach (CartItem item in cartItems)
            {
                if (item.ProductName == cartItem.ProductName)
                {
                    item.Quantity += cartItem.Quantity;
                    item.Price = item.Quantity * price;
                    existed = true;
                }
            }
            if (!existed)
            {
                cartItems.Add(cartItem);
            }

            UpdateCartGridView();

        }

        private void UpdateCartGridView()
        {
            cartGridView.DataSource = null;
            cartGridView.DataSource = cartItems;
            var price = 0;
            foreach (CartItem item in cartItems)
            {
                price += item.Price;
            }

            totalPriceTxt.Text = string.Format("{0:N0} VND", price);
        }

        private void insertOrderBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clientPhoneTxt.Text))
            {
                MessageBox.Show("Please select a client", "Empty Client", MessageBoxButtons.OK);
            }
            else if (cartItems.Count == 0)
            {
                MessageBox.Show("Please select a product", "Empty Client", MessageBoxButtons.OK);
            }
            else if (!CheckPhoneExist(clientPhoneTxt.Text))
            {
                DialogResult dialogResult = MessageBox.Show("This Phone number is not exist. Do you want to create new client?", "Client Phone", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ClientForm clientForm = new ClientForm(this);
                    clientForm.txtPhone.Text = clientPhoneTxt.Text;
                    clientForm.ShowDialog();
                }
            }

            else
            {
                Client client = ClientDAO.Instance.GetClientByPhone(clientPhoneTxt.Text);
                int clientID = client.ID;
                int employeeID = id;
                DateTime orderDate = insertOrderDate.Value;
                string totalPriceString = totalPriceTxt.Text.Replace(" VND", "").Replace(",", "");
                decimal totalPriceDecimal;

                if (decimal.TryParse(totalPriceString, out totalPriceDecimal))
                {
                    Console.WriteLine(totalPriceDecimal);
                }
                else
                {
                    foreach (CartItem item in cartItems)
                    {
                        totalPriceDecimal += item.Price;
                    }
                }

                int newOrderID = OrderDAO.Instance.AddNewOrder(clientID, employeeID, orderDate, totalPriceDecimal);

                foreach (CartItem item in cartItems)
                {
                    OrderItemDAO.Instance.AddOrderItem(newOrderID, item.ProductID, item.Quantity);
                }

                if (newOrderID != -1)
                {
                    DisplaySuccess("Successfully Insert New Order");
                    LoadOrder();
                    UpdateClientGridView();
                    UpdateProductGridView();
                    totalPriceTxt.Clear();
                    cartItems.Clear();
                    cartGridView.DataSource = null;
                }
            }
        }

        private bool CheckPhoneExist(string phone)
        {
            return ClientDAO.Instance.CheckPhoneNumberExist(phone);
        }

        private void clientOrderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = clientOrderGridView.Rows[e.RowIndex];

                if (row.Cells["ID"].Value != null && !string.IsNullOrEmpty(row.Cells["ID"].Value.ToString()))
                {
                    clientPhoneTxt.Text = row.Cells["Phone"].Value.ToString();
                }
            }
        }

        private void LoadOrderList()
        {
            DataTable orders = OrderDAO.Instance.LoadOrderTable();
            foreach (DataRow row in orders.Rows)
            {
                cmbOrderList.Items.Add((int)row["ID"]);
            }
        }

        private void cmbOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrderList.SelectedIndex != -1)
            {
                int orderID = Convert.ToInt32(cmbOrderList.Items[cmbOrderList.SelectedIndex]);
                Client client = ClientDAO.Instance.GetClientByOrderID(orderID);
                Order order = OrderDAO.Instance.GetOrderByID(orderID);
                bool isBillExist = BillDAO.Instance.IsBillExistByOrderID(orderID);
                currentClientBill = client;
                if (isBillExist)
                {
                    btnGenerateBill.Enabled = false;
                }
                else
                {
                    btnGenerateBill.Enabled = true;
                }
                LoadClientBillInfo(client);
                LoadBillInfo(order);
                LoadOrderItems(orderID);
            }
        }

        private void LoadClientBillInfo(Client client)
        {
            txtBillClientName.Text = client.Name;
            txtBillEmail.Text = client.Email;
            txtBillPhone.Text = client.Phone;
            txtBillAddress.Text = client.Address;
        }

        private void LoadBillInfo(Order order)
        {
            txtBillOrderID.Text = order.ID.ToString();
            txtBillOrderDate.Text = order.OrderDate.ToShortDateString();
            txtBillTotal.Text = string.Format("{0:N0} VND", order.TotalPrice);
        }
        private void LoadOrderItems(int orderID)
        {
            DataTable orderItems = OrderItemDAO.Instance.GetOrderItemsByOrderID(orderID);
            orderItemsGridView.DataSource = orderItems;
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(txtBillOrderID.Text.ToString());
            DateTime date = Convert.ToDateTime(txtBillOrderDate.Text.ToString());
            string totalPriceString = txtBillTotal.Text.Replace(" VND", "").Replace(",", "");
            decimal totalPriceDecimal = decimal.Parse(totalPriceString);

            if (BillDAO.Instance.AddNewBill(orderID, currentClientBill.ID, id, date, totalPriceDecimal) > 0)
            {
                DisplaySuccess("Generate Bill Successfully");
                ClearBillField();
            }
        }

        private void ClearBillField()
        {
            txtBillOrderID.Clear();
            txtBillOrderDate.Clear();
            txtBillTotal.Clear();
            txtBillClientName.Clear();
            txtBillEmail.Clear();
            txtBillAddress.Clear();
            txtBillPhone.Clear();
            btnGenerateBill.Enabled = false;
            orderItemsGridView.DataSource = null;
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(cmbOrderList.Items[cmbOrderList.SelectedIndex]);
            Client client = ClientDAO.Instance.GetClientByOrderID(orderID);
            Order order = OrderDAO.Instance.GetOrderByID(orderID);

            if (cmbOrderList.SelectedIndex != -1)
                PrintPDF(orderItemsGridView, "Bill", null, client, order);
        }

        private void cmbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedChart = cmbChartType.SelectedItem.ToString();

            chart1.Visible = false;
            chart2.Visible = false;

            if (selectedChart == "Monthly Revenue")
            {
                LoadMonthlyRevenueChart();
                chart1.Visible = true; 
            }
            else if (selectedChart == "Best Selling Products")
            {
                LoadBestSellingProductsChart();
                chart2.Visible = true;
            }
        }

        private void LoadMonthlyRevenueChart()
        {
            DataTable monthlyRevenue = OrderDAO.Instance.LoadRevenue();

            if (monthlyRevenue.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu doanh thu tháng.");
                return;
            }

            chart1.Series.Clear();

            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Monthly Revenue");
            series.ChartType = SeriesChartType.Column;
            series.BorderWidth = 3;
            series.IsValueShownAsLabel = true;
            int i = 1;
            foreach (DataRow row in monthlyRevenue.Rows)
            {
                int month = Convert.ToInt32(row["Month"]);

                decimal revenue = Convert.ToDecimal(row["Revenue"]);

                series.Points.AddXY(month, revenue);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Month";
            chart1.ChartAreas[0].AxisY.Title = "Revenue (VND)";
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:N0}";
        }
        private void LoadBestSellingProductsChart()
        {

            DataTable bestSellingProducts = ProductDAO.Instance.GetBestSellingProducts();

            chart2.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Best Selling Products");
            series.ChartType = SeriesChartType.Pie;

            foreach (DataRow row in bestSellingProducts.Rows)
            {
                string productName = row["ProductName"].ToString();
                int totalSold = Convert.ToInt32(row["TotalSold"]);

                series.Points.AddXY(productName, totalSold);
            }

            chart2.Series.Add(series);
        }
    }
}
