using System;

namespace Struct_Example
{

    /*
      in struct we can use the following access modifiers:
              internal
              public
              private
      in class we can use the following access modifiers:
              internal
              public
              private
              protected
              internal protected
     */

    /*
       static - in struct is the same as static in class

     */
     /*
      * struct בתוך
      * אי אפשר לתת ערך בשורת ההגדרה של המשתנה
      * רק עבור משתנה סטטי נוכל לתת ערך בשורת ההגדרה
     */
    struct Time
    {

        public static string message = "I am static in struct ";
        public static int messageCounter = 0;
        private int hour;
        private int minute;
        public int second;

        // public Time() { } // לא ניתן לדרוס את הבנאי הריק


        //אפשר רק ליצור בנאי שמקבל פרמטרים
        public Time(int h, int m, int s)
        {
            //חובה לייצר בבנאי שלא משתמש בבנאי הדיפולטיבי
            //השמה של ערכים לכל המשתנים
            //כיוון שלא מתרחשת השמה של ערכי ברירת מחדל - שהבנאי הדיפולטיבי אחראי עליה
            hour=minute=second = 0;

            //setter + getterאי אפשר להשתמש ב
            //לפני שכל הערכים של כל המשתנים אותחלו
            Hour = h;
            Minute = m;
            Second = s;

            Time.messageCounter++;
        }

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if(value >= 0 && value <= 23)
                    hour = value;
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value >= 0 && value <= 59)
                    minute = value;
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value >= 0 && value <= 59)
                    second = value;
            }
        }

        //objectאפשר לדרוס רק פונקציות שירשנו מ
        //structכיוון שב
        //structאי אפשר לרשת מ 
        public override string ToString()
        {
            return ($"{Hour}:{Minute}:{Second}");
        }

        public void Display()
        {
            /*line 1*/Console.WriteLine(this);

            //the following options are the same as line 1:
            //-----------------------------------
            //Console.WriteLine(this.ToString());
            //Console.WriteLine(ToString());
        }
    }
}
