using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _02_web_api___basic.Controllers
{
    public class CalcController : ApiController
    {


        public int Get(int num1, int num2)
        {
            return Get(num1, num2, string.Empty);
        }


        public int Get(int num1,int num2,string action)
        {
            switch (action.ToLower())
            {
                case "add": return num1 + num2;
                case "sub": return num1 - num2;
                case "mul": return num1 * num2;
                case "div": return num1 / num2;
                default: return 0;
            }
            
        }
    }
}
