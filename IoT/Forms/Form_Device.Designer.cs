using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IoT.Forms
{
    partial class FormDevice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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


       void insertDevice( int correctLogin)
        {
            try
            {
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
                                

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand();
                   
                    sqlCommand.CommandText = "insert into DeviceDB (DeviceName,Type,Power,CustomerId) values('" + this.textBoxName.Text + "','" + this.comboBoxType.Text + "','" + this.textBoxPower.Text + "','" + correctLogin + "');";

                    sqlCommand.Connection = conn;
                   
                    if (sqlCommand.ExecuteNonQuery() != 0)
                    {

                        string Query = "select top (1) DeviceId from DeviceDB where CustomerID = " + correctLogin + " order by DeviceId desc";
                        
                        SqlCommand command = new SqlCommand(Query, conn);
                        SqlDataReader reader;


                        reader = command.ExecuteReader();
                        Console.WriteLine("Wykonałem selecta");

                        while (reader.Read())
                        {
                            Program.GlobalDeviceId = reader.GetInt32(0);

                        }
                        Console.WriteLine(Program.GlobalDeviceId);
                        MessageBox.Show("Device added!");
                        textBoxName.Text = "";
                        comboBoxType.Text = "";
                        textBoxPower.Text = "";

                       
                        
                    }
                    changeState();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //

        void changeState()
        {
            try
            {
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";


                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand();

                    sqlCommand.CommandText = "insert into DeviceStateDB (DeviceId) values(" + Program.GlobalDeviceId + ");";

                    sqlCommand.Connection = conn;

                    if (sqlCommand.ExecuteNonQuery() != 0)
                    {

                    }
                }
            }
              
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
        //

        void loadDB()
        {
            try
            {
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT DeviceId  FROM DeviceDB;", conn);

                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                       
                        while (reader.Read())
                        {
                            Program.GlobalDeviceId = reader.GetInt32(0);
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

        //




        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddToDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(790, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 10);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(238, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name ";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxName.Font = new System.Drawing.Font("Verdana", 12.8F);
            this.textBoxName.Location = new System.Drawing.Point(244, 133);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(395, 33);
            this.textBoxName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(245, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Power";
            // 
            // textBoxPower
            // 
            this.textBoxPower.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxPower.Font = new System.Drawing.Font("Verdana", 12.8F);
            this.textBoxPower.Location = new System.Drawing.Point(244, 306);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(395, 33);
            this.textBoxPower.TabIndex = 7;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Electric",
            "Sensors"});
            this.comboBoxType.Location = new System.Drawing.Point(244, 219);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(395, 33);
            this.comboBoxType.TabIndex = 8;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(238, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddToDatabase
            // 
            this.buttonAddToDatabase.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonAddToDatabase.FlatAppearance.BorderSize = 0;
            this.buttonAddToDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToDatabase.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddToDatabase.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAddToDatabase.Location = new System.Drawing.Point(244, 365);
            this.buttonAddToDatabase.Name = "buttonAddToDatabase";
            this.buttonAddToDatabase.Size = new System.Drawing.Size(395, 49);
            this.buttonAddToDatabase.TabIndex = 11;
            this.buttonAddToDatabase.Text = "Add to Database";
            this.buttonAddToDatabase.UseVisualStyleBackColor = false;
            this.buttonAddToDatabase.Click += new System.EventHandler(this.buttonAddToDatabase_Click);
            // 
            // Form_Device
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddToDatabase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxPower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Device";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private TextBox textBoxPower;
        private ComboBox comboBoxType;
        private Label label3;
        private PictureBox pictureBox1;
        private Button buttonAddToDatabase;
    }
}