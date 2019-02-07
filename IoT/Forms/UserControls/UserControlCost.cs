using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace IoT.Forms.UserControls
{
    public partial class UserControlCost : UserControl
    {
        private static UserControlCost _instance;
        public static UserControlCost Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlCost();
                return _instance;
            }
            set { _instance = value; }

        }

        private void InitializeComponent()
        {
            buttonCalculate = new Button();
            textBoxPrice = new TextBox();
            comboBoxDevice = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            labelCost = new Label();
            SuspendLayout();
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = Color.DarkSlateBlue;
            buttonCalculate.FlatAppearance.BorderSize = 0;
            buttonCalculate.FlatStyle = FlatStyle.Flat;
            buttonCalculate.Font = new Font("Verdana", 16.2F);
            buttonCalculate.ForeColor = Color.LightGray;
            buttonCalculate.Location = new Point(315, 267);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(245, 57);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = @"Calculate";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxPrice.Location = new Point(315, 80);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(245, 35);
            textBoxPrice.TabIndex = 7;
            // 
            // comboBoxDevice
            // 
            comboBoxDevice.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBoxDevice.FormattingEnabled = true;
            comboBoxDevice.Location = new Point(37, 80);
            comboBoxDevice.Name = "comboBoxDevice";
            comboBoxDevice.Items.AddRange(new object[] {
            "All"});

            comboBoxDevice.Size = new Size(245, 36);
            comboBoxDevice.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(310, 32);
            label1.Name = "label1";
            label1.Size = new Size(183, 29);
            label1.TabIndex = 9;
            label1.Text = @"Price [zl/kWh]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(32, 32);
            label3.Name = "label3";
            label3.Size = new Size(93, 29);
            label3.TabIndex = 11;
            label3.Text = @"Device";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSlateBlue;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(147, 429);
            label4.Name = "label4";
            label4.Size = new Size(0, 29);
            label4.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Location = new Point(0, 402);
            panel1.Name = "panel1";
            panel1.Size = new Size(1234, 41);
            panel1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(166, 488);
            label5.Name = "label5";
            label5.Size = new Size(116, 29);
            label5.TabIndex = 14;
            label5.Text = @"Cost [zł]";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelCost.ForeColor = Color.DarkSlateBlue;
            labelCost.Location = new Point(352, 488);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(0, 29);
            labelCost.TabIndex = 15;
            // 
            // UserControlCost
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(labelCost);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBoxDevice);
            Controls.Add(textBoxPrice);
            Controls.Add(buttonCalculate);
            Name = "UserControlCost";
            Size = new Size(1234, 570);
            Load += UserControlCost_Load;
            ResumeLayout(false);
            PerformLayout();

        }

     
        public UserControlCost()
       {
           InitializeComponent();
            fillCombo();
        
           
        }

        private void UserControlCost_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (textBoxPrice.Text != "")
            {
                float price = float.Parse(textBoxPrice.Text, CultureInfo.InvariantCulture);
                Console.WriteLine(price);

                if (comboBoxDevice.Text != @"All")
                {
                    int deviceId = loadDeviceId();
                    double avgDevicePower = avg(deviceId);
                    labelCost.Text = Convert.ToString((avgDevicePower * 24* price)/1000, CultureInfo.InvariantCulture);
                  //  DateTime day = DateTime.Now;

                   // DateTime time = dateTime(day.Year,day.Month,day.Day);
                  

                }
                else
                {
                    loadDeviceDB();
                }
            }
            else
                MessageBox.Show(@"Set price");
           
        }
    }
}
