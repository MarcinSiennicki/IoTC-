using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace IoT.Forms.UserControls
{
    public partial class UserControlHome : UserControl
    {
       // static readonly object locker = new object();

        private static UserControlHome _instance;
        public static UserControlHome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlHome();
                return _instance;
            }
            set
            { }

        }


        public UserControlHome()
        {
           InitializeComponent();
           fillCombo();
           
            Insert();

            

        }


        public void Insert()
        {
            //pobranie listy device
            //List<Tuple<int,float>> DeviceList = new List<Tuple<int,float>>();
          


       
                Dictionary<int, double> DeviceList = new Dictionary<int, double>();
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
                string Query = "SELECT DeviceId,Power from DeviceDB Where CustomerId=" + Program.GlobalCorrectUserId + ";";
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connString;
                SqlCommand command = new SqlCommand(Query, conn);
                SqlDataReader reader;
                int numberOfDevice = 0;
               
                 try
                {
                    conn.Open();
                    reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        numberOfDevice++;
                      

                           int DeviceState = selectDeviceState(reader.GetInt32(0));

                          if (DeviceState == 1)
                                DeviceList.Add(reader.GetInt32(0), reader.GetDouble(1));
                               else
                           DeviceList.Add(reader.GetInt32(0), 0);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    Thread measurement = new Thread(() =>
                    {
                        while (true)
                        {
                            foreach (var element in DeviceList)
                            {

                                insertData(Program.GlobalCorrectUserId, element.Key, element.Value);

                                if (numberOfDevice != 0)
                                    Thread.Sleep(new TimeSpan(0, 0, 10 / numberOfDevice));
                            }
                        }
                    });


                    measurement.Start();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            


        }
        public void  changingBackground()
        {

            if (buttonSwitch.Text == "Off")
            {
                buttonSwitch.Text = "On";
                buttonSwitch.BackColor = Color.Green;

            }
             else
            {
                buttonSwitch.BackColor = Color.Red;
                buttonSwitch.Text = "Off";
            }
        }



        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxDevice.Text != "")
            {
                int DeviceId = loadDeviceId();
                int DeviceState = selectDeviceState(DeviceId);
                if (DeviceState == 1)
                {
                    buttonSwitch.Visible = true;
                    buttonSwitch.Text = "On";
                    buttonSwitch.BackColor = Color.Green;
                }

                else if (DeviceState == 0)
                {
                    buttonSwitch.Visible = true;
                    buttonSwitch.Text = "Off";
                    buttonSwitch.BackColor = Color.Red;
                }

                else
                    MessageBox.Show("Error");
            }
            else
                MessageBox.Show("Select Device");

        }

        private void Switch_Click(object sender, EventArgs e)
        {
            changingBackground();
            int DeviceId = loadDeviceId();
            
            int DeviceState = selectDeviceState(DeviceId);
            if (DeviceState == 1)
                updateDeviceState(DeviceId, 0);
            else if (DeviceState == 0)
                updateDeviceState(DeviceId, 1);
            else
                MessageBox.Show("Error");

        }

    }

        
 }
