using System;

namespace JohnBryce
{
    public static class ExceptionHelper
    {
        public static string GetInnerMessage(Exception ex)
        {
            return ex.InnerException == null ? ex.Message : GetInnerMessage(ex.InnerException);
        }
    }
}