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

namespace Library
{
    public partial class AddStudent : Form
    {
        

        public AddStudent()
        {
            InitializeComponent();
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "" && txtEmail.Text != "" && txtcourse.Text != "")
            {
                string name = txtStudentName.Text;
                string birth = dateTimePicker1.Text;
                string reg=txtRegNo.Text;
                Int64 pnum = Int64.Parse(txtPhoneNum.Text);
                string email = txtEmail.Text;
                string cour = txtcourse.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-H1M0IH8\\SQLEXPRESS02; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = " insert into AddStudent(sName,dob,RegNo,pNum,email,course) values ('" + name + "','" + birth + "','" + reg + "'," + pnum + ",'" + email + "','" + cour + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                
                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtStudentName.Clear();
                txtEmail.Clear();
                txtPhoneNum.Clear();
                txtcourse.Clear();
                txtRegNo.Clear();
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields","Suggest",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
