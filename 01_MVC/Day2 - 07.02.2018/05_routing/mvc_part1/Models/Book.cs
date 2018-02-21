using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_part1.Models
{
    public class Book
    {


        public Book():this(3,"kkk")
        {
         
        }


        public Book(int price, string name)
        {
            Price = price;
            Name = name;
        }
        public int Price { get; set; }
        public string Name { get; set; }
    }
}