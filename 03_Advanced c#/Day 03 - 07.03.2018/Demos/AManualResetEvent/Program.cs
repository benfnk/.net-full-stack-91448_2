namespace AManualResetEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            UrlDownloader d = new UrlDownloader("http://www.ynet.co.il", "shubidubi");
            d.Start();
        }
    }
}
