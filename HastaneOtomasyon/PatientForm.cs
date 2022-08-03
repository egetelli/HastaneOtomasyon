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
    public partial class PatientForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BHSHM3U;Initial Catalog=HMS;Integrated Security=True");

        public PatientForm()
        {
            InitializeComponent();
        }

        void populate()
        {
            con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCB = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PatAddress.Text == "" || PatPhone.Text == "" || PatAge.Text =="" || MajorTb.Text =="")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {
                con.Open();
                string query = "insert into PatientTbl values(" + PatId.Text + ",'" + PatName.Text + "','" + PatAddress.Text + "','" + PatPhone.Text + "'," + PatAge.Text + ",'" + GenderCb.SelectedItem.ToString() + "','" + BloodCb.SelectedItem.ToString() + "','" + MajorTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Added");
                con.Close();
                populate();
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
            {
                MessageBox.Show("Please Enter The Patient Id");
            }
            else
            {
                con.Open();
                string query = "delete from PatientTbl where PatId=" + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                con.Close();
                populate();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update PatientTbl set PatName = '" + PatName.Text + "',PatAddress ='" + PatAddress.Text + "',PatPhone ='" + PatPhone.Text + "',PatAge ='" + PatAge.Text+ "',PatGender ='" + GenderCb.SelectedItem.ToString() + "',PatBlood ='" + BloodCb.SelectedItem.ToString() + "',PatDisease ='" + MajorTb.Text + "' where PatId=" + PatId.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Successfully Updated");
            con.Close();
            populate();
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatAddress.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatPhone.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            MajorTb.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
