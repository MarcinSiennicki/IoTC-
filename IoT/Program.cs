using System;
using System.Windows.Forms;
using IoT.Forms;

namespace IoT
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static int _globalCorrectUserId;

        public static int GlobalCorrectUserId
        {
            get { return _globalCorrectUserId; }
            set { _globalCorrectUserId = value; }
        }

        private static int _globalDeviceId;
        public static int GlobalDeviceId
        {
            get { return _globalDeviceId; }
            set { _globalDeviceId = value; }
        }


     

    }
}
