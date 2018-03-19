using System;

namespace GenericEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Antivirus an = new Antivirus();
            an.OnScanFileComplete += An_OnScanFileComplete;
            // Will Fly if there is no method
            an.ScanComputer();
        }

        private static void An_OnScanFileComplete(object sender, FileScanedEventArgs e)
        {
            Console.WriteLine(e.File.FileName);
        }
    }
}
