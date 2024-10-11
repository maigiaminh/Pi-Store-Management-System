using Microsoft.IdentityModel.Tokens;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PiStoreManagementSytem.DAO;
using PiStoreManagementSytem.DTO;
using PiStoreManagementSytem.modal;
using System.Data;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PiStoreManagementSytem
{
    public partial class AdminForm : Form
    {
        private int id;
        bool isPanelExpanded = true;
        bool isSettingEnable = false;
        int panelMaxWidth = 200;
        int panelMinWidth = 75;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private DataTable currentSearchResult;

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
        }

        private void UnactiveAllPanel()
        {
            employeePanel.Hide();
        }
        private void HomeClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            HideAllPanel();
            homeImg.BackgroundImage = Constants.Constants.home_active;
            homeLabel.ForeColor = Constants.Constants.activeColor;
        }
        private void EmployeeClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            HideAllPanel();
            employeeImg.BackgroundImage = Constants.Constants.employee_active;
            employeeLabel.ForeColor = Constants.Constants.activeColor;
            employeePanel.Show();
            employeeGridView.DataSource = LoadEmployeeTable();
            employeeGridView.Columns["Password"].Visible = false;

            SetEmployeeButtonActive(false);
        }

        private void ClientClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            HideAllPanel();

            clientImg.BackgroundImage = Constants.Constants.client_active;
            clientLabel.ForeColor = Constants.Constants.activeColor;

            clientPanel.Show();

        }

        private void ProductClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            productImg.BackgroundImage = Constants.Constants.product_active;
            productLabel.ForeColor = Constants.Constants.activeColor;
        }

        private void OrderClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            orderImg.BackgroundImage = Constants.Constants.order_active;
            orderLabel.ForeColor = Constants.Constants.activeColor;
        }

        private void BillClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            billImg.BackgroundImage = Constants.Constants.bill_active;
            billLabel.ForeColor = Constants.Constants.activeColor;
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

        private void deleteEmBtn_Click(object sender, EventArgs e)
        {
            if (employeeGridView.CurrentRow != null && employeeGridView.CurrentRow.Cells["ID"].Value != null)
            {
                int employeeID = Convert.ToInt32(employeeGridView.CurrentRow.Cells["ID"].Value);
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (DeleteEmployee(employeeID))
                    {
                        UpdateEmployeeGridView();
                        DisplaySuccess("Successfully Delete Employee!");
                    }
                    else
                    {
                        DisplaySuccess("An error has orcurred while deleting employee! Please try again!");
                    }
                }
            }
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
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Company Employee List";

            PdfPage page = document.AddPage();

            page.Size = PageSize.A4;
            page.Orientation = PageOrientation.Landscape;

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont titleFont = new XFont("Verdana", 24, XFontStyleEx.Bold);
            XFont companyFont = new XFont("Verdana", 14, XFontStyleEx.Bold);
            XFont headerFont = new XFont("Verdana", 12, XFontStyleEx.Bold);
            XFont cellFont = new XFont("Verdana", 10, XFontStyleEx.Regular);

            Bitmap logoBitmap = Properties.Resources.logo;

            using (MemoryStream stream = new MemoryStream())
            {
                logoBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                XImage logo = XImage.FromStream(stream);

                gfx.DrawImage(logo, 20, 0, 200, 200);
                gfx.DrawString("Employee List", titleFont, XBrushes.Black,
                    new XRect(page.Height, 85, page.Width - 160, 50), XStringFormats.TopLeft);

                gfx.DrawString("Company: Pi Store Sneaker", companyFont, XBrushes.Black,
                    new XRect(50, 190, page.Width - 100, 50), XStringFormats.TopLeft);
            }

            double tableTop = 220;
            double rowHeight = 20;
            double pageWidth = page.Width;
            double colXPos = 50;


            double totalGridViewWidth = 0;
            foreach (DataGridViewColumn column in employeeGridView.Columns)
            {
                if (column.Name != "ID" && column.Name != "Password")
                {
                    totalGridViewWidth += column.Width;
                }
            }

            double scaleFactor = (pageWidth - 100) / totalGridViewWidth;

            XPen borderPen = new XPen(XColors.Black, 1);
            gfx.DrawRectangle(XBrushes.LightGray, colXPos, tableTop, totalGridViewWidth * scaleFactor, rowHeight);

            foreach (DataGridViewColumn column in employeeGridView.Columns)
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
            foreach (DataGridViewRow row in employeeGridView.Rows)
            {
                if (tableTop + rowHeight > page.Height - 50)
                {
                    tableTop = 220;
                    page = document.AddPage();
                    page.Size = PageSize.A4;
                    page.Orientation = PageOrientation.Landscape;
                    gfx = XGraphics.FromPdfPage(page);

                    using (MemoryStream stream = new MemoryStream())
                    {
                        logoBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        XImage logo = XImage.FromStream(stream);

                        gfx.DrawImage(logo, 20, 0, 200, 200);
                        gfx.DrawString("Employee List", titleFont, XBrushes.Black,
                            new XRect(page.Height, 85, page.Width - 160, 50), XStringFormats.TopLeft);

                        gfx.DrawString("Company: Pi Store Sneaker", companyFont, XBrushes.Black,
                            new XRect(50, 190, page.Width - 100, 50), XStringFormats.TopLeft);
                    }

                    colXPos = 50;
                    gfx.DrawRectangle(XBrushes.LightGray, colXPos, tableTop, totalGridViewWidth * scaleFactor, rowHeight);
                    foreach (DataGridViewColumn column in employeeGridView.Columns)
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
                    if (employeeGridView.Columns[cell.ColumnIndex].Name != "ID" && employeeGridView.Columns[cell.ColumnIndex].Name != "Password")
                    {
                        double scaledColWidth = employeeGridView.Columns[cell.ColumnIndex].Width * scaleFactor;

                        string cellValue = (cell.ColumnIndex == employeeGridView.Columns["HireDate"].Index)
                            ? Convert.ToDateTime(cell.Value).ToString("M/d/yyyy")
                            : cell.Value?.ToString() ?? "";

                        string truncatedText = TruncateText(gfx, cellValue, cellFont, scaledColWidth - 10);

                        gfx.DrawString(truncatedText, cellFont, XBrushes.Black,
                            new XRect(colXPos, tableTop, scaledColWidth, rowHeight), XStringFormats.Center);

                        gfx.DrawRectangle(borderPen, colXPos, tableTop, scaledColWidth, rowHeight);
                        colXPos += scaledColWidth;
                    }
                }
                tableTop += rowHeight;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save Employee List PDF";
            saveFileDialog.FileName = "EmployeeList.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                document.Save(filePath);
                document.Close();

                MessageBox.Show("Print Employee List Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                // Lưu vào file CSV
                File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
                MessageBox.Show("Export CSV Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred when exporting CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
