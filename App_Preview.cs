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
    public partial class App_Preview : Form
    {
        public App_Preview()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Login objlogin =new Login();
            objlogin.Show();
            this.Hide();
        }

        private void sign_btn_Click(object sender, EventArgs e)
        {
            SignUp objsignup = new SignUp();
            objsignup.Show();
            this.Hide();
        }
    }
}
