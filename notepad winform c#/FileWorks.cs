using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace notepad_winform_c_
{
    internal class FileWorks
    {
        public static bool CheckTxtName(string txtName)
        {
            string filePath =txtName + ".txt";
            return File.Exists(filePath);
        }

        public static void WriteTextToFile(string text, string txtName)
        {
            string filePath = txtName + ".txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(text);
            }
        }

        public static string ReadTextFromFile(string txtName)
        {
            if (CheckTxtName(txtName))
            {
                string filePath =txtName + ".txt";
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return reader.ReadToEnd();
                }
            }
            else
            {
                return "";
            }
        }
    }
}
