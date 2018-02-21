using _02_web_api___basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _02_web_api___basic.Controllers
{
    public class BooksController : ApiController
    {


        public IEnumerable<Book> GetMin(int minNumOfPages)
        {
            return Library.books.Where(book => book.volumeInfo.pageCount >= minNumOfPages);
        }


        public IEnumerable<Book> GetMax(int maxNumOfPages)
        {
            return Library.books.Where(book=>book.volumeInfo.pageCount<=maxNumOfPages);
        }


       
    }
}
