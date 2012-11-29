using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentcoursemanage
{
    class Course
    {
        string courseName; //课程名称
        int courseMark; //课程分数
        public Course()
        {  }
        public Course(string  Name,int Mark)
        {
            courseName = Name;
            courseMark = Mark;
        }
        public string Name
        {
            get
            { return courseName; }
            set  
            { courseName = value;  }
        }
        public int Mark
        {
            get
            { return courseMark; }
            set
            { courseMark = value; }
        }

    }
}
