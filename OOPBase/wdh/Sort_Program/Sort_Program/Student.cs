using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Program
{
    public class Student
    {
        public int score;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student(int _score, string _name)
        {
            score = _score;
            name = _name;
        }     
    }
}
