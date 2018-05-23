using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;

namespace StartupUtils_Main
{
    class MainApplicationContext : ApplicationContext
    {
        private NotifyIcon icon;

        //The constructor adds the program to the autostart-registry of windows.
        public MainApplicationContext()
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rkApp.SetValue("SanguinesStartUpUtils", System.Reflection.Assembly.GetExecutingAssembly().Location);

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            InitializeComponent();
            icon.Visible = true;
            if (!OnStartup()) MessageBox.Show("A critical error occurred! Please report this issue to the Developer!");
        }

        //Initializes the system tray icon
        private void InitializeComponent()
        {
            icon = new NotifyIcon();

            icon.BalloonTipIcon = ToolTipIcon.Info;
            icon.Text = "Sanguine's Startup Utils";

            //The icon is added to the project resources.
            icon.Icon = Properties.Resources.icon;
            icon.DoubleClick += Icon_DoubleClick;
        }

        //Cleanup so that the icon will be removed if the application is ever closed.
        private void OnApplicationExit(object sender, EventArgs e)
        {
            icon.Visible = false;
        }

        //The options menu gets opened when the icon is doubleclicked.
        private void Icon_DoubleClick(object sender, EventArgs e)
        {
            Form main = new Form1();
            main.Show();
        }

        //This method handles all startup functions.
        private Boolean OnStartup()
        {
            try
            {
                Simple();
                Advanced();
            }
            catch
            {
                return false;
            }

            return true;
        }

        //This method executes the simple functions.
        private void Simple()
        {
            if (Convert.ToBoolean(File_Managment.ReadFromSettings("shutdownEnabled")))
            {
                ShutdownTimer();
            }

            if (Convert.ToBoolean(File_Managment.ReadFromSettings("programsEnabled")))
            {
                StartPrograms();
            }

            if (Convert.ToBoolean(File_Managment.ReadFromSettings("websitesEnabled")))
            {
                OpenWebsites();
            }

            if (Convert.ToBoolean(File_Managment.ReadFromSettings("soundsEnabled")))
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    SoundPlayer player = new SoundPlayer();
                    foreach (string line in File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Sounds.txt"))
                    {
                        try
                        {
                            player = new SoundPlayer(line);
                            player.PlaySync();
                            Thread.Sleep(TimeSpan.FromSeconds(Convert.ToDouble(File_Managment.ReadFromSettings("soundsDelay"))));
                        }
                        catch { }
                    }
                }).Start();
            }
        }

        //This method executes the advanced functions.
        private void Advanced()
        {
            foreach (string command in File_Managment.ReadFromCMD())
            {
                System.Diagnostics.Process.Start("cmd.exe", command);
            }
        }

        //This method starts the timer for system shutdown.
        private void ShutdownTimer()
        {
            double time;
            if (File_Managment.ReadFromSettings("shutdownTime") == null || Convert.ToInt32(File_Managment.ReadFromSettings("shutdownTime")) <= 10)
            {
                MessageBox.Show("Invalid shutdown Time! Setting time to 60 min.");
                time = TimeSpan.FromMinutes(60D).TotalMilliseconds;
                File_Managment.SaveToSettings("shutdownTime", "60");
            }
            else
            {
                time = TimeSpan.FromMinutes(Convert.ToDouble(File_Managment.ReadFromSettings("shutdownTime"))).TotalMilliseconds;
            }
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = time;
            aTimer.Enabled = true;
        }

        //Shuts down the system after the timer has run up and the warning has been ignored.
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            bool shutdown;
            var w = new Form() { Size = new Size(0, 0), TopMost = true };
            Task.Delay(TimeSpan.FromSeconds(25)).ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            if (MessageBox.Show(w, "Please press OK to abort system shutdown!", "Shutdown Timer") == DialogResult.OK)
            {
                shutdown = false;
            }
            else
            {
                shutdown = true;
            }

            if (shutdown == true)
            {
                var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
        }

        //Starts the programs in the Paths.txt file.
        private void StartPrograms()
        {
            foreach (string line in File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Paths.txt"))
            {
                try
                {
                    System.Diagnostics.Process.Start(line);
                }
                catch { }
            }
        }

        //Opens the websites in the Websites.txt
        private void OpenWebsites()
        {
            File_Managment.CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\", "Websites.txt");
            foreach (string line in File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Websites.txt"))
            {
                if (File_Managment.IsValidUri(line))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(line);
                    }
                    catch { }
                }
            }
        }
    }
}
