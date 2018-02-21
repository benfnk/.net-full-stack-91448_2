using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapObj
{
    //מחלקה מורחבת - יש בה את כל הפרטים
    //DAL-דומה למחלקה ב
    class Student
    {
        public int Age { get; set; }
        public int Grade { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }

    //מחלקה מצומצמת - יש בה רק את הפרטים הנחוצים ללקוח
    //BO-דומה למחלקה ב
    class StudentShortInfo
    {
        public int Age { get; set; }
        public int Grade { get; set; }
        public string FullName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {


            //--------------------------------------------מאובייקט מורחב לאובייקט מצומצם--------------------------------------------
            //מערך של אובייקטים מהמחלקה המורחבת
            Student[] s = new Student[]
            {
                new Student{ Age=11, Grade=100, BirthDate=new DateTime(), FirstName="Asher", LastName="Elimelech" },
                new Student{ Age=11, Grade=100, BirthDate=new DateTime(), FirstName="Matan", LastName="Poor" },
                new Student{ Age=11, Grade=100, BirthDate=new DateTime(), FirstName="Efrat", LastName="Velner" },

            };
            

            //מיפוי של מערך אובייקטים ממחלקה מורחבת, למערך אובייקטים של מחלקה מצומצמת
            StudentShortInfo[] sShort = s.Select(std =>
            {
                return new StudentShortInfo { Age = std.Age,
                                              Grade = std.Grade,
                                              FullName = $"{ std.FirstName }  { std.LastName }" };
            }).ToArray();


            //--------------------------------------------מאובייקט מצומצם לאובייקט מורחב--------------------------------------------

            //אובייקט מקור מצומצם
            StudentShortInfo stdShort = new StudentShortInfo
            {
                Age = 20,
                Grade = 100,
                FullName = "X Y"
            };


            //אובייקט יעד מורחב
            Student stdFromShort = new Student
            {
                Age = stdShort.Age,
                Grade = stdShort.Grade,
                FirstName = stdShort.FullName.Split(' ')[0],
                LastName = stdShort.FullName.Split(' ')[1],
            };
        }
    }
}
