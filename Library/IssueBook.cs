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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-H1M0IH8\\SQLEXPRESS02; database = Library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bName from NewBook", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }
        int count;
        private void btnSearchStu_Click(object sender, EventArgs e)
        {
            if (txtRegistrationNo.Text != "")
            {
                string rdi = txtRegistrationNo.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-H1M0IH8\\SQLEXPRESS02; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from AddStudent where regNo = '" + rdi + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);

                cmd.CommandText = "select count(Rerister_no) from IssueBooks where Rerister_no = '" + rdi + "'and book_return_date is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                DA.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtStuName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDiploma.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPhoneNum.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    txtStuName.Clear();
                    txtDiploma.Clear();
                    txtPhoneNum.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Invalid Registration No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtStuName.Text != "")
            {
                if (comboBox1.SelectedIndex != -1 && count <= 2)
                {
                    String reg = txtRegistrationNo.Text;
                    String sname = txtStuName.Text;
                    String dip = txtDiploma.Text;
                    Int64 pnum = Int64.Parse(txtPhoneNum.Text);
                    String email = txtEmail.Text;
                    String bname = comboBox1.Text;
                    String bookisu = dateTimePicker1.Text;

                    string rdi = txtRegistrationNo.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-H1M0IH8\\SQLEXPRESS02; database = Library;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into IssueBooks(Rerister_no,stu_name,diploma,phone_no,email,book_name,book_issue_date) values ('" + reg + "','" + sname + "','" + dip + "'," + pnum + ",'" + email + "','" + bname + "','" + bookisu + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Select Book.OR Maxium number of Book has been Issued", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter valid Registration No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void txtRegistrationNo_TextChanged(object sender, EventArgs e)
            {  
            
                if (txtRegistrationNo.Text == "")
                {
                    txtStuName.Clear();
                    txtDiploma.Clear();
                    txtEmail.Clear();
                    txtPhoneNum.Clear();
                    txtPhoneNum.Clear();
                
                }
            }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtRegistrationNo.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
