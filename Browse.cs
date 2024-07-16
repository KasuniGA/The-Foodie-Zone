using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Foodie_Zone
{
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Home objhome = new Home();
            objhome.Show();
            this.Hide();
        }

        private void cart_btn_Click(object sender, EventArgs e)
        {
            Cart objcart = new Cart();
            objcart.Show();
            this.Hide();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            Profile objprofile = new Profile();
            objprofile.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Home objhome = new Home();
            objhome.Show();
            this.Hide();
        }
    }
}
