using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IoT.Forms.UserControls
{
    public partial class UserControlChart : UserControl
    {
        
        private static UserControlChart _instance;
        public static UserControlChart Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlChart();
                return _instance;
            }
            set
            { }

        }
        public UserControlChart()
        {
            InitializeComponent();
           fillCombo();
           
    }

        private void chartCost_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            chartEnergyConsumtion.Series["Energy"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chartEnergyConsumtion.Series["Energy"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chartEnergyConsumtion.Series["Energy"].BorderWidth = 1;


            if (comboBoxPeriod.Text == "Day" )
            {
                chartEnergyConsumtion.Series["Energy"].Points.Clear();
                chartEnergyConsumtion.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "HH:mm";
                chartEnergyConsumtion.ChartAreas["ChartArea1"].AxisX.IntervalType = DateTimeIntervalType.Hours;
                chartEnergyConsumtion.ChartAreas["ChartArea1"].AxisX.Minimum = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 00, 00, 00).ToOADate();
                chartEnergyConsumtion.ChartAreas["ChartArea1"].AxisX.Maximum = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 23, 59, 00).ToOADate();
                chartEnergyConsumtion.ChartAreas["ChartArea1"].AxisX.Interval = 1;
              
                loadChart();
            }

           else if  (comboBoxPeriod.Text == "Month" )
            {
                chartEnergyConsumtion.Series["Energy"].Points.Clear();
                chartEnergyConsumtion.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/mm/yyyy";
                chartEnergyConsumtion.ChartAreas["ChartArea1"].AxisX.IntervalType = DateTimeIntervalType.Days;
                chartEnergyConsumtion.ChartAreas["ChartArea1"].AxisX.Minimum = new DateTime(dateTime.Year, dateTime.Month, 1, 00, 00, 00).ToOADate();
                chartEnergyConsumtion.ChartAreas["ChartArea1"].AxisX.Maximum = new DateTime(dateTime.Year, dateTime.Month,28, 23, 59, 00).ToOADate();
                chartEnergyConsumtion.ChartAreas["ChartArea1"].AxisX.Interval = 1;
               
                loadChart();
            }

            else
                MessageBox.Show("Select period or device");

        }

        private void comboBoxDevice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControlChart_Load(object sender, EventArgs e)
        {

        }
    }
}
