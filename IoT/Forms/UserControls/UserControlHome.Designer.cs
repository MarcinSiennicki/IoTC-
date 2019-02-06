using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace IoT.Forms.UserControls
{
    partial class UserControlHome
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

        public void insertData(int CustomerId, int DeviceId, double DevicePower)
        {
            try
            {
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";

                                
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connString;
                    conn.Open();

                    SqlCommand sqlCommand = new SqlCommand();
           
                    sqlCommand.CommandText = "insert into MeasDB (Time,Power,CustomerId,DeviceId) values(GETDATE(),"+DevicePower+","+CustomerId+"," + DeviceId + ");";
                    
                    sqlCommand.Connection = conn;

                    if (sqlCommand.ExecuteNonQuery() != 0)
                    {

                        conn.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void fillCombo()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
            string Query = "SELECT * from DeviceDB WHERE CustomerID='" + Program.GlobalCorrectUserId + "' ;";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connString;
            SqlCommand command = new SqlCommand(Query, conn);
            SqlDataReader reader;
            try
            {
                conn.Open();
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    comboBoxDevice.Items.Add(reader.GetString(1));

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int loadDeviceId()
        {

            {
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
                string Query = "SELECT * from DeviceDB WHERE DeviceName='" + comboBoxDevice.Text + "' ;";
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connString;
                SqlCommand command = new SqlCommand(Query, conn);
                SqlDataReader reader;
                try
                {
                    conn.Open();
                    reader = command.ExecuteReader();


                    while (reader.Read())
                    {

                        return reader.GetInt32(0);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return 0;
            }
        }
        int selectDeviceState(int DeviceId)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
            string Query = "SELECT * from DeviceStateDB Where DeviceId='" + DeviceId + "';";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connString;
            SqlCommand command = new SqlCommand(Query, conn);
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    return reader.GetInt32(1);

                };

                return 0;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        void updateDeviceState(int DeviceId, int DeviceState)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
            string Query = "Update DeviceStateDB Set State ="+DeviceState+" Where DeviceId='" + DeviceId + "';";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connString;
            SqlCommand command = new SqlCommand(Query, conn);
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                };

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               
            }
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(42, 36);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(233, 36);
            this.comboBoxDevice.TabIndex = 3;
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonSelect.FlatAppearance.BorderSize = 0;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("Verdana", 16.2F);
            this.buttonSelect.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSelect.Location = new System.Drawing.Point(300, 36);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(245, 57);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.BackColor = System.Drawing.Color.Red;
            this.buttonSwitch.FlatAppearance.BorderSize = 0;
            this.buttonSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitch.Font = new System.Drawing.Font("Verdana", 16.2F);
            this.buttonSwitch.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSwitch.Location = new System.Drawing.Point(616, 36);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(245, 57);
            this.buttonSwitch.TabIndex = 7;
            this.buttonSwitch.Text = "Off";
            this.buttonSwitch.UseVisualStyleBackColor = false;
            this.buttonSwitch.Visible = false;
            this.buttonSwitch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // UserControlHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.comboBoxDevice);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(1350, 553);
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox comboBoxDevice;
        private Button buttonSelect;
        private Button buttonSwitch;
    }
}
