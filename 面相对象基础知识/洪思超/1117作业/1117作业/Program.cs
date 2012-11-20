using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1117作业
{
    //实现接口中的Compare方法
    public class stuCompa_name : IComparer<Student>   //姓名比较器
    {
        public int Compare(Student x, Student y)    
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class stuCompa_score : IComparer<Student>  //分数比较器
    {
        public int Compare(Student x, Student y)
        {
            return y.Score.CompareTo(x.Score);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string c;   //选择操作的字符
            Users user_example = new Users();  //定义用户对象
            List<Student> _students = new List<Student>();//创建一个学生集合

            for(i=0;i<10;i++)
                _students.Add(new Student());  //增加链表元素，共计10个

            //初始化链表
            _students[0].Name = "张一";
            //_students[0].Name = "Harry";
            _students[0].Score = "88";

            _students[1].Name = "李二";
            //_students[1].Name = "Williams";
            _students[1].Score = "78";
             
            _students[2].Name = "王三";
            //_students[2].Name = "Booke";
            _students[2].Score = "90";
             
            _students[3].Name = "刘四";
            //_students[3].Name = "Kobliy";
            _students[3].Score = "88";
             
            _students[4].Name = "陈五";
            //_students[4].Name = "Amiliy";
            _students[4].Score = "88";
             
            _students[5].Name = "张六";
            //_students[5].Name = "Hiky";
            _students[5].Score = "88";
             
            _students[6].Name = "李七";
            //_students[6].Name = "Acord";
            _students[6].Score = "88";
             
            _students[7].Name = "黄八";
            //_students[7].Name = "Funky";
            _students[7].Score = "84";
             
            //_students[8].Name = "黄九";
            //_students[8].Name = "Stephen";
            _students[8].Name = "黄八";
            _students[8].Score = "88";
             
            _students[9].Name = "陆十";
            //_students[9].Name = "Ocor";
            _students[9].Score = "78";

            Console.WriteLine("原名单成绩：");
            foreach (Student stu in _students)       //输出排序前链表具体信息
                Console.WriteLine(stu.Name + "：" + stu.Score);

            Console.WriteLine("请输入1：按姓名排序，2：按分数排序，3：退出");
            //开始判断、排序
            c = Console.ReadLine();
            while(c!="3")
            {
                if (c == "1")
                {
                    Console.WriteLine("按姓名排序后名单：");
                    user_example.userReflect += user_example.inputTwo;//先按分数排好再按姓名排，从而同名可以按分数来排序
                    user_example.userReflect += user_example.inputOne;
                    user_example.userOnReflect(_students);
                }
                if (c == "2")
                {
                    Console.WriteLine("按分数排序后名单："); 
                    user_example.userReflect += user_example.inputOne;   //先按姓名排好再按分数排，从而同分可以按姓名来排序
                    user_example.userReflect += user_example.inputTwo;
                    user_example.userOnReflect(_students);
                }
                foreach (Student stu in _students)       //输出排序后链表具体信息
                    Console.WriteLine(stu.Name + "：" + stu.Score);
                //下一次选择
                Console.WriteLine("请输入1：按姓名排序，2：按分数排序，3：退出");
                c = Console.ReadLine();
            }
            Console.WriteLine("你已退出");
        }
    }
}
