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

namespace The_Foodie_Zone
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter the Email", "Warning",
                    MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter the Password", "Warning",
                    MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
            }
            else

            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Group 33\\The Foodie Zone\\The Foodie Zone -SignUp.mdf\";Integrated Security=True;Connect Timeout=30"); //connection string
                    SqlCommand cmd = new SqlCommand("select * from SignUp where email=@email and pwd=@pwd", con);
                    cmd.Parameters.AddWithValue("@email", textBox1.Text);
                    cmd.Parameters.AddWithValue("@pwd", textBox2.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);


                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful..!", "Successful");
                        this.Hide();
                        Home objhome = new Home();
                        objhome.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Credentials, Please check Email and Password then Try Again.",
                          "Invalid login Details",
                            MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void sign_btn_Click(object sender, EventArgs e)
        {
            SignUp objsignup = new SignUp();
            objsignup.Show();
            this.Hide();
        }
    }
}
