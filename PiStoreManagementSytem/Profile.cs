using PiStoreManagementSytem.DAO;
using PiStoreManagementSytem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStoreManagementSytem
{
    public partial class Profile : Form
    {
        private int employeeId;
        private int cornerRadius = 30;
        private Color borderColor = Color.FromArgb(69, 123, 157);
        private int borderWidth = 5;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public Profile(int id)
        {
            InitializeComponent();
            employeeId = id;
            LoadEmployeeProfile();
            this.DoubleBuffered = true;
        }
        private void DragApplication(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void LoadEmployeeProfile()
        {
            Employee employee = EmployeeDAO.Instance.GetEmployeeById(employeeId);

            if (employee != null)
            {
                lblName.Text = employee.Name;
                lblHireDate.Text = employee.HireDate.ToShortDateString();
                lblAddress.Text = employee.Address;
                lblEmail.Text = employee.Email;
                lblPhone.Text = employee.Phone;
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(this.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, this.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
        private void Profile_Paint(object sender, PaintEventArgs e)
        {
            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                Graphics g = e.Graphics;
                g.DrawPath(borderPen, CreateRoundedRectanglePath(ClientRectangle, cornerRadius));
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
