using System.Runtime.InteropServices;

namespace PiStoreManagementSytem
{
    public partial class Form1 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private bool showPassword = false;
        private readonly Bitmap show = Properties.Resources.eye;
        private readonly Bitmap hidden = Properties.Resources.hidden;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            exitBtn.Cursor = Cursors.Hand;
            loginBtn.Cursor = Cursors.Hand;
            resetPassBtn.Cursor = Cursors.Hand;
            showPassBtn.Cursor = Cursors.Hand; 
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
