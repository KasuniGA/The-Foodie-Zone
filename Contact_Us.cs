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
    public partial class Contact_Us : Form
    {
        public Contact_Us()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home objhome = new Home();
            objhome.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Browse objsearch = new Browse();
            objsearch.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cart objcart = new Cart();
            objcart.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profile objprofile = new Profile();
            objprofile.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile objprofile = new Profile();
            objprofile.Show();
            this.Hide();
        }
    }
}
