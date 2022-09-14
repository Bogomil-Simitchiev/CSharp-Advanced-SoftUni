using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class DateModifier
    {
        public static int GetDaysBetweenTwoDates(string first,string second)
        {
            DateTime firstdate = DateTime.Parse(first);
            DateTime seconddate = DateTime.Parse(second);
            int days = Math.Abs((firstdate- seconddate).Days);
            return days;


        }
    }
}
