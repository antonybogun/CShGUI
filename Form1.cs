using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Label label1, label2, label3, label4;
        TextBox txtName, txtProgram, txtSemester, txtEmail;
        Button btnSubmit;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtProgram = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtSemester = new System.Windows.Forms.TextBox();
            btnSubmit = new System.Windows.Forms.Button();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 13);
            label1.TabIndex = 0;
            label1.Text = "Student Name:";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(96, 18);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(100, 20);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 53);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 13);
            label2.TabIndex = 0;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 79);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 13);
            label3.TabIndex = 0;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(15, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 13);
            label4.TabIndex = 0;
            label4.Text = "Semester:";
            // 
            // txtProgram
            // 
            txtProgram.Location = new System.Drawing.Point(96, 46);
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new System.Drawing.Size(100, 20);
            txtProgram.TabIndex = 1;



            txtEmail.Location = new System.Drawing.Point(96, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(100, 20);
            txtEmail.TabIndex = 1;



            txtSemester.Location = new System.Drawing.Point(96, 98);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new System.Drawing.Size(100, 20);
            txtSemester.TabIndex = 1;



            btnSubmit.Location = new System.Drawing.Point(96, 124);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(100, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            this.Controls.Add(txtProgram);
            this.Controls.Add(txtEmail);
            this.Controls.Add(txtSemester);
            this.Controls.Add(txtName);
            this.Controls.Add(btnSubmit);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            button1.Visible = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtName.Text = "John Doe";
            txtProgram.Text = "SET";
            txtEmail.Text = "jdoe@cc.ca";
            txtSemester.Text = "2";
            
        }
    }
}
