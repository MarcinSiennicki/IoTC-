using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IoT.Forms.UserControls
{
    partial class UserControlChart
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            this.chartEnergyConsumtion = new Chart();
            this.comboBoxPeriod = new ComboBox();
            this.labelPeriod = new Label();
            this.comboBoxDevice = new ComboBox();
            this.labelDevice = new Label();
            this.button1 = new Button();
            ((ISupportInitialize)(this.chartEnergyConsumtion)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEnergyConsumtion
            // 
            this.chartEnergyConsumtion.BackColor = Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chartEnergyConsumtion.ChartAreas.Add(chartArea1);
            this.chartEnergyConsumtion.Cursor = Cursors.WaitCursor;
            legend1.Name = "Legend1";
            this.chartEnergyConsumtion.Legends.Add(legend1);
            this.chartEnergyConsumtion.Location = new Point(38, 135);
            this.chartEnergyConsumtion.Name = "chartEnergyConsumtion";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Energy";
            this.chartEnergyConsumtion.Series.Add(series1);
            this.chartEnergyConsumtion.Size = new Size(1029, 421);
            this.chartEnergyConsumtion.TabIndex = 0;
            this.chartEnergyConsumtion.Text = "chart1";
            this.chartEnergyConsumtion.UseWaitCursor = true;
            this.chartEnergyConsumtion.Click += new EventHandler(this.chartCost_Click);
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "Day",
            "Month"});
            this.comboBoxPeriod.Location = new Point(53, 58);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new Size(186, 40);
            this.comboBoxPeriod.TabIndex = 1;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.labelPeriod.ForeColor = Color.DarkSlateBlue;
            this.labelPeriod.Location = new Point(47, 21);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new Size(103, 34);
            this.labelPeriod.TabIndex = 2;
            this.labelPeriod.Text = "Period";
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new Point(320, 58);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new Size(186, 40);
            this.comboBoxDevice.TabIndex = 3;
            this.comboBoxDevice.SelectedIndexChanged += new EventHandler(this.comboBoxDevice_SelectedIndexChanged);
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            this.labelDevice.ForeColor = Color.DarkSlateBlue;
            this.labelDevice.Location = new Point(314, 21);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new Size(112, 34);
            this.labelDevice.TabIndex = 4;
            this.labelDevice.Text = "Device";
            // 
            // button1
            // 
            this.button1.BackColor = Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Font = new Font("Verdana", 16.2F);
            this.button1.ForeColor = Color.LightGray;
            this.button1.Location = new Point(761, 58);
            this.button1.Name = "button1";
            this.button1.Size = new Size(245, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Load Chart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // UserControlChart
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.LightGray;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.comboBoxPeriod);
            this.Controls.Add(this.chartEnergyConsumtion);
            this.Name = "UserControlChart";
            this.Size = new Size(1234, 570);
            this.Load += new EventHandler(this.UserControlChart_Load);
            ((ISupportInitialize)(this.chartEnergyConsumtion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chart chartEnergyConsumtion;
        private ComboBox comboBoxPeriod;
        private Label labelPeriod;
        private ComboBox comboBoxDevice;
        private Label labelDevice;
        private Button button1;
    }
}
