using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Cname : IComparer<Student>
    {
         public static Cname Default = new Cname();
         public int Compare(Student s1, Student s2)
        {
            return System.Collections.Comparer.Default.Compare(s1.Name, s2.Name);
          }
       }
 }
