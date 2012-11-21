using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业1
{
    class Student
    {
        string _name;
        public string Name
        {
            get{return _name;}
            set{ _name = value; }
        }
        int _grade;
        public int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        public Student(int grade,string name)
        {
            Grade=grade ;
            Name=name;
            
        }
        public static int SortStudent1(Student a1, Student a2)
        {
            if (a1.Grade.CompareTo(a2.Grade) != 0)
                return a1.Grade.CompareTo(a2.Grade);
            else
                return a1.Name.CompareTo(a2.Name);
        }
        public static int SortStudent2(Student a1, Student a2)
        {
            if (a1.Name.CompareTo(a2.Name) != 0)
                return a1.Name.CompareTo(a2.Name);
            else
                return a1.Grade.CompareTo(a2.Grade);
        }
    }
}
