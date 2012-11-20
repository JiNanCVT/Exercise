using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1117作业
{
    public class Users
    {
        public delegate void usersInputHandler(List<Student> exa);   //声明委托
        public event usersInputHandler userReflect;  //定义事件
        public void userOnReflect(List<Student> exa)  //触发事件
        {
            if (userReflect != null)
            {
                userReflect(exa);
            }
        }
        
        public void inputOne(List<Student> exa)  //委托的方法一
        {            
            exa.Sort(new stuCompa_name());//对学生姓名排序            
        }

        public void inputTwo(List<Student> exa)
        {
            exa.Sort(new stuCompa_score());//对学生分数排序
        }
    }
}
