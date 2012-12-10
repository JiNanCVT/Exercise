using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
   public class EntityBase:INotifyPropertyChanged  //继承一个接口，通知改变！
    {
       
       public enum Statuses //定义数据的状态
       {
           Updated,         //数据从数据库导入
           New,             //新数据
           Edit,            //编辑过的数据
           Delect           //删除呢数据
       }

       private Statuses _status;//定义状态，为枚举类型

       public Statuses Status
       {
           get { return _status; }
           set { _status = value; }
       }

       public event PropertyChangedEventHandler PropertyChanged; //定义事件委托

       public void SetPropertyChanged(string propertyName)//判断是否发生改变
       {
           if (PropertyChanged != null)
           {
               PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
           }
       }

       void EntityBase_PropertyChanged(object sender, PropertyChangedEventArgs e)//触发事件时，将状态设置为Edit！
       {
           _status = Statuses.Edit;
       }

       public EntityBase() //构造函数：响应事件
       {
           PropertyChanged += EntityBase_PropertyChanged;
       }


    }
}
