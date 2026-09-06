using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD
{
    internal static class clsUtil
    {
        private static string _FilePath = "remember_me.txt";

        public static void SaveRememberMeData(string Username, string Password)
        {
            if (frmLogin.IsRememberMeChecked)
            {
                string DataToSave = Username + Environment.NewLine + Password;
                File.WriteAllText(_FilePath, DataToSave);
            }

            else
                if (File.Exists(_FilePath))
                    File.Delete(_FilePath);
        }

        public static bool LoadDataFromFile(ref string Username, ref string Password)
        {
            if (File.Exists(_FilePath))
            {
                string[] Lines = File.ReadAllLines(_FilePath);

                if (Lines.Length >= 2)
                {
                    Username = Lines[0];
                    Password = Lines[1];
                }

                return true;
            }

            return false;
        }
    }
}
