using Bridge.Contract;
using Bridge.Translator.Utils;
using System.Diagnostics;
using System.IO;

namespace Bridge.Translator
{
    public partial class Translator
    {
        public virtual void RunEvent(string e)
        {
            var info = new ProcessStartInfo()
            {
                FileName = e
            };
            info.WindowStyle = ProcessWindowStyle.Hidden;

            if (!File.Exists(e))
            {
                throw new TranslatorException("The specified file '" + e + "' couldn't be found." +
                    "\nWarning: Bridge.NET translator working directory: " + Directory.GetCurrentDirectory());
            }

            using (var p = Process.Start(info))
            {
                p.WaitForExit();

                if (p.ExitCode != 0)
                {
                    throw new TranslatorException("Error: The command '" + e + "' returned with exit code: " + p.ExitCode);
                }
            }
        }
    }
}
