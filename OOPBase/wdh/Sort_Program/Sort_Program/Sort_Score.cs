using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Program
{
    class Sort_Score
    {
        public static int SortStudent(Student s1, Student s2)
        {
            if (s1.score.CompareTo(s2.score) != 0)
                return s1.score.CompareTo(s2.score);
            else
                return s1.name.CompareTo(s2.name);
        }
    }
}
