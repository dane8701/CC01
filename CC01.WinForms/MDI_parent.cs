using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class MDI_parent : Form
    {
        public MDI_parent()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentEdit form = new FrmStudentEdit();
            form.MdiParent = this;
            form.Show();
        }

        private void universityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUniversityEdit form = new FrmUniversityEdit();
            form.MdiParent = this;
            form.Show();
        }

        private void formStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentList form = new FrmStudentList();
            form.MdiParent = this;
            form.Show();
        }

        private void formUniversityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUniversityList form = new FrmUniversityList();
            form.MdiParent = this;
            form.Show();
        }

        private void quittezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDI_parent_Load(object sender, EventArgs e)
        {

        }
    }
}
