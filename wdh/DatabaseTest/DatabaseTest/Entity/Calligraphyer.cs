using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
   public  class Calligraphyer:EntityBase //存放画家的字段
    {
        private int _id;//画家ID，为系统随机生成的整数

        public int Id   //定义ID的两个属性
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;//画家名字

        public string Name
        {
            get { return _name; }
            set 
            {
                if (value != _name)
                {
                    _name = value;
                    SetPropertyChanged("Name");
                }
            }
        }

        private string _description;//画家描述

        public string Description
        {
            get { return _description; }
            set 
            {
                if (value != null)
                {
                    _description = value;
                    SetPropertyChanged("Description");
                    
                }
            }
        }

        public Calligraphyer()//构造函数1：初始化ID和状态
        {
           
            Status = Statuses.New;
        }

        public Calligraphyer(int id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
            Status = Statuses.Updated;
        }
    }
}
