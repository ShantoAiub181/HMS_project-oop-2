using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS_project_oop_2
{
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0TO85P3;Initial Catalog=HMSdb;Integrated Security=True");
        void populatecombo()
        {
            string sql = "select * fromPatientTbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr
                try
                {
                con.open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatID", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIDCb.ValueMember = "PatID";
                PatientIDCb.DataSource = dt;
                con.close();
                }
            catch
            {

            }
        }
        string patname;
        void fecthpatientname()
        {
            con.open();
            string mysql = " select * from PatientTbl where PatID = " + PatientIDCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                PatientTb.Text = patname;
            }
            con.close();
        }
        void populate()
        {
            con.open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            con.close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DiagID.Text == "" || MedicineTb.Text == "" || DiagnosisTb.Text == "" || PatientTb.Text == "" || MedicineTb.Text == "" )
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                con.open();
               string query = "insert into DiagnosisTbl values(" + DiagID.Text + " , " + PatientIDCb.SelectedValue.ToString() + ", " + PatientTb.Text + "', '" + SymptomsTb.Text + "', '" + DiagnosisTb.Text + "', '" + MedicineTb.Text + "')";
               SqlCommand cmd = new SqlCommand(query, con);
               cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Addede");
                con.close();
                populate();
            }
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        private void PatientIDCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fecthpatientname();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (DiagID.Text == "")
                MessageBox.Show("Enter The Diagnosis ID");
            else
            {
                con.open();
                string query = "delete from DiagnosisTbl where DiagID = " + DiagID.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Deleted");
                con.close();
                populate();
            }
        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagID.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIDCb.Text = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatientTb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            SymptomsTb.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            DiagnosisTb.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            MedicineTb.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            PatientNameLbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            DiagnosisLbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            SymptomsLbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            MediciensLbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.open();
            string query = "update DiagnosisTbl set PatID = "+ PatientIDCb.SelectedValue.ToString() +", PatName = '" + PatientTb.Text + "', Symptoms = '" + SymptomsTb.Text + "', Diagnosis = '"+DiagnosisTb.Text+ "', Medicines = '" + MedicineTb.Text + "' Where DiagID = " + DiagID.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Succesfully Updated");
            con.close();
            populate();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label4.Text , new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString(PatientNameLbl.Text + PatientNameLbl.Text +"\n"+ DiagnosisLbl.Text +"\n"+ SymptomsLbl.Text + "\n" + MediciensLbl.Text , new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130,150));
            e.Graphics.DrawString(label10.Text + "\n\t"+label11, new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(230,380));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
