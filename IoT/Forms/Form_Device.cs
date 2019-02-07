using System;
using System.Windows.Forms;

namespace IoT.Forms
{
    public partial class FormDevice : Form
    {
        public FormDevice()
        {
            InitializeComponent();
        }

    

        private void buttonAddToDatabase_Click(object sender, EventArgs e)
        {
            insertDevice(Program.GlobalCorrectUserId);
          
            Dispose();
            
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
