using PiStoreManagementSytem.DAO;
using PiStoreManagementSytem.validators;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace PiStoreManagementSytem
{
    public partial class LoginForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private bool showPassword = false;
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

            if (emptyField.Validate(email)
                || emptyField.Validate(password))
            {
                MessageBox.Show("Please enter your account!");
            }
            else
            {
                int id = Login(email, password);
                if (id != -1)
                {
                    MessageBox.Show(id.ToString());
                    AdminForm adminForm = new AdminForm(id);
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password, try again!");
                }
            }

        }

        private int Login(string email, string password)
        {
            return AccountDAO.Instance.Login(email, password);
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                showPassBtn.BackgroundImage = Constants.Constants.eye_blue;
                passwordTxt.UseSystemPasswordChar = false;
            }
            else
            {
                showPassBtn.BackgroundImage = Constants.Constants.eye_blue_hidden;
                passwordTxt.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
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
