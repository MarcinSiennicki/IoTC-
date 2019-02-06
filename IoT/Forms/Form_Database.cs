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

namespace IoT.Forms
{
    public partial class Form_Database : Form
    {
        public Form_Database()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
