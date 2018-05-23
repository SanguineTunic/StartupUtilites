using System;
using System.Threading;
using System.Windows.Forms;

namespace StartupUtils_Main
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{DC5EB4B3-B34F-420D-948D-2B32D799E649}");

        //Uses a unique Mutex to only allow one instance of the program running at the same time.
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainApplicationContext());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("An instance is already running!");
            }
        }
    }
}
