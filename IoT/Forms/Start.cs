using System;
using System.Windows.Forms;

namespace IoT.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
          loadDB();   
            
            
        }

        private void buttonAddDB_Click(object sender, EventArgs e)
        {
            using (FormDatabase dB = new FormDatabase())
            {
                dB.ShowDialog();
            }
        }
    }
}
