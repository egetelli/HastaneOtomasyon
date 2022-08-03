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
    public partial class DoctorForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BHSHM3U;Initial Catalog=HMS;Integrated Security=True");


        public DoctorForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            con.Open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            SqlCommandBuilder sqlCB = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "" || DocName.Text == "" || DocExp.Text == "" || DocPass.Text == "")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {
                con.Open();
                string query = "insert into DoctorTbl values(" + DocId.Text + ",'" + DocName.Text + "'," + DocExp.Text + ",'" + DocPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Added");
                con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "")
            {
                MessageBox.Show("Please Enter The Doctor Id");
            }
            else
            {
                con.Open();
                string query = "delete from DoctorTbl where DocId=" + DocId.Text + "";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");
                con.Close();
                populate();

            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocId.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocExp.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocPass.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update DoctorTbl set DocName = '" + DocName.Text + "',DocExp ='" + DocExp.Text + "',DocPass ='"+ DocPass.Text+"' where DocId="+DocId.Text+"";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Successfully Updated");
            con.Close();
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
