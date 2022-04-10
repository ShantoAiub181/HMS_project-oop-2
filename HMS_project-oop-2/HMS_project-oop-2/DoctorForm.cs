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
    public partial class DoctorForm : Form
    {
        SqlConnection con = new SqlConnection (@"Data Source = DESKTOP - 0TO85P3; Initial Catalog = HMSdb; Integrated Security = True");

       
        public DoctorForm()
        {
            InitializeComponent();
        }

        void populate()
        {
            con.open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            con.close();
        }
        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocID.Text == "" || DocName.Text == "" || DocPass.Text == "" || DocExp.Text == "")
                MessageBox.Show("No Empty Fill Accepted");
            else
            {
                con.open();
                string query = "insert into DoctorTbl values(" + DocID.Text + " , '" + DocName.Text + "', " + DocExp.Text + ", '" + DocPass.Text + "' )";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Addede");
                con.close();
                populate();
            }
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            if (DocID.Text == "")
                MessageBox.Show("Enter The Doctor ID");
            else
            {
                con.open();
                string query = "delete from DoctorTbl where DocID = " + DocID.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");
                con.close();
                populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocID.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            DocExp.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.open();
            string query = "update DoctorTbl set DocName = '" + DocName.Text + "', DocExp = '" + DocExp.Text + "', DocPass = '" + DocPass.Text + "' Where DocID = " + DocID.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Succesfully Updated");
            con.close();
            populate();
             
        }
    }
}
