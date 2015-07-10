using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Livestreamer
{
    class Program
    {
        [STAThread]
        static int Main()
        {
            Core livestreamer = new Core();
            string url = livestreamer.GetClipboard();
            livestreamer.StartLivestreamerProcess(url);
            return 0;
        }

        
    }
    public class Core
    {
        public string GetClipboard()
        {
            string clipboard = Clipboard.GetText();
            return clipboard;
        }
        public void StartLivestreamerProcess(string url, string quality = "best")
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = "livestreamer.exe",
                Arguments = url + " " + quality
            };
            process.Start();
        }
    }
}
