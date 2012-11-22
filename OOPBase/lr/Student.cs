using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1H
{
    class Student:IComparable<Student>
    {
        private string _name;
        private int _score;

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //默认排序成绩(整数)
        public int CompareTo(Student p)
        {
            return this.Score - p.Score;
        }

        

        
    }
}
       
