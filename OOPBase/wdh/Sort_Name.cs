using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Program
{
    class Sort_Name
    {
        public static int SortStudentt(Student s1, Student s2)
        {
            if (s1.name.CompareTo(s2.name) != 0)
                return s1.name.CompareTo(s2.name);
            else
                return s1.score.CompareTo(s2.score);
        }
    }
}
