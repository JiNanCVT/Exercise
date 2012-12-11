using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Data;
using CalligraphySample.DataHelper;
using CalligraphySample.Entities;

namespace CalligraphySample.ViewModel
{
    /**********************************************************
    * 修 改 人:da
    * 日    期:12.10
    * 修改描述:在函数 public void AddCalligrapher()中增加
    *          calligraphyer.Id = Guid.NewGuid();设置ID值并将
    *          calligraphyer的static值设为“ New”
    ***********************************************************/
    public class CalligrapherViewModel
    {
        private CollectionViewSource _viewSource;

        public CollectionViewSource ViewSource
        {
            get { return _viewSource; }
            set { _viewSource = value; }
        }

        //private static bool NotDelected(EntityBase entityBase)
        //{
        //    return entityBase.Status != EntityBase.Statuses.Delete;
        //}

        public CalligrapherViewModel()
        {
            _viewSource = new CollectionViewSource();
            ObservableCollection<Calligraphyer> calligraphyers = CalligrapherDataHelper.Load();
            _viewSource.Source = calligraphyers;
            //_viewSource.View.CurrentChanged += View_CurrentChanged;
            
            //_viewSource.View.Filter = new Predicate<object>((o) => { return ((EntityBase)o).Status != EntityBase.Statuses.Delete; });
            //_viewSource.View.CollectionChanged += View_CollectionChanged;
        }

        //void View_CurrentChanged(object sender, EventArgs e)
        //{
        //    if (_viewSource.View.CurrentItem != null)
        //    {
        //        System.Diagnostics.Debug.WriteLine(_viewSource.View.CurrentItem);
        //    }
        //    else
        //    {
        //        System.Diagnostics.Debug.WriteLine("current item null");
        //    }
        //}

        //void View_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
        //    {
        //        CalligrapherDataHelper.Insert((Calligraphyer)e.NewItems[0]);
        //    }
        //}

        public void AddCalligrapher()
        {
            Calligraphyer calligraphyer = new Calligraphyer();
            calligraphyer.Name = "书法家";
            calligraphyer.Description = "简介";
            calligraphyer.Id = Guid.NewGuid();
            ((ObservableCollection<Calligraphyer>)_viewSource.Source).Add(calligraphyer);
        }

        public void Save()
        {
            CalligrapherDataHelper.Save((ObservableCollection<Calligraphyer>)_viewSource.Source);
        }

        public void Delete(Calligraphyer c)
        {
            ((ObservableCollection<Calligraphyer>)_viewSource.Source).Remove(c);
            c.Status = EntityBase.Statuses.Delete;
            CalligrapherDataHelper.Save(c);
        }
    }
}
