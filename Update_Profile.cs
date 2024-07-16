using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Foodie_Zone
{
    public partial class Update_Profile : Form
    {
        public Update_Profile()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Profile objprofile = new Profile();
            objprofile.Show();
            this.Hide();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Group 33\\The Foodie Zone\\The Foodie Zone -SignUp.mdf\";Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd= new SqlCommand("Update SignUp set c_no=@c_no, email=@email, pwd=@pwd where s_id=@s_id", con);
            cmd.Parameters.AddWithValue("@s_id", textBox1.Text);
            cmd.Parameters.AddWithValue("@c_no", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@pwd", textBox4.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Group 33\\The Foodie Zone\\The Foodie Zone -SignUp.mdf\";Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("Delete SignUp where s_id=@s_id", con);
            cmd.Parameters.AddWithValue("@s_id", textBox1.Text);
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
