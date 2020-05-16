using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\osama\source\repos\WindowsFormsApp14\WindowsFormsApp14\Database1.mdf;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var adpt = new SqlDataAdapter("Select * FROM Student", conn);
            adpt.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables["Student"];
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var adpt = new SqlDataAdapter("Select * FROM Student", conn);
            adpt.Fill(ds, "Student");

            DataRow dv = ds.Tables["Student"].NewRow();
            dv["Name"] = txtStudentName.Text;
            dv["Email"] = txtStudentEmail.Text;
            dv["Address"] = txtStudentAddress.Text;
            adpt.Update(ds, "Student");
            SqlCommandBuilder comm = new SqlCommandBuilder(adpt);
            adpt.Update(ds, "Student");
            MessageBox.Show("Student As Added Succesfully");
        }
    }
}
