using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s0 = new Student(); 
           

            s0.name = "Rose";
            s0.score = 80;
            Student s1 = new Student(); 
            s1.name = "Tom";
            s1.score = 70;
            Student s2 = new Student();
            s2.name = "Ann";
            s2.score = 90;
        
            List<Student> list = new List<Student>();
            list.Add(s0);
            list.Add(s1);
            list.Add(s2);
            var list1 = list.OrderBy(f => f.name);
            var list2 = list.OrderBy(f => f.score);

            Console.WriteLine("请选择排序类型：1，按名字升序排列；2，按成绩升序排列");

            //Console.Read();
       
            
            int choseInt = int.Parse(Console.ReadLine());
            Output output = new Output(choseInt, list1, list2);//Output类实例化，当choseInt为1时输出list1，当choseInt为2时输出list2
           
           
            
            


        }
        
    }
}
