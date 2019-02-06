using IoT.Forms;
using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IoT
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Kod generowany przez Projektanta formularzy systemu Windows

        //void loadDB()
        //{

        //    string provider = ConfigurationManager.AppSettings["provider"];
        //    string connectionString = ConfigurationManager.AppSettings["connectionString"];
        //    int count = 0;

        //    DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
        //    try
        //    {
        //        using (DbConnection connection = factory.CreateConnection())
        //        {
        //            if (connection == null)
        //                Console.WriteLine("Connection errror");

        //            connection.ConnectionString = connectionString;

        //            connection.Open();
        //            DbCommand command = factory.CreateCommand();

        //            if (command == null)
        //            {
        //                Console.WriteLine("Command errror");
        //            }

        //            command.Connection = connection;
        //            command.CommandText = "SELECT * FROM UserDB ";// WHERE Login='" + this.textBoxLogin.Text + "'and Password='" + this.textBoxPassword.Text + "'";


        //            using (DbDataReader dataReader = command.ExecuteReader())
        //            {
        //                while (dataReader.Read())
        //                {
        //                    count++;

        //                    if (count == 1)
        //                    {

        //                        MessageBox.Show("Login and password is correct");
        //                        Program.GlobalCorrectUserId = Convert.ToInt16($"{dataReader["UserId"]}");
        //                        using (Form_mainBoard mB = new Form_mainBoard())
        //                        {
        //                            mB.ShowDialog();
        //                            this.Dispose();
        //                        }
        //                    }


        //                    else if (count > 1)
        //                    {
        //                        textBoxLogin.Text = "";
        //                        textBoxPassword.Text = "";
        //                        MessageBox.Show("Duplicated Username and Password");
        //                    }
        //                    else
        //                    {
        //                        textBoxLogin.Text = "";
        //                        textBoxPassword.Text = "";
        //                        MessageBox.Show("Login or password is not correct");
        //                    }
        //                    connection.Close();


        //                }

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}


        void loadDB()
        {
            try
            {
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT* FROM CustomerDB WHERE Login='" + this.textBoxLogin.Text + "'and Password='" + this.textBoxPassword.Text + "';", conn);

                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int count = 0;
                        while (reader.Read())
                        {
                            count++;
                            Program.GlobalCorrectUserId = reader.GetInt32(0);
                        }
                        if (count == 1)
                        {
                            MessageBox.Show("Login and password is correct");
                            
                            using (Form_mainBoard mB = new Form_mainBoard())
                            {
                                mB.ShowDialog();
                                this.Dispose();
                            }
                            
                        }
                        else if (count > 1)
                        {
                            textBoxLogin.Text = "";
                            textBoxPassword.Text = "";
                            MessageBox.Show("Duplicated Username and Password");
                        }
                        else
                        {
                            textBoxLogin.Text = "";
                            textBoxPassword.Text = "";
                            MessageBox.Show("Login or password is not correct");
                        }
                        conn.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1Icon = new System.Windows.Forms.PictureBox();
            this.pictureBox2Icon = new System.Windows.Forms.PictureBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddDB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 0;
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
            // pictureBox2Icon
            // 
            this.pictureBox2Icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2Icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2Icon.Image")));
            this.pictureBox2Icon.Location = new System.Drawing.Point(525, 154);
            this.pictureBox2Icon.Name = "pictureBox2Icon";
            this.pictureBox2Icon.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2Icon.TabIndex = 3;
            this.pictureBox2Icon.TabStop = false;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(436, 389);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(334, 32);
            this.textBoxLogin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(431, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(436, 471);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(334, 32);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(431, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password ";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.ForeColor = System.Drawing.Color.LightGray;
            this.buttonLogin.Location = new System.Drawing.Point(436, 557);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(334, 49);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(12, 686);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(513, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Copyrights  2018. All rights reserved by Marcin Siennicki. ";
            // 
            // buttonAddDB
            // 
            this.buttonAddDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAddDB.FlatAppearance.BorderSize = 0;
            this.buttonAddDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDB.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddDB.ForeColor = System.Drawing.Color.Black;
            this.buttonAddDB.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddDB.Image")));
            this.buttonAddDB.Location = new System.Drawing.Point(1127, 657);
            this.buttonAddDB.Name = "buttonAddDB";
            this.buttonAddDB.Size = new System.Drawing.Size(61, 49);
            this.buttonAddDB.TabIndex = 12;
            this.buttonAddDB.UseVisualStyleBackColor = false;
            this.buttonAddDB.Click += new System.EventHandler(this.buttonAddDB_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(521, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Forgot Password ? ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(514, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plase Login First";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddDB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.pictureBox2Icon);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1Icon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2Icon;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAddDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}

