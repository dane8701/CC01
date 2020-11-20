using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmStudentEdit : Form
    {
        private Action callBack;
        private Student oldStudent;
        public FrmStudentEdit()
        {
            InitializeComponent();
        }

        public FrmStudentEdit(Action callBack) : this()
        {
            this.callBack = callBack;
        }

        public FrmStudentEdit(Student student, Action callBack) : this(callBack)
        {
            this.oldStudent = student;
            txtUniversity.Text = oldStudent.University;
            txtFirstname.Text = oldStudent.Firstname;
            txtLastname.Text = oldStudent.Lastname;
            txtDate.Text = oldStudent.Born;
            txtLocationStudent.Text = oldStudent.LocationStudent;
            txtContactStudent.Text = (oldStudent.Contact).ToString();
            if (oldStudent.Picture != null)
                pictureBoxStudent.Image = Image.FromStream(new MemoryStream(student.Picture));

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void FrmStudentEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                Student newStudent = new Student
                (
                    txtUniversity.Text.ToUpper(),
                    txtFirstname.Text,
                    txtLastname.Text,
                    txtDate.Text,
                    txtLocationStudent.Text,
                    long.Parse(txtContactStudent.Text),
                    !string.IsNullOrEmpty(pictureBoxStudent.ImageLocation) ? File.ReadAllBytes(pictureBoxStudent.ImageLocation) : this.oldStudent?.Picture
                );

                StudentBLO productBLO = new StudentBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldStudent == null)
                    productBLO.CreateStudent(newStudent);
                else
                    productBLO.EditStudent(oldStudent, newStudent);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldStudent != null)
                    Close();

                txtUniversity.Clear();
                txtLastname.Clear();
                txtFirstname.Clear();
                txtDate.Clear();
                txtContactStudent.Clear();
                txtLocationStudent.Clear();

            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Duplicate error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Not found error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudent.ImageLocation = ofd.FileName;
            }
        }
    }
}
