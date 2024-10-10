﻿using PiStoreManagementSytem.DAO;
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
    public partial class ChangePasswordForm : Form
    {
        private bool showCurPassword = false;
        private bool showNewPassword = false;
        private bool showConfirmPassword = false;
        private int id;

        public ChangePasswordForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidatePasswordChange(txtCurrentPassword.Text, txtNewPassword.Text, txtConfirmNewPassword.Text))
                if (UpdatePassword(id, txtNewPassword.Text))
                    ShowSuccess("Password change successful");
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showCurPassBtn_Click(object sender, EventArgs e)
        {
            ToggleShowPassword(showCurPassBtn, txtCurrentPassword, ref showCurPassword);
        }

        private void showNewPassBtn_Click(object sender, EventArgs e)
        {
            ToggleShowPassword(showNewPassBtn, txtNewPassword, ref showNewPassword);
        }
        private void showConfirmPassBtn_Click(object sender, EventArgs e)
        {
            ToggleShowPassword(showConfirmPassBtn, txtConfirmNewPassword, ref showConfirmPassword);
        }

        private void ToggleShowPassword(PictureBox btn, TextBox pass, ref bool flag)
        {
            flag = !flag;
            if (flag)
            {
                btn.BackgroundImage = Constants.Constants.eye_gray;
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                btn.BackgroundImage = Constants.Constants.eye_gray_hidden;
                pass.UseSystemPasswordChar = true;
            }
        }


        private bool ValidatePasswordChange(string currentPassword, string newPassword, string confirmNewPassword)
        {

            if (newPassword.Length < 8)
            {
                txtNewPassword.Focus();
                return ShowError("Password must at least 8 characters");
            }

            else if (newPassword != confirmNewPassword)
            {
                txtNewPassword.Focus();
                return ShowError("Password not match");
            }

            else if(!CheckCurrentPassword(id, currentPassword))
            {
                txtCurrentPassword.Focus();
                return ShowError("Invalid current password");
            }

            return true;
        }

        private bool ShowError(string message)
        {
            txtMsg.Visible = true;
            txtMsg.Text = message;
            txtMsg.BackColor = Color.FromArgb(255, 241, 235);
            txtMsg.ForeColor = Color.Tomato;

            label1.Location = new Point(label1.Location.X, 50);
            label2.Location = new Point(label2.Location.X, 100);

            return false;
        }

        private void ShowSuccess(string message)
        {
            txtMsg.Visible = true;
            txtMsg.Text = message;
            txtMsg.BackColor = Color.FromArgb(192, 255, 192);
            txtMsg.ForeColor = Color.Green;

            label1.Location = new Point(label1.Location.X, 50);
            label2.Location = new Point(label2.Location.X, 100);

            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmNewPassword.Clear();

        }
        private bool CheckCurrentPassword(int id, string currentPassword)
        {
            return EmployeeDAO.Instance.CheckCurrentPassword(id, currentPassword);
        }

        private bool UpdatePassword(int id, string newPassword)
        {
            return EmployeeDAO.Instance.UpdatePassword(id, newPassword);
        }
    }
}
