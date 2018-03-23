namespace _31.Process
{
    class Program
    {
        static void Main(string[] args)
        {
            // create method and pass content within it and search it in google 
            SearchContentOnGoogle("Trigger in sql server mindstick");
            
        }
        public static void SearchContentOnGoogle(string content)
        {


            //enter the search engine url 
            System.Diagnostics.Process.Start("http://google.com/search?q=" + content);
        }
    }
}
