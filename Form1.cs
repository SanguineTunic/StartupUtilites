using System;
using System.Windows.Forms;
using Microsoft.Win32;
using Microsoft.VisualBasic.Devices;
using System.Management;
using System.Diagnostics;
using System.IO;

namespace StartupUtils_Main
{
    public partial class Form1 : Form
    {
        //The Constructor is only used to instantiate the GUI.
        public Form1()
        {
            InitializeComponent();
        }

        //Loads all the Settings.
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            getSystemDetails();
        }

        //Closes the Window if it gets minimized.
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Close();
            }
        }

        //Gets the system details and sets the text of the labels.
        public void getSystemDetails()
        {
            ComputerInfo cinfo = new ComputerInfo();

            osLabel.Text = "OS: " + getOSInfo(); // OS version of pc
            nameLabel.Text = "Machine: " + Environment.MachineName;// Machine name
            string OStype = "";
            if (Environment.Is64BitOperatingSystem) { OStype = "64-Bit, "; } else { OStype = "32-Bit, "; }
            OStype += Environment.ProcessorCount.ToString() + " Cores";
            cpuLabel.Text = "Processor: " + OStype; // Processor type
            graphicsLabel.Text = getGraphics();

            ulong toalRam = cinfo.TotalPhysicalMemory;
            double toal = Convert.ToDouble(toalRam / (1024 * 1024));
            int t = Convert.ToInt32(Math.Ceiling(toal / 1024).ToString());
            ramLabel.Text = "RAM: " + t.ToString() + " GB";// ram detail
        }

        //Gets the used graphics card and returns it.
        private string getGraphics()
        {
            string returnName = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_VideoController");
            foreach (ManagementObject obj in searcher.Get())
            {
                returnName = ("Graphics: " + obj["Name"]);
            }

            return returnName;
        }

        //Gets the used OS and returns it.
        private string getOSInfo()
        {
            string registry_key = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            var key = Registry.LocalMachine.OpenSubKey(registry_key);
            var value = key.GetValue("ProductName");
            return value.ToString();
        }

        //Event-Handler that saves the simple options.
        private void applySimpleButton_Click(object sender, EventArgs e)
        {
            File_Managment.SaveToSettings("shutdownEnabled", shutdownCheck.Checked.ToString());
            int shutdownint = 0;
            int.TryParse(shutdownTimeTextBox.Text, out shutdownint);
            if ( shutdownint <= 10 || shutdownTimeTextBox.Text == null)
            {
                shutdownTimeTextBox.Text = "15";
            }

            File_Managment.SaveToSettings("shutdownTime", shutdownTimeTextBox.Text);
            File_Managment.SaveToSettings("programsEnabled", startProgram.Checked.ToString());
            File_Managment.SaveToSettings("websitesEnabled", openWebsite.Checked.ToString());
            File_Managment.SaveToSettings("soundsEnabled", playSounds.Checked.ToString());
            File_Managment.SaveToSettings("soundsDelay", soundsDelay.Text);

            File_Managment.SaveToWebsites(websitesTextBox.Lines);
            MessageBox.Show("A restart is required to apply the changes.");
        }

        //Event-Handler that saves the advanced options.
        private void applyAdvancedButton_Click(object sender, EventArgs e)
        {
            File_Managment.SaveToCMD(cmdTextBox.Lines);
            MessageBox.Show("A restart is required to apply the changes.");
        }

        //The method that loads all the settings in from the txt files.
        private void LoadSettings()
        {
            File_Managment.CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\", "Paths.txt");
            File_Managment.CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\", "Websites.txt");
            File_Managment.CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\", "Sounds.txt");

            //Simple
            shutdownCheck.Checked = Convert.ToBoolean(File_Managment.ReadFromSettings("shutdownEnabled"));
            shutdownTimeTextBox.Text = File_Managment.ReadFromSettings("shutdownTime");
            startProgram.Checked = Convert.ToBoolean(File_Managment.ReadFromSettings("programsEnabled"));
            openWebsite.Checked = Convert.ToBoolean(File_Managment.ReadFromSettings("websitesEnabled"));
            playSounds.Checked = Convert.ToBoolean(File_Managment.ReadFromSettings("soundsEnabled"));
            soundsDelay.Text = File_Managment.ReadFromSettings("soundsDelay");

            programTextBox.Lines = getExecutableName();
            programTextBox.SelectionStart = programTextBox.Text.Length;
            programTextBox.ScrollToCaret();
            soundTextBox.Lines = getSoundName();
            soundTextBox.SelectionStart = soundTextBox.Text.Length;
            soundTextBox.ScrollToCaret();
            websitesTextBox.Lines = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Websites.txt");
            websitesTextBox.SelectionStart = websitesTextBox.Text.Length;
            websitesTextBox.ScrollToCaret();

            //Advanced
            cmdTextBox.Lines = File_Managment.ReadFromCMD();
        }

        //Event-Handler that adds a program to the program textbox.
        private void addProgrammBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executables(*.exe)|*.exe";
            openFileDialog.Title = "Add programm to list.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File_Managment.addPath(openFileDialog.FileName);
            }

            programTextBox.Lines = getExecutableName();
            programTextBox.SelectionStart = programTextBox.Text.Length;
            programTextBox.ScrollToCaret();
        }

        //Event-Handler that removes a program from the program textbox. (Subject to changes)
        private void removeProgrammBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executables(*.exe)|*.exe";
            openFileDialog.Title = "Add programm to list.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File_Managment.removePath(openFileDialog.FileName);
            }

            programTextBox.Lines = getExecutableName();
            programTextBox.SelectionStart = programTextBox.Text.Length;
            programTextBox.ScrollToCaret();
        }

        //This method returns the Names of the .exe files from the Paths.txt file.
        private string[] getExecutableName()
        {
            string[] oldlines = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Paths.txt");
            string[] newlines = new string[oldlines.Length];
            int i = 0;

            foreach (string line in oldlines)
            {
                int idx = line.LastIndexOf('\\');

                if (idx != -1)
                    newlines[i] = (line.Substring(idx + 1));
                else
                    newlines[i] = line;
                i++;
            }

            return newlines;
        }

        //This method returns the Names of the .wav files from the Sounds.txt file.
        private string[] getSoundName()
        {
            string[] oldlines = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Sounds.txt");
            string[] newlines = new string[oldlines.Length];
            int i = 0;

            foreach (string line in oldlines)
            {
                int idx = line.LastIndexOf('\\');

                if (idx != -1)
                    newlines[i] = (line.Substring(idx + 1));
                else
                    newlines[i] = line;
                i++;
            }

            return newlines;
        }

        //Event-Handler that adds a sound to the sounds textbox.
        private void addSoundBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Sound Files(*.wav)|*.wav";
            openFileDialog.Title = "Add sound to list.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File_Managment.addSound(openFileDialog.FileName);
            }

            soundTextBox.Lines = getSoundName();
            soundTextBox.SelectionStart = soundTextBox.Text.Length;
            soundTextBox.ScrollToCaret();
        }

        //Event-Handler that removes a sound from the sounds textbox. (Subject to changes)
        private void removeSoundBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Sound Files(*.wav)|*.wav";
            openFileDialog.Title = "Add sound to list.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File_Managment.removeSound(openFileDialog.FileName);
            }

            soundTextBox.Lines = getSoundName();
            soundTextBox.SelectionStart = soundTextBox.Text.Length;
            soundTextBox.ScrollToCaret();
        }

        //Event-Handler that opens a link when the hyperlink is clicked.
        private void website1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sanguinetunic.github.io/");
        }

        //Event-Handler that opens a link when the hyperlink is clicked.
        private void website2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.tapatalk.com/groups/sanguinetunic/forum-f2");
        }
    }
}