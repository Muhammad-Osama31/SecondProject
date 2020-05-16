using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void viewAllStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.MdiParent = this;
            this.Hide();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Main ans = new Main();
            ans.MdiParent = this;
            ans.Show();
        }
    }
}
