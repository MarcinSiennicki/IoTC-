using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT.Forms
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
            set
            { }

        }
        //public UserControlCost()
        //{
        //    InitializeComponent();
        //}

        //private void buttonCalculate_Click(object sender, EventArgs e)
        //{
        //    loadDeviceToList();
        //}
    }
}
