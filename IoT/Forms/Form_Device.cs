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
    public partial class Form_Device : Form
    {
        public Form_Device()
        {
            InitializeComponent();
        }

    

        private void buttonAddToDatabase_Click(object sender, EventArgs e)
        {
            insertDevice(Program.GlobalCorrectUserId);
          
            this.Dispose();
            
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
