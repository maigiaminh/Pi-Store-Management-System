using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStoreManagementSytem.modal
{
    public partial class SuccessModal : Form
    {
        private Form form;
        private int targetY;
        private int step = 50;
        public SuccessModal(Form form = null)
        {
            InitializeComponent();
            this.Opacity = 0;
            this.form = form;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            closeTimer.Start();
        }
        private void SuccessModal_Load(object sender, EventArgs e)
        {
            targetY = this.Top;
            this.Top = 0;
            openTimer.Start();
        }
        private void openTimer_Tick_1(object sender, EventArgs e)
        {
            if (this.Top < targetY)
            {
                this.Top += step;
                this.Opacity += 0.5;
            }
            else
            {
                this.Top = targetY;
                this.Opacity = 1;
                openTimer.Stop();
            }
        }
        private void closeTimer_Tick_1(object sender, EventArgs e)
        {
            if (this.Top > 0)
            {
                this.Top -= step;
                this.Opacity -= 0.5;
            }
            else
            {
                closeTimer.Stop();
                this.Close();
                if(form != null)
                    form.Close();
            }
        }
    }
}
