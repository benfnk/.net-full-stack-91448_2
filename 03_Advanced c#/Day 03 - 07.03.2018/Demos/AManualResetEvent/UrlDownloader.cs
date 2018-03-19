using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AManualResetEvent
{
    class UrlDownloader
    {
        private string _url;
        private string _fileName;
        private string html;
        private ManualResetEvent manualResetEvent = new ManualResetEvent(false); // false states that the object is Reset, thus threads waiting for it will stop until Set is called.

        public UrlDownloader(string url, string fileName)
        {
            _url = url;
            _fileName = fileName;
        }

        // Starting each function in a different thread:
        public void Start()
        {
            //manualResetEvent.Reset();
            Thread tRequest = new Thread(Request);
            tRequest.Start();
            Thread tSave = new Thread(Save);
            tSave.Start();
            Thread tShow = new Thread(Show);
            tShow.Start();
            Thread tCount = new Thread(Count);
            tCount.Start();
        }

        // Requesting the url's html:
        private void Request()
        {
            WebRequest request = WebRequest.Create(_url);
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();

                    // Download completed.

                    manualResetEvent.Set(); // Signals all to continute.
                }
            }
        }

        // Saving to file:
        private void Save()
        {
            using (StreamWriter writer = new StreamWriter(_fileName))
            {
                manualResetEvent.WaitOne(); // Waiting for the Set.
                writer.Write(html); // Must wait for download to complete.
            }
        }

        // Showing on console:
        private void Show()
        {
            manualResetEvent.WaitOne(); // Waiting for the Set.
            Console.WriteLine(html); // Must wait for download to complete.
        }

        // Counting elements:
        private void Count()
        {
            int counter = 0;
            StringBuilder sb = new StringBuilder();

            manualResetEvent.WaitOne(); // Waiting for the Set.
            sb.Append(html); // Must wait for download to complete.

            for (int i = 0; i < sb.Length; i++)
                if (sb[i] == '<')
                    counter++;

            MessageBox.Show("There are about " + counter + " html elements in this page.");
        }
    }
}
