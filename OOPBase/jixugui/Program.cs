using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentcoursemanage
{
    class Test
    {
        static void Main(string[] args)
        {
            Test T = new Test();
            int i, j, Num, Mark;
            string sline, Name, Id;
            double sMax, sMin;
            Console.Write("请输入班级学生的总人数");
            sline = Console.ReadLine();
            Num = int.Parse(sline);
            Console.WriteLine("请输入选修课总数");
            sline = Console.ReadLine();
            Student.CourseNum = int.Parse(sline);
            Student[] Stu = new Student[Num];
            for (i = 0; i < Num; i++)
             Stu[i] = new Student ();
            Course[] tp = new Course[Student.CourseNum];
            int[] score = new int[Student.CourseNum];
                for (i = 0; i < Student.CourseNum; i++)
                {
                    Console.Write("请输入选修课程的名称：");
                    Name = Console.ReadLine();
                    Console.Write("请输入选修课程学分：");
                    sline = Console.ReadLine();
                    Mark = int.Parse(sline);
                    tp[i] = new Course(Name, Mark);//初始化Course数组
                }
            Student.SetCourse(tp);
            for (i = 0; i < Num; i++)
            {
                Console.Write("请输入学生姓名：");
                Name = Console.ReadLine();
                Console.Write("请输入学生学号：");
                Id = Console.ReadLine();
                for (j = 0; j < Student.CourseNum; j++)
                {
                    Console.Write("请输入{0}课程的成绩", tp[j].Name);
                    sline = Console.ReadLine();
                    score[j] = int.Parse(sline);
                }
                Stu[i].AddData(Name, Id, score);//将学生数据输入到数组中
                Stu[i].ComputeGpa();//计算该学生的绩点
                //List<Student> std = new List<Student>();计划再用List列表实现一次功能
                

                Console.WriteLine("{0}同学的绩点是：{1:F2}", Stu[i].Name, Stu[i].Gpa); 
            }
            T.MaxMinGpa(out sMax, out sMin, Stu);  //计算绩点的最大最小值
            Console.WriteLine("绩点最高为{0:F2}：最低为{1:F2}", sMax, sMin);
            Console.WriteLine("按绩点从低到高排序为：");
            T.SortGpa(ref Stu);
            for (i = 0; i < Num; i++)
            {
                Console.WriteLine("{0}，{1:F2}", Stu[i].Name, Stu[i].Gpa);
            }
            Console.Read();
        }
        public void MaxMinGpa(out double max, out double min, Student[] stu)
        {
            if (stu.Length == 0)
            {
                max = min = -1;
                return;
            }
            max = min = stu[0].Gpa;
            for (int i = 0; i < stu.Length; i++)
            {
                if (max < stu[i].Gpa) max = stu[i].Gpa;
                if (min > stu[i].Gpa) min = stu[i].Gpa;
            }
        }
        public void SortGpa(ref Student[] stu)
        {
            int i, j, pos;
            for (i = 0; i < stu.Length - 1; i++)
            {
                for (j = (pos = i) + 1; j < stu.Length; j++)
                    if (stu[pos].Gpa < stu[j].Gpa)
                        pos = j;
                if (pos != i)
                    stu[i].stuSwap(ref stu[i], ref stu[pos]);
            }

        }
    }
}
