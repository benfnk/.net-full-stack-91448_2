using System;

namespace Enum_Example
{

    /*
     * by default enum is int
     * ------------------------
     * we can set it to the following types:
     * Type byte, sbyte, short, ushort, int, uint, long, or ulong 
     */

    [Flags]
    enum PrintStyle:byte
    {
        //סימון לעבודה ברמת ביטים
        //הערכים יהיו רק חזקות של שתיים
        //בשביל לאפשר לבחור כמה ערכים לתוך משתנה אחד
        Space=0x0001,
        Tab= 0x0002,
        Enter= 00004

        //Constant value '300' cannot be converted to a 'byte'	Enum Example   
        //BackTick = 300
    }
}


