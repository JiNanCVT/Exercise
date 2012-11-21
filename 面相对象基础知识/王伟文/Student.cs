using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Student
    {
        string name;
        int grade;

        public Student(string Name, int Grade)
        {
            this.name = Name;
            this.grade = Grade;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
           public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

    }
}

