using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Antivirus an = new Antivirus();

            // Will Fly if there is no method
            an.ScanComputer();


            an.OnScanFileComplete += An_OnScanFileComplete;
            an.OnScanFileComplete += (SuspiciousFile file, int a) =>
            {
                Console.WriteLine("File Number " + a + " finished");
            };
            
            an.ScanComputer();

            //an.OnScanFileComplete = (SuspiciousFile file, int a) =>
            //{
            //    Console.WriteLine("I removed The other delegates");
            //};

            //an.OnScanFileComplete -= (SuspiciousFile file, int a) =>
            //{
            //    Console.WriteLine(file.FileName + ": " + file.Size);
            //};

            an.OnScanFileComplete -= An_OnScanFileComplete;
            an.ScanComputer();

        }

        private static void An_OnScanFileComplete(SuspiciousFile file, int index)
        {
            Console.WriteLine(file.FileName + ": " + file.Size);
        }
    }
}
