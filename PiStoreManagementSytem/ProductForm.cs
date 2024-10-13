using PiStoreManagementSytem.DAO;
using PiStoreManagementSytem.modal;
using PiStoreManagementSytem.validators;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PiStoreManagementSytem
{
    public partial class ProductForm : Form
    {
        private AdminForm parent;
        IStrategyValidator empty;
        public int productID = -1;

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public ProductForm(AdminForm parent)
        {
            InitializeComponent();

            empty = new EmptyValidator();

            this.parent = parent;
        }

        private void ProductForm_Load(object sender, EventArgs e)
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
        private void DragApplication(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckAllFields()
        {
            if (empty.Validate(txtName.Text.ToString()) ||
                empty.Validate(txtDescription.Text.ToString()))
            {
                DisplayError("Please enter all the required fields!");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckAllFields())
            {
                if(productID == -1)
                {
                    if (AddProduct
                    (txtName.Text,
                    txtDescription.Text,
                    numPrice.Value,
                    (int)numQuantity.Value
                    ))
                    {
                        DisplaySuccess("Add New Product Successfully!");
                        parent.UpdateProductGridView();
                    }
                }
                else
                {
                    if (UpdateProduct
                    (productID,
                    txtName.Text,
                    txtDescription.Text,
                    numPrice.Value,
                    (int)numQuantity.Value
                    ))
                    {
                        DisplaySuccess("Update Product Successfully!");
                        parent.UpdateProductGridView();
                    }
                }
            }
        }

        private bool AddProduct(string name, string description, decimal price, int quantity)
        {
            return ProductDAO.Instance.AddProduct(name, description, price, quantity);
        }

        private bool UpdateProduct(int id, string name, string description, decimal price, int quantity)
        {
            return ProductDAO.Instance.UpdateProduct(id, name, description, price, quantity);
        }
    }
}
