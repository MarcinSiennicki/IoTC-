using System;
using System.Windows.Forms;
using IoT.Forms.UserControls;

namespace IoT.Forms
{
   

    public partial class FormMainBoard : Form
    {


    
        public FormMainBoard()
        {
          
            InitializeComponent();
            
            
            timerTime.Start();
            if (!panelCentre.Controls.Contains(UserControlHome.Instance))
            {
                panelCentre.Controls.Add(UserControlHome.Instance);
                UserControlHome.Instance.Dock = DockStyle.Fill;
                UserControlHome.Instance.BringToFront();
            }
            else
                UserControlHome.Instance.BringToFront();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void MoveSidePanel(Control msp)
        {
            panelSidePanel.Top = msp.Top;
            panelSidePanel.Height = msp.Height;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonHome);

            if(!panelCentre.Controls.Contains(UserControlHome.Instance))
            {
                panelCentre.Controls.Add(UserControlHome.Instance);
                UserControlHome.Instance.Dock = DockStyle.Fill;
                UserControlHome.Instance.BringToFront();
            }
            else
                UserControlHome.Instance.BringToFront();

        }

        private void buttonDevice_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDevice);

            if (!panelCentre.Controls.Contains(UserControlDev.Instance))
            {
                panelCentre.Controls.Add(UserControlDev.Instance);
                UserControlDev.Instance.Dock = DockStyle.Fill;
                UserControlDev.Instance.BringToFront();
            }
            else
                UserControlDev.Instance.BringToFront();
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonChart);

            if (!panelCentre.Controls.Contains(UserControlChart.Instance))
            {
                panelCentre.Controls.Add(UserControlChart.Instance);
                UserControlChart.Instance.Dock = DockStyle.Fill;
                UserControlChart.Instance.BringToFront();
            }
            else
                UserControlChart.Instance.BringToFront();
        }

        private void buttonCost_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonCost);

            if (!panelCentre.Controls.Contains(UserControlCost.Instance))
            {
                panelCentre.Controls.Add(UserControlCost.Instance);
                UserControlCost.Instance.Dock = DockStyle.Fill;
                UserControlCost.Instance.BringToFront();
            }
            else
                UserControlCost.Instance.BringToFront();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonSettings);

            if (!panelCentre.Controls.Contains(UserControlSettings.Instance))
            {
                panelCentre.Controls.Add(UserControlSettings.Instance);
                UserControlSettings.Instance.Dock = DockStyle.Fill;
                UserControlSettings.Instance.BringToFront();
            }
            else
                UserControlCost.Instance.BringToFront();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
  
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToShortDateString();
        }



        private void Form_mainBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
