using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalligraphySample.Entities
{
    /**********************************************************
    * 修 改 人:da
    * 日    期:12.10
    * 修改描述:1.删除构造函数 public Calligraphyer()中的
    *           _id = Guid.NewGuid();
    *          2.函数 public Guid Id（）中的 set中增加“
    *          this.Status = Statuses.New;”使得 Calligraphyer
    *          的属性值由“ Edit” 变为 “New”
    ***********************************************************/

    public class Calligraphyer:EntityBase
    {
        private Guid _id;
        
        public Guid Id
        {
            get { return _id; }
            set 
            {
                _id = value;
                this.Status = Statuses.New;                       
            }
        }
        private string _name;

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
        private string _description;

        public string Description
        {
            get { return _description; }
            set
            {
                if (value != null)
                {
                    _description = value;
                    SetPropertyChanged("Description");
                    
                    //if (value == "delete")
                    //{
                    //    DeletePropertyChanged("Description");
                    //}
                }
                
            }
        }

        public override string ToString()
        {
            return _name;
        }

        public Calligraphyer()
        {
            //_id = Guid.NewGuid();
            Status = Statuses.New;
        }

        public Calligraphyer(Guid id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
            Status = Statuses.Updated;
        }
    }
}
