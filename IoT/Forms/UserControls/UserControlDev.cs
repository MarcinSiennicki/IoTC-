using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT.Forms.UserControls
{
    public partial class UserControlDev : UserControl
    {

        private static UserControlDev _instance;
        public static UserControlDev Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlDev();
                return _instance;
            }
            set
            { }

        }
        public UserControlDev()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (Form_Device fd = new Form_Device())
            {
                fd.ShowDialog();
            }
        }

        private void UserControlDev_Load(object sender, EventArgs e)
        {

        }
    }
}
