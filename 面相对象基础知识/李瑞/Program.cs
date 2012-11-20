using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1H
{
    class Program
    {
         
        static void Main(string[] args)
        {
            List<Student> _Slist = new List<Student>();

            #region
            Student s0 = new Student();
            s0.Name = "张三";
           // s0.Name = "bbb";
            s0.Score = 85;
            _Slist.Add(s0);

            Student s1 = new Student();
            s1.Name = "李四";
          //  s1.Name = "aaa";
            s1.Score = 71;
            _Slist.Add(s1);

            Student s2 = new Student();
            s2.Name = "王五";
          //  s2.Name = "eee";
            s2.Score = 86;
            _Slist.Add(s2);

            Student s3 = new Student();
            s3.Name = "老子";
            s3.Score = 94;
            _Slist.Add(s3);

            Student s4 = new Student();
            s4.Name = "墨子";
           // s4.Name = "ccc";
            s4.Score = 60;
            _Slist.Add(s4);


            #endregion
            //input five stuedents

            foreach (Student a in _Slist)
            {
                Console.WriteLine(a.Name + ":" + a.Score);
            }
            //输出数据

            Console.WriteLine();
            Console.WriteLine("Choose:1.Ascending order in Scores");
            Console.WriteLine("       2.Ascending order in Name");
            Console.WriteLine("       3.Exit");
            Console.WriteLine("L->12    M->13    W->23    Z->26");
            Console.WriteLine();

            bool temp = false;
            int _in;
            
            //可重复输入，输入3退出
            while(true){

                _in = 0;
                
                do
                {
                    //输入并处理错误
                    try
                    {
                        _in = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Wrong input,please input again."); continue;
                    }
                
                    if (_in == 1 || _in == 2 || _in == 3)
                        temp = true;
                    else Console.WriteLine("Wrong input,please input again.");

                } while (!temp == true);

                //选择1.2.3
                switch (_in)
                {
                    case (1):
                        {
                            _Slist.Sort();
                            foreach (Student a in _Slist)
                            {
                                Console.WriteLine(a.Name + ":" + a.Score);
                            }
                            Console.Write("\n");
                        } break;

                    case (2):
                        {
                            //排序名字

                          var list1 = _Slist.OrderBy(f => f.Name);

                            foreach (Student a in list1)
                            {
                                Console.WriteLine(a.Name + ":" + a.Score);
                            }
                            Console.Write("\n");
                        } break;

                    case (3):
                        {
                            //empty......exit
                        } break;

                }

                if (_in == 3) break;

            }


        }
    }
}
