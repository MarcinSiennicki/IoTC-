using System;
using System.Windows.Forms;

namespace IoT.Forms
{
    public partial class FormDatabase : Form
    {
        public FormDatabase()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            insertAccount();
            
        }

        private void Form_Database_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEmailDB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
