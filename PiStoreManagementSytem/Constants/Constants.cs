using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStoreManagementSytem.Constants
{
    public class Constants
    {
        public static readonly Bitmap home = Properties.Resources.home;
        public static readonly Bitmap home_active = Properties.Resources.home_active;
        public static readonly Bitmap employee = Properties.Resources.employee;
        public static readonly Bitmap employee_active = Properties.Resources.employee_active;
        public static readonly Bitmap client = Properties.Resources.customer;
        public static readonly Bitmap client_active = Properties.Resources.customer_active;
        public static readonly Bitmap product = Properties.Resources.products;
        public static readonly Bitmap product_active = Properties.Resources.products_active;
        public static readonly Bitmap order = Properties.Resources.orders;
        public static readonly Bitmap order_active = Properties.Resources.orders_active;
        public static readonly Bitmap bill = Properties.Resources.bills;
        public static readonly Bitmap bill_active = Properties.Resources.bills_active;
        public static readonly Bitmap edit = Properties.Resources.pen;
        public static readonly Bitmap edit_unactive = Properties.Resources.pen_unactive;
        public static readonly Bitmap delete = Properties.Resources.remove;
        public static readonly Bitmap delete_unactive = Properties.Resources.remove_unactive;
        public static readonly Bitmap edit_employee = Properties.Resources.edit;
        public static readonly Bitmap add_employee = Properties.Resources.addd;
        public static readonly Bitmap logo = Properties.Resources.logo;

        public static readonly Color activeColor = Color.FromArgb(69, 123, 157);
        public static readonly Color defaultColor = Color.Black;
        public static readonly Color editColor = Color.FromArgb(38, 164, 244);
        public static readonly Color deleteColor = Color.FromArgb(244, 67, 54);
    }
}
