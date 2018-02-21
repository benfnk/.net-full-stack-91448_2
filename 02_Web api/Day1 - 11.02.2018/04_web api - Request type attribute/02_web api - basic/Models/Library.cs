using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_web_api___basic.Models
{
    public static class Library
    {
        public static Book[] books;
        static Library()
        {
            books = new Book[]{
                new Book { volumeInfo=new VolumeInfo { title= "A History of the Israeli-Palestinian Conflict",
                authors=new List<string>{"Mark A. Tessler"},
                publisher="Indiana University Press",
                publishedDate="1994-01-01",
                description="Discusses the early history of Jews and Arabs and traces the emergence and history of the Israeli-Palestinian conflict from the early twentieth century to the beginning of peace negotiations in the early 1990s",
                pageCount=906,
                language="en",
                imageLinks=new ImageLinks {smallThumbnail= "http://books.google.com/books/content?id=3kbU4BIAcrQC&printsec=frontcover&img=1&zoom=5&edge=curl&source=gbs_api",
                thumbnail="http://books.google.com/books/content?id=3kbU4BIAcrQC&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api"}

                }
                },

                new Book { volumeInfo=new VolumeInfo { title= "Distance Education: A Systems View of Online Learning",
                authors=new List<string>{  "Michael G. Moore","Greg Kearsley"},
                publisher="Cengage Learning",
                publishedDate="2011-04-22",
                description="The most comprehensive and authoritative text on the subject, DISTANCE EDUCATION, Third Edition, retains its emphasis on a systems approach to the organization and selection of material. The text is researched-based and grounded in solid principles of teaching and learning. The authors apply their broad experience and expertise as they explain how to design and teach courses online--including the latest technologies employed, characteristics of learners, organizational structures, and current policy and global perspectives. Important Notice: Media content referenced within the product description or the product text may not be available in the ebook version.",
                pageCount =384,
                language="en",
                imageLinks=new ImageLinks {smallThumbnail= "http://books.google.com/books/content?id=wXtsKAMiuAAC&printsec=frontcover&img=1&zoom=5&edge=curl&source=gbs_api",
                thumbnail="http://books.google.com/books/content?id=wXtsKAMiuAAC&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api"}

                }
                }

        };
        }
    }
}
