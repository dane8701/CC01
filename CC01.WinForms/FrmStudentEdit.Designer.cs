﻿namespace CC01.WinForms
{
    partial class FrmStudentEdit
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.Label();
            this.txtLieuStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactStudent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerStudent = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUniversity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom / Last name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(29, 114);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(233, 26);
            this.txtLastname.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(32, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 26);
            this.textBox2.TabIndex = 2;
            // 
            // txtFirstname
            // 
            this.txtFirstname.AutoSize = true;
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(27, 153);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(151, 20);
            this.txtFirstname.TabIndex = 2;
            this.txtFirstname.Text = "Prénom / First name";
            // 
            // txtLieuStudent
            // 
            this.txtLieuStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLieuStudent.Location = new System.Drawing.Point(106, 261);
            this.txtLieuStudent.Name = "txtLieuStudent";
            this.txtLieuStudent.Size = new System.Drawing.Size(232, 26);
            this.txtLieuStudent.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Né(e) le / Born on ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "A / At";
            // 
            // txtContactStudent
            // 
            this.txtContactStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactStudent.Location = new System.Drawing.Point(106, 298);
            this.txtContactStudent.Name = "txtContactStudent";
            this.txtContactStudent.Size = new System.Drawing.Size(232, 26);
            this.txtContactStudent.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact ";
            // 
            // dateTimePickerStudent
            // 
            this.dateTimePickerStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStudent.Location = new System.Drawing.Point(159, 219);
            this.dateTimePickerStudent.Name = "dateTimePickerStudent";
            this.dateTimePickerStudent.Size = new System.Drawing.Size(231, 26);
            this.dateTimePickerStudent.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(31, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(246, 88);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(283, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(235, 88);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Location = new System.Drawing.Point(318, 42);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(200, 138);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStudent.TabIndex = 9;
            this.pictureBoxStudent.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Picture";
            // 
            // txtUniversity
            // 
            this.txtUniversity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniversity.Location = new System.Drawing.Point(30, 45);
            this.txtUniversity.Name = "txtUniversity";
            this.txtUniversity.Size = new System.Drawing.Size(233, 26);
            this.txtUniversity.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Université / University ";
            // 
            // FrmStudentEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.txtUniversity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxStudent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePickerStudent);
            this.Controls.Add(this.txtContactStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLieuStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentEdit";
            this.Text = "StudentEdit";
            this.Load += new System.EventHandler(this.FrmStudentEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtFirstname;
        private System.Windows.Forms.TextBox txtLieuStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerStudent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUniversity;
        private System.Windows.Forms.Label label6;
    }
}
