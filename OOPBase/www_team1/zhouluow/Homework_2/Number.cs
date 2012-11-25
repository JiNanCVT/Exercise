using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; 

namespace Homework_2
{
    class Number
    {
        public bool b(string s)
        {
            string pattern = "^[0-9]+(.)*$";

            Regex rx = new Regex(pattern);
            return rx.IsMatch(s);
        }
    }
}
