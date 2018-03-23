namespace ManualResetEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            UrlDownloader d = new UrlDownloader("http://www.ynet.co.il", "myFile");
            d.Start();
        }
    }
}
