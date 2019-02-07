using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

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
            set { _instance = value; }

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
          


       
                Dictionary<int, double> deviceList = new Dictionary<int, double>();
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
                string query = "SELECT DeviceId,Power from DeviceDB Where CustomerId=" + Program.GlobalCorrectUserId + ";";
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connString;
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader;
                int numberOfDevice = 0;
               
                 try
                {
                    conn.Open();
                    reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        numberOfDevice++;
                      

                           int deviceState = selectDeviceState(reader.GetInt32(0));

                          if (deviceState == 1)
                                deviceList.Add(reader.GetInt32(0), reader.GetDouble(1));
                               else
                           deviceList.Add(reader.GetInt32(0), 0);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    void Start()
                    {
                        while (true)
                        {
                            foreach (var element in deviceList)
                            {
                                insertData(Program.GlobalCorrectUserId, element.Key, element.Value);

                                if (numberOfDevice != 0) Thread.Sleep(new TimeSpan(0, 0, 10 / numberOfDevice));
                            }
                        }
                        // ReSharper disable once FunctionNeverReturns
                    }

                    Thread measurement = new Thread(Start);


                    measurement.Start();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            


        }
        public void  ChangingBackground()
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
                int deviceId = loadDeviceId();
                int DeviceState = selectDeviceState(deviceId);
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
                    MessageBox.Show(@"Error");
            }
            else
                MessageBox.Show(@"Select Device");

        }

        private void Switch_Click(object sender, EventArgs e)
        {
            ChangingBackground();
            int deviceId = loadDeviceId();
            
            int deviceState = selectDeviceState(deviceId);
            if (deviceState == 1)
                updateDeviceState(deviceId, 0);
            else if (deviceState == 0)
                updateDeviceState(deviceId, 1);
            else
                MessageBox.Show(@"Error");

        }

    }

        
 }
