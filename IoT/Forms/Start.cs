using IoT.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
          loadDB();   
            
            
        }

        private void buttonAddDB_Click(object sender, EventArgs e)
        {
            using (Form_Database dB = new Form_Database())
            {
                dB.ShowDialog();
            }
        }
    }
}
