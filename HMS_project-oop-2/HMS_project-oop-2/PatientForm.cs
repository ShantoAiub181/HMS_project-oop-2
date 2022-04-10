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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0TO85P3;Initial Catalog=HMSdb;Integrated Security=True");
        void populate()
        {
            con.open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
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
            if (PatientID.Text == "" || PatName.Text == "" || PatAd.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || MajorTb.Text == "" )
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                con.open();
                string query = "insert into PatientTbl values(" + PatientID.Text + " , '" + PatName.Text + "', " + PatAd.Text + ", '" + PatPhone.Text + "', '" + PatAge.Text + "', '" + GenderCb.SelectedItem.ToString() + "' , '" + BloodCb.SelectedItem.ToString() + "', '" + MajorTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Addede");
                con.close();
                populate();
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatientID.Text == "")
                MessageBox.Show("Enter The Patient ID");
            else
            {
                con.open();
                string query = "delete from PatientTbl where PatientID = " + PatientID.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                con.close();
                populate();
            }
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientID.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAd.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            MajorTb.Text = PatientGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.open();
            string query = "update PatientTbl set PatName = '" + PatName.Text + "', PatAd = '" + PatAd.Text + "' , PatPhone = '" + PatPhone.Text + "', PatGender = '" + GenderCb.SelectedItem.ToString() + "', PatBlood = '" + BloodCb.SelectedItem.ToString() + "' Where PatientID = " + PatientID.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Succesfully Updated");
            con.close();
            populate();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
