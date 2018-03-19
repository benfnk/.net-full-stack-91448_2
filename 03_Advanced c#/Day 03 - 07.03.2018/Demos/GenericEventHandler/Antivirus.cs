using System;
using System.Collections.Generic;
using System.Threading;

namespace GenericEventHandler
{
    public class SuspiciousFile
    {
        public string FileName { get; set; }

        public int Size { get; set; }
    }

    public class FileScanedEventArgs
    {
        public SuspiciousFile File { get; set; }

        public int FileIndex{ get; set; }
    }
        

    public class Antivirus
    {
        public event EventHandler<FileScanedEventArgs> OnScanFileComplete;

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
                OnScanFileComplete?.Invoke(this, new FileScanedEventArgs()
                {
                    File = suspiciusFile,
                    FileIndex = i
                });
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
