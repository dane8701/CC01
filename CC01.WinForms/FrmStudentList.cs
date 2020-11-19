using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmStudentList : Form
    {
        private StudentBLO studentBLO;
        private UniversityBLO companyBLO;
        public FrmStudentList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            studentBLO = new StudentBLO(ConfigurationManager.AppSettings["DbFolder"]);
            companyBLO = new UniversityBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form f = new FrmStudentEdit(loadData);
            f.Show();
        }

        private void loadData()
        {
            string value = txtSearch.Text.ToLower();
            var products = studentBLO.GetBy
            (
                x =>
                x.Reference.ToLower().Contains(value)
            ).OrderBy(x => x.Reference).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this product(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        studentBLO.DeleteStudent(dataGridView1.SelectedRows[i].DataBoundItem as Student);
                    }
                    loadData();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                loadData();
            else
                txtSearch.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /*
            List<StudentListPrint> items = new List<StudentListPrint>();
            University university = universityBLO.GetUniversity();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Student p = dataGridView1.Rows[i].DataBoundItem as Student;
                items.Add
                (
                   new StudentListPrint
                   (
                       p.Reference,
                       p.Name,
                       p.UnitPrice,
                       p.Picture,
                       university?.Name,
                       university?.Email,
                       university?.PhoneNumber.ToString(),
                       university?.PostalCode,
                       !string.IsNullOrEmpty(university?.Logo) ? File.ReadAllBytes(university?.Logo) : null
                    )
                );
            }
            Form f = new FrmPreview("StudentListRpt.rdlc", items);
            f.Show();
            */
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FrmStudentEdit
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Student,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }
    }
}
