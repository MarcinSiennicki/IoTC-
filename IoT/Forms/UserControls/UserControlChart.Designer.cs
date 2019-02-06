using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace IoT.Forms.UserControls
{
    partial class UserControlChart
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

        void loadChart()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
            int DeviceId=loadDeviceId();
            string Query = "SELECT * from MeasDB Where DeviceId='"+DeviceId+"';";
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
                    
                    this.chartEnergyConsumtion.Series["Energy"].Points.AddXY( reader.GetDateTime(1),reader.GetDouble(2));
                 
                };


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

        public void fillCombo()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
            string Query = "SELECT * from DeviceDB WHERE CustomerID='" + Program.GlobalCorrectUserId+ "' ;";
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
        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartEnergyConsumtion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.labelDevice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartEnergyConsumtion)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEnergyConsumtion
            // 
            this.chartEnergyConsumtion.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chartEnergyConsumtion.ChartAreas.Add(chartArea1);
            this.chartEnergyConsumtion.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            legend1.Name = "Legend1";
            this.chartEnergyConsumtion.Legends.Add(legend1);
            this.chartEnergyConsumtion.Location = new System.Drawing.Point(38, 135);
            this.chartEnergyConsumtion.Name = "chartEnergyConsumtion";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Energy";
            this.chartEnergyConsumtion.Series.Add(series1);
            this.chartEnergyConsumtion.Size = new System.Drawing.Size(1029, 421);
            this.chartEnergyConsumtion.TabIndex = 0;
            this.chartEnergyConsumtion.Text = "chart1";
            this.chartEnergyConsumtion.UseWaitCursor = true;
            this.chartEnergyConsumtion.Click += new System.EventHandler(this.chartCost_Click);
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "Day",
            "Month"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(53, 58);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(186, 40);
            this.comboBoxPeriod.TabIndex = 1;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPeriod.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelPeriod.Location = new System.Drawing.Point(47, 21);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(103, 34);
            this.labelPeriod.TabIndex = 2;
            this.labelPeriod.Text = "Period";
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(320, 58);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(186, 40);
            this.comboBoxDevice.TabIndex = 3;
            this.comboBoxDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevice_SelectedIndexChanged);
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDevice.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelDevice.Location = new System.Drawing.Point(314, 21);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(112, 34);
            this.labelDevice.TabIndex = 4;
            this.labelDevice.Text = "Device";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 16.2F);
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(761, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Load Chart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.comboBoxPeriod);
            this.Controls.Add(this.chartEnergyConsumtion);
            this.Name = "UserControlChart";
            this.Size = new System.Drawing.Size(1234, 570);
            this.Load += new System.EventHandler(this.UserControlChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEnergyConsumtion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEnergyConsumtion;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.Button button1;
    }
}
