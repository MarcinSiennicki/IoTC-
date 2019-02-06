using IoT.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT.Forms
{
   

    public partial class Form_mainBoard : Form
    {


    
        public Form_mainBoard()
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
            this.Dispose();
        }

       

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCentre.Controls.Clear();
            panelCentre.Controls.Add(c);
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control msp)
        {
            panelSidePanel.Top = msp.Top;
            panelSidePanel.Height = msp.Height;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonHome);

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
            moveSidePanel(buttonDevice);

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
            moveSidePanel(buttonChart);

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
            moveSidePanel(buttonCost);

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
            moveSidePanel(buttonSettings);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
