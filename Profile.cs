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
    public partial class Profile : Form
    {

        public Profile()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Home objhome = new Home();
            objhome.Show();
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

        private void home_btn_Click(object sender, EventArgs e)
        {
            Home objhome = new Home();
            objhome.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Profile objupdate = new Update_Profile();
            objupdate.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contact_Us objcontact = new Contact_Us();
            objcontact.Show();
            this.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            textBox1.Text = SignUp.SetValueFortextBox1;
            textBox2.Text = SignUp.SetValueFortextBox2;
            textBox3.Text = SignUp.SetValueFortextBox3;
            textBox4.Text = SignUp.SetValueFortextBox4;
            textBox5.Text = SignUp.SetValueFortextBox5;
        }
    }
}
