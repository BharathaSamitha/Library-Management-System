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
using static System.Windows.Forms.AxHost;

namespace Library
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtBookPrice.Text != "" && txtQuantity.Text != "")

            {
                String bname = txtBookName.Text;
                String bauthor = txtAuthor.Text;
                String publication = txtPublication.Text;
                String pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtBookPrice.Text);
                Int64 quen = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-H1M0IH8\\SQLEXPRESS02; database = Library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (bName,bAuthor,bPubl,bDate,bPrice,bQuen) values ('" + bname + "' , '" + bauthor + "' , '" + publication + "' , '" + pdate + "' , " + price + "," + quen + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtQuantity.Clear();
                txtBookPrice.Clear();
            }
            else
            {
                MessageBox.Show("Empty textbox not allowed", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
