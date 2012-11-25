using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentcoursemanage
{
    class Student
    {
        string stuName;  //姓名
        string stuID;  //学号
        static int numberOfCourse;  //
        static Course[] list;  //设置课程学分以及课程名
        int[] stuScore;  //学生课程成绩
        double stuGpa;  //绩点
        public Student()  //创建list对象数组并初始化
        {
            list = new Course[numberOfCourse];
            for (int i = 0; i < numberOfCourse; i++)
                list[i] = new Course();
            stuScore = new int[numberOfCourse ];

        }
        public static int CourseNum
        {
            get
            { return numberOfCourse; }
            set
            { numberOfCourse = value; }
        }
        public double Gpa //绩点不能由学生自己输入
        {
            get
            { return stuGpa; }
        }
        public string Name
        {
            get
            { return stuName; }
            set 
            {stuName = value ; }
        }
        public static void SetCourse(params Course[] topic)
        {//用params修饰参数，数组长度可变较为方便
            for (int i = 0; i < topic.Length; i++)
            {
                list[i].Name = topic[i].Name;
                list[i].Mark = topic[i].Mark;
            }
        }
        public void AddData(string name, string Id, int[] score)
        {
            stuName = name;
            stuID = Id;
            for (int i = 0; i < score.Length; i++)
                stuScore[i] = score[i];
        }
        public void ComputeGpa() //计算学生绩点
        {
            int i;
            double sMark, sumMark = 0, sumGp = 0;
            for (i = 0; i < stuScore.Length; i++)
            {
                if (stuScore[i] >= 60)
                {
                    sMark = (stuScore[i] / 10)-5;
                }
                else sMark = 0;
                sumGp += list[i].Mark * sMark;
                sumMark += list[i].Mark;
            }
            stuGpa = sumGp / sumMark;
        }
        public void stuSwap(ref Student stu1, ref Student stu2)
        {
            string name, Id;
            int i;
            int[] score = new int[Student.CourseNum];
            double gpa;
            name = stu1.Name;
            Id = stu1.stuID;
            gpa = stu1.Gpa;
            for (i = 0; i < Student.CourseNum; i++)
                score[i] = stu1.stuScore[i];
            stu1.stuName = stu2.stuName;
            stu1.stuID = stu2.stuID;
            stu1.stuGpa = stu2.stuGpa;
            for (i = 0; i < Student.CourseNum; i++)
                stu1.stuScore[i] = stu2.stuScore[i];
            stu2.stuName = name;
            stu2.stuID = Id;
            stu2.stuGpa = gpa;
            for (i = 0; i < Student.CourseNum; i++)
                stu2.stuScore[i] = score[i];
        }
    }
}
