using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Student
    {
        public String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public double score;

        public double Score
        {
            get { return score; }
            set { score = value; }
        }
        public Student()
        {
            this.name = name;
            this.score = score;
        }

    }
}
