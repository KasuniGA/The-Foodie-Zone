using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace The_Foodie_Zone
{
    public partial class SignUp : Form
    {
        public static string SetValueFortextBox1 = "";
        public static string SetValueFortextBox2 = "";
        public static string SetValueFortextBox3 = "";
        public static string SetValueFortextBox4 = "";
        public static string SetValueFortextBox5 = "";

        public SignUp()
        {
            InitializeComponent();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();  
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Login objlogin = new Login();
            objlogin.Show();
            this.Hide();
        }

        
        private void signin_btn_Click(object sender, EventArgs e)
        {

            /*Profile form = new Profile();
            form.F_Name = textBox1.Text;
            form.L_Name = textBox4.Text;
            form.S_ID = textBox2.Text;
            form.Contact_number = textBox3.Text;
            form.Email = textBox5.Text;
            form.ShowDialog();*/

            SetValueFortextBox1 = textBox1.Text;
            SetValueFortextBox2 = textBox2.Text;
            SetValueFortextBox3 = textBox3.Text;
            SetValueFortextBox4 = textBox4.Text;
            SetValueFortextBox5 = textBox5.Text;
            Profile form = new Profile();
            form.Show();

            string F_Name = textBox1.Text;
            string L_Name = textBox2.Text;
            string S_ID = textBox3.Text;
            string Contact_number = textBox4.Text;
            string Email = textBox5.Text;
            string Password = textBox6.Text;

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Group 33\\The Foodie Zone\\The Foodie Zone -SignUp.mdf\";Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = null;

            cmd = new SqlCommand("insert into SignUP( f_name,l_name,s_id,c_no,email,pwd) values('" + F_Name + "','" + L_Name + "','" + S_ID + "','" + Contact_number + "','" + Email + "','" + Password + "')", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Saved...");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Saved" + ex);
            }
            finally
            {
                con.Close();
            }

            

        }

        /* SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\OneDrive\\Documents\\The Foodie Zone -SignUp.mdf\";Integrated Security=True;Connect Timeout=30");

         private void signin_btn_Click(object sender, EventArgs e)

         {

             try
             {
                 conn.Open();
                 string query = "insert into Signup values('" + textBox1.Text + "', '" + textBox4.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')";
                 SqlCommand cmd = new SqlCommand(query, conn);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Signin successfully");
                 conn.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }*/
    }
}
