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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            Profile objprofile = new Profile();
            objprofile.Show();
            this.Hide();
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            Browse objsearch = new Browse();
            objsearch.Show();
            this.Hide();
        }

        private void cart_btn_Click(object sender, EventArgs e)
        {
            Cart objcart = new Cart();
            objcart.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            App_Preview objwelcome = new App_Preview();
            objwelcome.Show();
            this.Hide();
        }
    }
}
