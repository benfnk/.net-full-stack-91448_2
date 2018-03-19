using System.Collections.Generic;
using System.Threading;

namespace Events
{
    public delegate void FileScannedHandler(SuspiciousFile file, int index);

    public class Antivirus
    {
        public event FileScannedHandler OnScanFileComplete;

        public void ScanComputer()
        {
            int i = 0;
            GetSuspiciusFile().ForEach((suspiciusFile) =>
            {
                // Sacnning File
                Thread.Sleep(1000);

                if (i++ % 7 == 0)
                {
                    // Virus Found

                }

                // Finished Scanning File i
                OnScanFileComplete?.Invoke(suspiciusFile, i);
            });
        }

        public static List<SuspiciousFile> GetSuspiciusFile()
        {
            return new List<SuspiciousFile>()
            {
                new SuspiciousFile(){FileName ="GrandTheftAute5", Size = 16000 },
                new SuspiciousFile(){FileName ="GrandTheftAute4", Size = 4000 },
                new SuspiciousFile(){FileName ="GrandTheftAute3", Size = 1000 }
            };
        }
    }
}
