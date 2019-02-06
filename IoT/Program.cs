using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private static int globalCorrectUserId;

        public static int GlobalCorrectUserId
        {
            get { return globalCorrectUserId; }
            set { globalCorrectUserId = value; }
        }

        private static int globalDeviceId;
        public static int GlobalDeviceId
        {
            get { return globalDeviceId; }
            set { globalDeviceId = value; }
        }


     

    }
}
