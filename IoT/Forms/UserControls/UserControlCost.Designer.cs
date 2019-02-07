using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IoT.Forms.UserControls
{
    partial class UserControlCost
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

        private Button buttonCalculate;
        private TextBox textBoxPrice;
        private ComboBox comboBoxDevice;
        private Label label1;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Label labelCost;



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

        void loadDeviceDB()
        {

            {
                List<int> deviceId = new List<int>();  
                string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";

                string Query = "SELECT * from DeviceDB ;";
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
                        deviceId.Add(reader.GetInt32(0));
                        
                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

               

            }
        }

       double avg( int deviceId )
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
            int DeviceId = loadDeviceId();
            string Query = "SELECT AVG(Power)FROM MeasDB Where DeviceID='" + DeviceId + "';";
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

                    return reader.GetDouble(0);

                };

                return 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        
    }

        //  DateTime  dateTime(int Year,int Month,int Day)
        //{
        //    string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\source\\repos\\IoT\\IoT\\IoT.mdf;Integrated Security=True";
        //    int DeviceId = loadDeviceId();
        //    string Query = "SELECT time FROM MeasDB Where Time='"+ Day + "-" +Month +"-"+Year+ "';";
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = connString;
        //    SqlCommand command = new SqlCommand(Query, conn);
        //    SqlDataReader reader;


        //    try
        //    {
        //        conn.Open();
        //        reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {


        //        };

           

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
              
        //    }

        //}





    }
    #region Kod wygenerowany przez Projektanta składników


    /// <summary> 
    /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
    /// jej zawartości w edytorze kodu.
    /// </summary>


}

      #endregion

    
    

