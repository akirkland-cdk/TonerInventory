using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TonerInventory.BAL
{
    public class Misc
    {
        public static short ConvertStringToShort(string MyString)
        {       
            short MyShort = 0;
            short.TryParse(MyString,out MyShort);
            return MyShort;
        }
    }
}