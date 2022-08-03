using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HastaneOtomasyon
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BHSHM3U;Initial Catalog=HMS;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocName.Text == "" || DocPass.Text == "")
            {
                MessageBox.Show("Please Enter a Doctor Name and Password!");
            }
            else
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Count(*) from DoctorTbl where DocName='" +DocName.Text+ "' and DocPass='" + DocPass.Text + "'",con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DocName.Text = "";
            DocPass.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
