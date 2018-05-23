using System;
using System.IO;
using System.Linq;

namespace StartupUtils_Main
{
    class File_Managment
    {
        //=================================================================================================[Miscellaneous]=====================================================================================================

        // Checks if a folder or file exists, and creates it if not.
        public static void CreateDirFile(string path, string file)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path + "\\" + file) && file != null)
            {
                FileStream fs = File.Create(path + file);
                fs.Close();
            }
        } 

        //=================================================================================================[Options]=====================================================================================================

        //Saves a value to the settings.txt file and overwrites the old one.
        public static void SaveToSettings(string name, string value)
        {
            CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings", "Settings.txt");
            var oldLines = System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Settings.txt");
            var newLines = oldLines.Where(line => !line.Contains(name));
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Settings.txt", newLines);

            using (StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Settings.txt"))
            {
                sw.WriteLine(name + "=" + value);
            }
        }

        //Reads a value from the settings.txt file and returns it.
        public static string ReadFromSettings(string name)
        {
            string value = null;
            CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings", "//Settings.txt");

            using (StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Settings.txt"))
            {
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    else if (line.Split('=')[0] == name)
                    {
                        value = line.Split('=')[1];
                    }
                }
            }
            return value;
        }

        //Saves a command to the cmd.txt file.
        public static void SaveToCMD(string[] lines)
        {
            CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\", null);

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\cmd.txt"))
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\cmd.txt");

            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\cmd.txt", lines);
        }

        //Reads all commands from the cmd.txt file and returns them as a string array.
        public static string[] ReadFromCMD()
        {
            CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\", "cmd.txt");
            return File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\cmd.txt");
        }

        //Saves a .exe path to the Paths.txt file.
        public static void addPath(string path)
        {
            CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings", "Paths.txt");

            using (StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Paths.txt"))
            {
                sw.WriteLine(path);
            }
        }

        //Removes a .exe path from the Paths.txt file.
        public static void removePath(string path)
        {
            CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings", "Paths.txt");

            var oldLines = System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Paths.txt");
            var newLines = oldLines.Where(line => !line.Contains(path));
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Paths.txt", newLines);
        }

        //Saves a URI to the Websites.txt file.
        public static void SaveToWebsites(string[] lines)
        {
            CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings", null);

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Websites.txt"))
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Websites.txt");

            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Websites.txt", lines);
        }

        //Checks if a URI is valid.
        public static bool IsValidUri(string uri)
        {
            if (!Uri.IsWellFormedUriString(uri, UriKind.Absolute))
                return false;
            Uri tmp;
            if (!Uri.TryCreate(uri, UriKind.Absolute, out tmp))
                return false;
            return tmp.Scheme == Uri.UriSchemeHttp || tmp.Scheme == Uri.UriSchemeHttps;
        }

        //Saves a .wav path to the Sounds.txt file.
        public static void addSound(string path)
        {
            CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings", "Sounds.txt");

            using (StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Sounds.txt"))
            {
                sw.WriteLine(path);
            }
        }

        //Removes a .wav path from the Sounds.txt file.
        public static void removeSound(string path)
        {
            CreateDirFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings", "Sounds.txt");

            var oldLines = System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Sounds.txt");
            var newLines = oldLines.Where(line => !line.Contains(path));
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SanguinesStartUpUtils\\Settings\\Sounds.txt", newLines);
        }
    }
}

