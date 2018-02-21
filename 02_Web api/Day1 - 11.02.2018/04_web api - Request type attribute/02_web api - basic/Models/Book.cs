using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_web_api___basic.Models
{
    public class Book
    {
        public VolumeInfo volumeInfo { get; set; }
    }



    public class ImageLinks
    {
        public string smallThumbnail { get; set; }
        public string thumbnail { get; set; }
    }

    public class VolumeInfo
    {
        public string title { get; set; }
        public List<string> authors { get; set; }
        public string publisher { get; set; }
        public string publishedDate { get; set; }
        public string description { get; set; }
        public int pageCount { get; set; }
        public ImageLinks imageLinks { get; set; }
        public string language { get; set; }
    }

 
}