using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_web_api.Models
{

    
    public static class StudentStorage
    {
        public static List<Student> StudentList { get; set; }


        public static bool AddStudentToList(Student s)
        {
            try
            {
                if(s.Grade>=0 && s.Grade <= 100)
                {
                    StudentList.Add(s);
                    return true;
                }
                throw new ArgumentOutOfRangeException();
               
            }
            catch
            {
                return false;
            }
          
        }

            static StudentStorage()
        {
            Random rand = new Random();
            StudentList = new List<Student>();

            string[] namesArray = new string[] {"Emma","Liam","Olivia","Noah",
                                            "Ava","Oliver","Isabella","Logan","Sophia","Mason","Mia","Elijah",
                                            "Amelia","Lucas","Harper","Ethan","Charlotte","Aiden","Mila","James",
                                            "Aria","Carter","Ella","Alexander","Avery","Jacob",
                                            "Layla","Sebastian","Zoey","Michael","Bella","Wyatt" };

            foreach (var item in namesArray)
            {
                StudentList.Add(new Student() { Name = item,
                                                Age = rand.Next(18, 135),
                                                Grade = rand.Next(0, 100) });
            }

        }
      
    }
}