using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace IoT.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private IContainer components = null;

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
                            
                            using (FormMainBoard mB = new FormMainBoard())
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            this.panel1 = new Panel();
            this.buttonClose = new Button();
            this.label3 = new Label();
            this.pictureBox1Icon = new PictureBox();
            this.pictureBox2Icon = new PictureBox();
            this.textBoxLogin = new TextBox();
            this.label2 = new Label();
            this.textBoxPassword = new TextBox();
            this.label4 = new Label();
            this.buttonLogin = new Button();
            this.label6 = new Label();
            this.buttonAddDB = new Button();
            this.label5 = new Label();
            this.label1 = new Label();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox1Icon)).BeginInit();
            ((ISupportInitialize)(this.pictureBox2Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1Icon);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1200, 60);
            this.panel1.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = Color.DarkSlateBlue;
            this.buttonClose.Dock = DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = Color.Red;
            this.buttonClose.FlatStyle = FlatStyle.Flat;
            this.buttonClose.Font = new Font("Verdana", 13.8F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = Color.Black;
            this.buttonClose.Image = ((Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new Point(1140, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(60, 60);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = Color.LightGray;
            this.label3.Location = new Point(73, 19);
            this.label3.Name = "label3";
            this.label3.Size = new Size(183, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Smart Platform";
            // 
            // pictureBox1Icon
            // 
            this.pictureBox1Icon.Image = ((Image)(resources.GetObject("pictureBox1Icon.Image")));
            this.pictureBox1Icon.Location = new Point(12, 3);
            this.pictureBox1Icon.Name = "pictureBox1Icon";
            this.pictureBox1Icon.Size = new Size(55, 55);
            this.pictureBox1Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1Icon.TabIndex = 2;
            this.pictureBox1Icon.TabStop = false;
            // 
            // pictureBox2Icon
            // 
            this.pictureBox2Icon.Anchor = AnchorStyles.None;
            this.pictureBox2Icon.Image = ((Image)(resources.GetObject("pictureBox2Icon.Image")));
            this.pictureBox2Icon.Location = new Point(525, 154);
            this.pictureBox2Icon.Name = "pictureBox2Icon";
            this.pictureBox2Icon.Size = new Size(150, 150);
            this.pictureBox2Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2Icon.TabIndex = 3;
            this.pictureBox2Icon.TabStop = false;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = AnchorStyles.None;
            this.textBoxLogin.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new Point(436, 389);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new Size(334, 32);
            this.textBoxLogin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = Color.DarkSlateBlue;
            this.label2.Location = new Point(431, 361);
            this.label2.Name = "label2";
            this.label2.Size = new Size(66, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = AnchorStyles.None;
            this.textBoxPassword.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new Point(436, 471);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new Size(334, 32);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = Color.DarkSlateBlue;
            this.label4.Location = new Point(431, 443);
            this.label4.Name = "label4";
            this.label4.Size = new Size(112, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password ";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = AnchorStyles.None;
            this.buttonLogin.BackColor = Color.DarkSlateBlue;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = FlatStyle.Flat;
            this.buttonLogin.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.ForeColor = Color.LightGray;
            this.buttonLogin.Location = new Point(436, 557);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new Size(334, 49);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new EventHandler(this.buttonLogin_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = Color.DarkSlateBlue;
            this.label6.Location = new Point(12, 686);
            this.label6.Name = "label6";
            this.label6.Size = new Size(513, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Copyrights  2018. All rights reserved by Marcin Siennicki. ";
            // 
            // buttonAddDB
            // 
            this.buttonAddDB.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.buttonAddDB.BackColor = SystemColors.ControlLight;
            this.buttonAddDB.FlatAppearance.BorderSize = 0;
            this.buttonAddDB.FlatStyle = FlatStyle.Flat;
            this.buttonAddDB.Font = new Font("Verdana", 13.8F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddDB.ForeColor = Color.Black;
            this.buttonAddDB.Image = ((Image)(resources.GetObject("buttonAddDB.Image")));
            this.buttonAddDB.Location = new Point(1127, 657);
            this.buttonAddDB.Name = "buttonAddDB";
            this.buttonAddDB.Size = new Size(61, 49);
            this.buttonAddDB.TabIndex = 12;
            this.buttonAddDB.UseVisualStyleBackColor = false;
            this.buttonAddDB.Click += new EventHandler(this.buttonAddDB_Click);
            // 
            // label5
            // 
            this.label5.Anchor = AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = Color.DarkSlateBlue;
            this.label5.Location = new Point(521, 519);
            this.label5.Name = "label5";
            this.label5.Size = new Size(192, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Forgot Password ? ";
            // 
            // label1
            // 
            this.label1.Anchor = AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = Color.DarkSlateBlue;
            this.label1.Location = new Point(514, 328);
            this.label1.Name = "label1";
            this.label1.Size = new Size(199, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plase Login First";
            // 
            // Form1
            // 
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.LightGray;
            this.ClientSize = new Size(1200, 720);
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
            this.Font = new Font("Verdana", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)(this.pictureBox1Icon)).EndInit();
            ((ISupportInitialize)(this.pictureBox2Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1Icon;
        private Label label3;
        private PictureBox pictureBox2Icon;
        private TextBox textBoxLogin;
        private Label label2;
        private TextBox textBoxPassword;
        private Label label4;
        private Button buttonLogin;
        private Label label6;
        private Button buttonClose;
        private Button buttonAddDB;
        private Label label5;
        private Label label1;
    }
}

