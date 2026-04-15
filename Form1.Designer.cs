using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DesktopInformationSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnListStudent = new Button();
            btnTeachingStaff = new Button();
            btnAdministrator = new Button();
            btnListAll = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnModify = new Button();
            btnSubject = new Button();
            lbSelectedID = new Label();
            tbName = new TextBox();
            tbPhone = new TextBox();
            tbEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pnStudent = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnStudent.SuspendLayout();
            SuspendLayout();
            // 
            // btnListStudent
            // 
            btnListStudent.Location = new Point(40, 53);
            btnListStudent.Name = "btnListStudent";
            btnListStudent.Size = new Size(113, 29);
            btnListStudent.TabIndex = 0;
            btnListStudent.Text = "Student";
            btnListStudent.UseVisualStyleBackColor = true;
            btnListStudent.Click += Student_Click;
            // 
            // btnTeachingStaff
            // 
            btnTeachingStaff.Location = new Point(169, 53);
            btnTeachingStaff.Name = "btnTeachingStaff";
            btnTeachingStaff.Size = new Size(113, 29);
            btnTeachingStaff.TabIndex = 1;
            btnTeachingStaff.Text = "Teaching staff";
            btnTeachingStaff.UseVisualStyleBackColor = true;
            btnTeachingStaff.Click += Teaching_Click;
            // 
            // btnAdministrator
            // 
            btnAdministrator.Location = new Point(300, 53);
            btnAdministrator.Name = "btnAdministrator";
            btnAdministrator.Size = new Size(113, 29);
            btnAdministrator.TabIndex = 2;
            btnAdministrator.Text = "Administrator";
            btnAdministrator.UseVisualStyleBackColor = true;
            btnAdministrator.Click += Administrator_Click;
            // 
            // btnListAll
            // 
            btnListAll.Location = new Point(887, 165);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(94, 29);
            btnListAll.TabIndex = 3;
            btnListAll.Text = "List All";
            btnListAll.UseVisualStyleBackColor = true;
            btnListAll.Click += ListAll_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(940, 385);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(40, 94);
            label1.Name = "label1";
            label1.Size = new Size(160, 50);
            label1.TabIndex = 5;
            label1.Text = "User List";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(54, 299);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Add_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(887, 119);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += Remove_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(220, 299);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(148, 29);
            btnModify.TabIndex = 8;
            btnModify.Text = "Update Student";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += Modify_Click;
            // 
            // btnSubject
            // 
            btnSubject.Location = new Point(432, 53);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(113, 29);
            btnSubject.TabIndex = 9;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = true;
            btnSubject.Click += Subject_Click;
            // 
            // lbSelectedID
            // 
            lbSelectedID.AutoSize = true;
            lbSelectedID.Location = new Point(41, 169);
            lbSelectedID.Name = "lbSelectedID";
            lbSelectedID.RightToLeft = RightToLeft.No;
            lbSelectedID.Size = new Size(189, 20);
            lbSelectedID.TabIndex = 10;
            lbSelectedID.Text = "User is selected in User List:";
            // 
            // tbName
            // 
            tbName.Location = new Point(144, 103);
            tbName.Name = "tbName";
            tbName.Size = new Size(180, 27);
            tbName.TabIndex = 11;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(144, 165);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(180, 27);
            tbPhone.TabIndex = 12;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(144, 230);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(180, 27);
            tbEmail.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 106);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 15;
            label2.Text = "Name of student : ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 172);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 16;
            label3.Text = "Phone                  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 233);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 17;
            label4.Text = "Email                   :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(118, 23);
            label5.Name = "label5";
            label5.Size = new Size(161, 32);
            label5.TabIndex = 18;
            label5.Text = "Student Panel";
            label5.Click += label5_Click;
            // 
            // pnStudent
            // 
            pnStudent.BackColor = SystemColors.GrayText;
            pnStudent.Controls.Add(label5);
            pnStudent.Controls.Add(label4);
            pnStudent.Controls.Add(btnModify);
            pnStudent.Controls.Add(label3);
            pnStudent.Controls.Add(btnAdd);
            pnStudent.Controls.Add(label2);
            pnStudent.Controls.Add(tbName);
            pnStudent.Controls.Add(tbEmail);
            pnStudent.Controls.Add(tbPhone);
            pnStudent.Location = new Point(1002, 202);
            pnStudent.Name = "pnStudent";
            pnStudent.Size = new Size(416, 385);
            pnStudent.TabIndex = 19;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1702, 744);
            Controls.Add(pnStudent);
            Controls.Add(lbSelectedID);
            Controls.Add(btnSubject);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnListAll);
            Controls.Add(btnAdministrator);
            Controls.Add(btnTeachingStaff);
            Controls.Add(btnListStudent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnStudent.ResumeLayout(false);
            pnStudent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListStudent;
        private Button btnTeachingStaff;
        private Button btnAdministrator;
        private Button btnListAll;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnModify;
        private Button btnSubject;
        private Label lbSelectedID;
        private TextBox tbName;
        private TextBox tbPhone;
        private TextBox tbEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel pnStudent;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}