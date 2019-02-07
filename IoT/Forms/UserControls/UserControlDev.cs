using System;
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
            set { _instance = value; }

        }
        public UserControlDev()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormDevice fd = new FormDevice())
            {
                fd.ShowDialog();
            }
        }

        private void UserControlDev_Load(object sender, EventArgs e)
        {

        }
    }
}
