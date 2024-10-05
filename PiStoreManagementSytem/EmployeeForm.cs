using PiStoreManagementSytem.DAO;
using PiStoreManagementSytem.DTO;
using PiStoreManagementSytem.modal;
using PiStoreManagementSytem.validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        public AdminForm parent;
        IStrategyValidator empty;
        IStrategyValidator email;
        IStrategyValidator phone;

        public EmployeeForm(AdminForm parent)
        {
            InitializeComponent();
            this.parent = parent;

            empty = new EmptyValidator();
            email = new EmailValidator();
            phone = new PhoneValidator();
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
            if (CheckAllFields())
            {
                if (AddEmployee
                    (fullNameTxt.Text,
                    emailTxt.Text,
                    "admin",
                    phoneTxt.Text,
                    addressTxt.Text,
                    salaryTxt.Value,
                    hDatePicker.Value
                    ))
                {
                    DisplaySuccess("Add new employee Successfully! Default password is 'admin'.");
                    parent.UpdateEmployeeGridView();
                }
            }
        }

        private bool CheckAllFields()
        {
            if (empty.Validate(fNameTxt.Text.ToString()) ||
                empty.Validate(lNameTxt.Text.ToString()) ||
                empty.Validate(addressTxt.Text.ToString()) ||
                empty.Validate(phoneTxt.Text.ToString()) ||
                empty.Validate(emailTxt.Text.ToString()))
            {
                DisplayError("Please enter all the required fields!");
                return false;
            }

            else if (!email.Validate(emailTxt.Text.ToString()))
            {
                DisplayError("Please enter a valid email!");
                return false;
            }

            else if (!phone.Validate(phoneTxt.Text.ToString()))
            {
                DisplayError("Please enter a valid phone number (10 digits)!");
                return false;
            }

            return true;
        }

        private bool AddEmployee(string name, string email, string password, string phone, string address, decimal salary, DateTime hireDate)
        {
            if (CheckPhoneExist(phone))
            {
                DisplayError("This phone number already existed, try again!");
                return false;
            }
            else if (CheckEmailExist(email))
            {
                DisplayError("This email address already existed, try again!");
                return false;
            }

            return EmployeeDAO.Instance.AddNewEmployee(name, email, password, phone, address, salary, hireDate);
        }

        private bool UpdateEmployee(int id, string name, string email, string phone, string address, decimal salary, DateTime hireDate)
        {
            if (CheckPhoneExist(phone) && phone != currentEm.Phone)
            {
                DisplayError("This phone number already existed, try again!");
                return false;
            }
            else if (CheckEmailExist(email) && email != currentEm.Email)
            {
                DisplayError("This email address already existed, try again!");
                return false;
            }

            return EmployeeDAO.Instance.UpdateEmployee(id, name, email, phone, address, salary, hireDate);
        }

            private bool CheckPhoneExist(string phone)
        {
            return EmployeeDAO.Instance.CheckPhoneNumberExist(phone);
        }

        private bool CheckEmailExist(string email)
        {
            return EmployeeDAO.Instance.CheckEmailExist(email);
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveEmBtn_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                if (UpdateEmployee
                    (Convert.ToInt32(idTxt.Text),
                    fullNameTxt.Text,
                    emailTxt.Text,
                    phoneTxt.Text,
                    addressTxt.Text,
                    salaryTxt.Value,
                    hDatePicker.Value
                    ))
                {
                    DisplaySuccess("Update employee Successfully!");
                    parent.UpdateEmployeeGridView();
                }
            }
        }
    }
}
