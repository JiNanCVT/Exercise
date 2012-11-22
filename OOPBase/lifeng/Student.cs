using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Student
    {
       public string _name;
       public int  _score;

        public string  Name
        {
            get { return _name; }
            set{_name=value;}
        }
        public Student(String name,int score)
        {
            _name = name;
           _score = score;
        }
    }
}
