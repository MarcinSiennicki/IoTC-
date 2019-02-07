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
            set { _instance = value; }

        }
        public UserControlSettings()
        {
            InitializeComponent();
        }
    }
}
