using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Cgrade : IComparer<Student>
    {
       public static Cgrade Default = new Cgrade();
         public int Compare(Student s1, Student s2)
        {
            return System.Collections.Comparer.Default.Compare(s1.Grade, s2.Grade);
         }
    }

}
