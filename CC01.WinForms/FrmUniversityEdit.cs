using CC01.BLL;
using CC01.BO;
using CC01.DAL;
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
    public partial class FrmUniversityEdit : Form
    {
        private Action callBack;
        private University oldUniversity;

        public FrmUniversityEdit()
        {
            InitializeComponent();
        }

        public FrmUniversityEdit(Action callBack) : this()
        {
            this.callBack = callBack;
        }

        public FrmUniversityEdit(University university, Action callBack) : this(callBack)
        {
            this.oldUniversity = university;
            txtUniversityName.Text = oldUniversity.UniversityName;
            txtDate.Text = oldUniversity.Born;
            txtLocationUniversity.Text = oldUniversity.Location;
            txtContactUniversity.Text = oldUniversity.Contact.ToString();
            if (oldUniversity.Logo != null)
                pictureBoxUniversity.Image = Image.FromStream(new MemoryStream(oldUniversity.Logo));
        }

        private void FrmUniversityEdit_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxUniversity_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUniversity.ImageLocation = ofd.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                University newUniversity = new University
                (
                    txtUniversityName.Text.ToUpper(),
                    txtDate.Text,
                    txtLocationUniversity.Text,
                    long.Parse(txtContactUniversity.Text),
                    !string.IsNullOrEmpty(pictureBoxUniversity.ImageLocation) ? File.ReadAllBytes(pictureBoxUniversity.ImageLocation) : this.oldUniversity?.Logo
                );

                UniversityBLO universityBLO = new UniversityBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldUniversity == null)
                    universityBLO.CreateUniversity(newUniversity);
                else
                    universityBLO.EditUniversity(oldUniversity, newUniversity);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Close();


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
    }
}
