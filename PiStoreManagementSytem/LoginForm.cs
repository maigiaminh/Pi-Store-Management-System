using PiStoreManagementSytem.DAO;
using PiStoreManagementSytem.validators;
using System.Runtime.InteropServices;

namespace PiStoreManagementSytem
{
    public partial class LoginForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private bool showPassword = false;
        private readonly Bitmap show = Properties.Resources.eye;
        private readonly Bitmap hidden = Properties.Resources.hidden;
        private IStrategyValidator emptyField = new EmptyValidator();

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DragApplication(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            
            if(emptyField.Validate(email) 
                || emptyField.Validate(password))
            {
                MessageBox.Show("Please enter your account!");
            }
            else
            {
                if (Login(email, password))
                {
                    MessageBox.Show("OK");
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password, try again!");
                }
            }
            
        }

        private bool Login(string email, string password)
        {
            return AccountDAO.Instance.Login(email, password);
        }
        private void showPassBtn_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                showPassBtn.BackgroundImage = show;
                passwordTxt.UseSystemPasswordChar = false;
            }
            else
            {
                showPassBtn.BackgroundImage = hidden;
                passwordTxt.UseSystemPasswordChar = true;
            }
        }
    }
}
