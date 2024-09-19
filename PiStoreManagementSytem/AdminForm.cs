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
        private readonly Bitmap home = Properties.Resources.home;
        private readonly Bitmap home_active = Properties.Resources.home_active;
        private readonly Bitmap employee = Properties.Resources.employee;
        private readonly Bitmap employee_active = Properties.Resources.employee_active;
        private readonly Bitmap client = Properties.Resources.customer;
        private readonly Bitmap client_active = Properties.Resources.customer_active;
        private readonly Bitmap product = Properties.Resources.products;
        private readonly Bitmap product_active = Properties.Resources.products_active;
        private readonly Bitmap order = Properties.Resources.orders;
        private readonly Bitmap order_active = Properties.Resources.orders_active;
        private readonly Bitmap bill = Properties.Resources.bills;
        private readonly Bitmap bill_active = Properties.Resources.bills_active;
        private readonly Color activeColor = Color.FromArgb(69, 123, 157);
        private readonly Color defaultColor = Color.Black;
        bool isPanelExpanded = true;
        int panelMaxWidth = 200;
        int panelMinWidth = 75;
        public AdminForm()
        {
            InitializeComponent();
            menuBtn.Click += new EventHandler(MenuBtn_Click);
            timerPanel.Tick += new EventHandler(TimerPanel_Tick);
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
            homeImg.BackgroundImage = home;
            employeeImg.BackgroundImage = employee;
            clientImg.BackgroundImage = client;
            productImg.BackgroundImage = product;
            orderImg.BackgroundImage = order;
            billImg.BackgroundImage = bill;

            homeLabel.ForeColor = defaultColor;
            employeeLabel.ForeColor = defaultColor;
            clientLabel.ForeColor = defaultColor;
            productLabel.ForeColor = defaultColor;
            orderLabel.ForeColor = defaultColor;
            billLabel.ForeColor = defaultColor;
        }
        private void HomeClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            employeePanel.Hide();
            homeImg.BackgroundImage = home_active;
            homeLabel.ForeColor = activeColor;
        }
        private void EmployeeClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            employeeImg.BackgroundImage = employee_active;
            employeeLabel.ForeColor = activeColor;
            employeePanel.Show();
        }

        private void ClientClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            clientImg.BackgroundImage = client_active;
            clientLabel.ForeColor = activeColor;
        }

        private void ProductClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            productImg.BackgroundImage = product_active;
            productLabel.ForeColor = activeColor;
        }

        private void OrderClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            orderImg.BackgroundImage = order_active;
            orderLabel.ForeColor = activeColor;
        }

        private void BillClick(object sender, EventArgs e)
        {
            UnactiveAllButton();
            billImg.BackgroundImage = bill_active;
            billLabel.ForeColor = activeColor;
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

    }
}
