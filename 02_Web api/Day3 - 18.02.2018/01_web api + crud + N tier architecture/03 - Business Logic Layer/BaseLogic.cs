using System;

namespace JohnBryce
{
    public abstract class BaseLogic : IDisposable
    {
        //יצירת משתנה מקומי שניתן לגישה ממחלקות יורשות
        //מחלקת בסיס אבסרקטית שמכילה את האובייקט של הגישה לבסיס הנתונים
        //BLLמכיוון שזהו אובייקט משותף לכל המחלקות ב
        protected NorthwindEntities DB = new NorthwindEntities();


        //because we are not using the ef inside a "USING" BLOCK
        //WE HAVE TO DISPOSE THE EF OBJECT WITH THE Dispose FUNCTION
        //Dispose הפונקציה של 
        //Dispose תקרא באופן אוטומטי כאשר נבצע פעולת 
        //על אובייקט ממחלקה נגזרת של המחלקה הזו
        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
