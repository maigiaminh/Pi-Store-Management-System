using PiStoreManagementSytem.DAO;
using PiStoreManagementSytem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStoreManagementSytem
{
    public partial class AdminForm : Form
    {
        bool isPanelExpanded = true;
        int panelMaxWidth = 200;
        int panelMinWidth = 75;
        public AdminForm()
        {
            InitializeComponent();
            menuBtn.Click += new EventHandler(MenuBtn_Click);
            timerPanel.Tick += new EventHandler(TimerPanel_Tick);
            Init();
        }

        private void Init()
        {
            UnactiveAllPanel();
            homeImg.BackgroundImage = Constants.Constants.home_active;
            homeLabel.ForeColor = Constants.Constants.activeColor;
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

        private void UnactiveAllPanel()
        {
            employeePanel.Hide();
        }
        private void HomeClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            employeePanel.Hide();
            homeImg.BackgroundImage = Constants.Constants.home_active;
            homeLabel.ForeColor = Constants.Constants.activeColor;
        }
        private void EmployeeClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
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
            clientImg.BackgroundImage = Constants.Constants.client_active;
            clientLabel.ForeColor = Constants.Constants.activeColor;
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
                EmployeeForm employeeForm = new EmployeeForm();
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
                for(int i = 0; i < index; i++)
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
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.saveEmBtn.Visible = false;
            employeeForm.resetEmBtn.Visible = false;
            employeeForm.addEmBtn.Visible = true;

            employeeForm.ShowDialog();

        }
    }
}
