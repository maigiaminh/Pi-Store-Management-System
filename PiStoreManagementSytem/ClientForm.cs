using PiStoreManagementSytem.DAO;
using PiStoreManagementSytem.DTO;
using PiStoreManagementSytem.modal;
using PiStoreManagementSytem.validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PiStoreManagementSytem
{
    public partial class ClientForm : Form
    {
        IStrategyValidator empty;
        IStrategyValidator email;
        IStrategyValidator phone;
        private AdminForm parent;
        private Client currentClient;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public ClientForm(AdminForm parent, Client client = null)
        {
            InitializeComponent();

            empty = new EmptyValidator();
            email = new EmailValidator();
            phone = new PhoneValidator();

            this.parent = parent;
            this.currentClient = client;
        }
        private void DragApplication(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckAllFields())
            {
                if (currentClient == null)
                {
                    if (AddClient
                        (txtClientName.Text,
                        txtEmail.Text,
                        txtPhone.Text,
                        txtAddress.Text
                        ))
                    {
                        DisplaySuccess("Add New Client Successfully!");
                        parent.UpdateClientGridView();
                    }
                }
                else
                {
                    if (UpdateClient
                        (currentClient.ID,
                        txtClientName.Text,
                        txtEmail.Text,
                        txtPhone.Text,
                        txtAddress.Text
                        ))
                    {
                        DisplaySuccess("Update Client Successfully!");
                        parent.UpdateClientGridView();
                    }
                }
            }
        }

        private bool CheckAllFields()
        {
            if (empty.Validate(txtClientName.Text.ToString()) ||
                empty.Validate(txtEmail.Text.ToString()) ||
                empty.Validate(txtPhone.Text.ToString()) ||
                empty.Validate(txtAddress.Text.ToString()))
            {
                DisplayError("Please enter all the required fields!");
                return false;
            }

            else if (!email.Validate(txtEmail.Text.ToString()))
            {
                DisplayError("Please enter a valid email!");
                return false;
            }

            else if (!phone.Validate(txtPhone.Text.ToString()))
            {
                DisplayError("Please enter a valid phone number (10 digits)!");
                return false;
            }

            return true;
        }

        private void DisplayError(string msg)
        {
            ErrorModal errorModal = new ErrorModal();
            errorModal.errorTxt.Text = msg;
            errorModal.Show();
        }

        private void DisplaySuccess(string msg)
        {
            SuccessModal successModal = new SuccessModal(this);
            successModal.successTxt.Text = msg;
            successModal.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckPhoneExist(string phone)
        {
            return ClientDAO.Instance.CheckPhoneNumberExist(phone);
        }

        private bool CheckEmailExist(string email)
        {
            return ClientDAO.Instance.CheckEmailExist(email);
        }

        private bool AddClient(string name, string email, string phone, string address)
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

            return ClientDAO.Instance.AddNewClient(name, email, phone, address);
        }

        private bool UpdateClient(int id, string name, string email, string phone, string address)
        {
            if (CheckPhoneExist(phone) && phone != currentClient.Phone)
            {
                DisplayError("This phone number already existed, try again!");
                return false;
            }
            else if (CheckEmailExist(email) && email != currentClient.Email)
            {
                DisplayError("This email address already existed, try again!");
                return false;
            }

            return ClientDAO.Instance.UpdateClient(id, name, email, phone, address);
        }

        private void ClientForm_Load(object sender, EventArgs e)
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
    }
}
