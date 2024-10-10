using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStoreManagementSytem.modal
{
    public partial class ErrorModal : Form
    {

        private int targetY;
        private int step = 50;
        public ErrorModal()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            closeTimer.Start();
        }

        private void ErrorModal_Load(object sender, EventArgs e)
        {
            targetY = this.Top;
            this.Top = 0;
            openTimer.Start();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
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
            }
        }

        private void openTimer_Tick(object sender, EventArgs e)
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
    }
}
