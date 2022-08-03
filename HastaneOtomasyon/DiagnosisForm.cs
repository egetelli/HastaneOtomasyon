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
    public partial class DiagnosisForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BHSHM3U;Initial Catalog=HMS;Integrated Security=True");

        public DiagnosisForm()
        {
            InitializeComponent();
        }

        void populate()
        {
            con.Open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCB = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            con.Close();
        }

        void populatecombo()
        {
            string sql = "select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId", typeof(int)); 
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember = "PatId";
                PatientIdCb.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }
        string patname;
        void fetchpatientname()
        {
            con.Open();
            string sql = "select * from PatientTbl where PatId=" + PatientIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(sql,con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                PatNameTb.Text = patname;
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "" || SymptomsTb.Text == "" || MedicineTb.Text == "" || DiagnosisTb.Text == "" || PatNameTb.Text == "")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {
                con.Open();
                string query = "insert into DiagnosisTbl values(" + DiagId.Text + ",'" + PatientIdCb.SelectedValue.ToString() + "','" + PatNameTb.Text + "','" + SymptomsTb.Text + "','" + DiagnosisTb.Text + "','" + MedicineTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Added");
                con.Close();
                populate();
            }
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpatientname();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "")
            {
                MessageBox.Show("Please Enter The Diagnosis Id");
            }
            else
            {
                con.Open();
                string query = "delete from DiagnosisTbl where DiagId=" + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Deleted");
                con.Close();
                populate();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update DiagnosisTbl set PatId = '" + PatientIdCb.SelectedValue.ToString() + "',PatName ='" + PatNameTb.Text + "',Symptoms ='" + SymptomsTb.Text + "',Diagnosis ='" + DiagnosisTb.Text + "',Medicines ='" + MedicineTb.Text + "' where DiagId=" + DiagId.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Successfully Updated");
            con.Close();
            populate();
        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatNameTb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            SymptomsTb.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            DiagnosisTb.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            MedicineTb.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
           


        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SplashForm sform = new SplashForm();
            sform.Show();
            this.Hide();
        }
    }
}
