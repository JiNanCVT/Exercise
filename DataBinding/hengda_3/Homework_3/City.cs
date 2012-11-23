using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class City
    {
        public  int i;

        public int I
        {
            get { return i; }
            set { i = value; }
        }
        public  string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public City()
        {
            this.name = name;
            this.i = i;
        }
    }
}
