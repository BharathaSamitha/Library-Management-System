using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook abs= new AddBook();
            abs.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb= new ViewBook();
            vb.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent ast = new AddStudent();
            ast.Show();
        }

        private void viewStudentInFoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent vStu = new ViewStudent();
            vStu.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook isuBook = new IssueBook();
            isuBook.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cbd= new CompleteBookDetails();
            cbd.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to Exit?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
