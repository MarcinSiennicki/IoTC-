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
    public partial class UserControlSettings : UserControl
    {
        private static UserControlSettings _instance;
        public static UserControlSettings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlSettings();
                return _instance;
            }
            set
            { }

        }
        public UserControlSettings()
        {
            InitializeComponent();
        }
    }
}
