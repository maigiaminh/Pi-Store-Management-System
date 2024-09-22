using PiStoreManagementSytem.DTO;
using PiStoreManagementSytem.validators;
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
    public partial class EmployeeForm : Form
    {
        public Employee currentEm;
        IStrategyValidator empty;

        public EmployeeForm()
        {
            InitializeComponent();
            empty = new EmptyValidator();
        }

        private void eraseEmBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to clear all the fields?", "Clear All Field", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                fNameTxt.Text = string.Empty;
                lNameTxt.Text = string.Empty;
                fullNameTxt.Text = string.Empty;
                addressTxt.Text = string.Empty;
                phoneTxt.Text = string.Empty;
                emailTxt.Text = string.Empty;
                hDatePicker.Value = DateTime.Now;
                salaryTxt.Value = 1000000;
            }
        }

        private void UpdateFullName(object sender, EventArgs e)
        {
            fullNameTxt.Text = lNameTxt.Text + " " + fNameTxt.Text;
        }

        private void phoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void resetEmBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to reset all the changes you have edited?", "Reset Changes", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                fullNameTxt.Text = currentEm.Name;
                addressTxt.Text = currentEm.Address;
                phoneTxt.Text = currentEm.Phone;
                emailTxt.Text = currentEm.Email;
                hDatePicker.Value = currentEm.HireDate;
                salaryTxt.Value = currentEm.Salary;

                string[] names = currentEm.Name.Split(" ");
                string fName = names.Last();
                string lName = "";
                int index = currentEm.Name.IndexOf(fName) - 1;
                for (int i = 0; i < index; i++)
                {
                    lName += currentEm.Name[i];
                }

                fNameTxt.Text = fName;
                lNameTxt.Text = lName;
            }

        }

        private void addEmBtn_Click(object sender, EventArgs e)
        {
            
        }

        private bool CheckAllFields()
        {
            if(empty.Validate(fNameTxt.Text) ||
                empty.Validate(lNameTxt.Text) ||
                empty.Validate(addressTxt.Text) ||
                empty.Validate(phoneTxt.Text) ||
                empty.Validate(emailTxt.Text)){
                
            }
            return true;
        }
    }
}
