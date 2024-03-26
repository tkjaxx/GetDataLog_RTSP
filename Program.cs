using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VideoCameraViewer02
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        //live555proxyserver -I 9999 -p 14550 -A 127.0.0.2 -N Payload  rtsp://192.168.2.119
    }
}
