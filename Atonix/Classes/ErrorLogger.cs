using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atonix.Classes
{
    public static class ErrorLogger
    {
        public static void LoggerCode(string exp)
        {
            var logNum = Directory.GetFiles("./logs/").Length + 1;
            string LogMsg = $"Source: {exp}";

            File.WriteAllText($"./logs/Atonix Log {logNum}.txt", LogMsg);

            MessageBox.Show("Unfortunately, an error occured in Atonix. A log file was created at " + Environment.CurrentDirectory.ToString() + $"/logs/Atonix Log {logNum}", "Atonix - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
