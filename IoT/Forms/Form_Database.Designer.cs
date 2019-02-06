using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IoT.Forms
{
    partial class Form_Database
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        void insertAccount()
        {
            try
            {
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand();

                    sqlCommand.CommandText = "INSERT INTO CustomerDB (Name,Surname,Age,Login,Password,Email) values('" + this.textBoxNameDB.Text + "','" + this.textBoxSurnameDB.Text + "','" + this.textBoxAgeDB.Text + "','" + this.textBoxLoginDB.Text + "','" + this.textBoxPasswordDB.Text + "','" + this.textBoxEmailDB.Text + "');";

                    sqlCommand.Connection = conn;

                    if (sqlCommand.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Saved succesfully");

                        textBoxNameDB.Text = "";
                        textBoxSurnameDB.Text = "";
                        textBoxAgeDB.Text = "";
                        textBoxLoginDB.Text = "";
                        textBoxPasswordDB.Text = "";
                        textBoxEmailDB.Text = "";


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Database));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1Icon = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2Icon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSurnameDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoginDB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAgeDB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmailDB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPasswordDB = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1Icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 60);
            this.panel1.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1140, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(60, 60);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(73, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Smart Platform";
            // 
            // pictureBox1Icon
            // 
            this.pictureBox1Icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Icon.Image")));
            this.pictureBox1Icon.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1Icon.Name = "pictureBox1Icon";
            this.pictureBox1Icon.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Icon.TabIndex = 2;
            this.pictureBox1Icon.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(12, 691);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(513, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Copyrights  2018. All rights reserved by Marcin Siennicki. ";
            // 
            // pictureBox2Icon
            // 
            this.pictureBox2Icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2Icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2Icon.Image")));
            this.pictureBox2Icon.Location = new System.Drawing.Point(542, 66);
            this.pictureBox2Icon.Name = "pictureBox2Icon";
            this.pictureBox2Icon.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2Icon.TabIndex = 13;
            this.pictureBox2Icon.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(434, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Surname";
            // 
            // textBoxSurnameDB
            // 
            this.textBoxSurnameDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSurnameDB.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSurnameDB.Location = new System.Drawing.Point(439, 305);
            this.textBoxSurnameDB.Name = "textBoxSurnameDB";
            this.textBoxSurnameDB.Size = new System.Drawing.Size(334, 29);
            this.textBoxSurnameDB.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(434, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // textBoxNameDB
            // 
            this.textBoxNameDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNameDB.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNameDB.Location = new System.Drawing.Point(439, 237);
            this.textBoxNameDB.Name = "textBoxNameDB";
            this.textBoxNameDB.Size = new System.Drawing.Size(334, 29);
            this.textBoxNameDB.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(434, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Login";
            // 
            // textBoxLoginDB
            // 
            this.textBoxLoginDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLoginDB.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLoginDB.Location = new System.Drawing.Point(439, 442);
            this.textBoxLoginDB.Name = "textBoxLoginDB";
            this.textBoxLoginDB.Size = new System.Drawing.Size(334, 29);
            this.textBoxLoginDB.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(433, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Age";
            // 
            // textBoxAgeDB
            // 
            this.textBoxAgeDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAgeDB.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAgeDB.Location = new System.Drawing.Point(438, 373);
            this.textBoxAgeDB.Name = "textBoxAgeDB";
            this.textBoxAgeDB.Size = new System.Drawing.Size(334, 29);
            this.textBoxAgeDB.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(433, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Email";
            // 
            // textBoxEmailDB
            // 
            this.textBoxEmailDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmailDB.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmailDB.Location = new System.Drawing.Point(438, 584);
            this.textBoxEmailDB.Name = "textBoxEmailDB";
            this.textBoxEmailDB.Size = new System.Drawing.Size(334, 29);
            this.textBoxEmailDB.TabIndex = 24;
            this.textBoxEmailDB.TextChanged += new System.EventHandler(this.textBoxEmailDB_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(432, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Password";
            // 
            // textBoxPasswordDB
            // 
            this.textBoxPasswordDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPasswordDB.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPasswordDB.Location = new System.Drawing.Point(437, 514);
            this.textBoxPasswordDB.Name = "textBoxPasswordDB";
            this.textBoxPasswordDB.Size = new System.Drawing.Size(334, 29);
            this.textBoxPasswordDB.TabIndex = 22;
            this.textBoxPasswordDB.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.ForeColor = System.Drawing.Color.LightGray;
            this.buttonLogin.Location = new System.Drawing.Point(439, 630);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(334, 49);
            this.buttonLogin.TabIndex = 26;
            this.buttonLogin.Text = "Create";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Form_Database
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEmailDB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPasswordDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLoginDB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAgeDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSurnameDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameDB);
            this.Controls.Add(this.pictureBox2Icon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Database";
            this.Text = "Age";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Database_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pictureBox1Icon;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.PictureBox pictureBox2Icon;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxSurnameDB;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxNameDB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxLoginDB;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBoxAgeDB;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBoxEmailDB;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBoxPasswordDB;
    private System.Windows.Forms.Button buttonLogin;
}
}