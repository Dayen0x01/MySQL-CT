using System;
using System.Windows.Forms;

namespace MySQL_CT
{
    public class Log
    {
        private static RichTextBox richLog = new RichTextBox();

        public static void Initialize(RichTextBox txtLog)
        {
            richLog = txtLog;
            Write($"Initializing log!");
        }

        public static void Write(string Message)
        {
            string date = $"[{DateTime.Now.ToLongTimeString()}] ";
            richLog.Text += Environment.NewLine + date + Message;
        }
    }
}
