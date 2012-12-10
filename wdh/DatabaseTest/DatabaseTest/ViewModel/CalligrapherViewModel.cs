using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Data;
using DatabaseTest.Database;
using DatabaseTest.Entity;

namespace DatabaseTest.ViewModel
{
    public class CalligrapherViewModel
    {
        private CollectionViewSource _viewSource;

        public CollectionViewSource ViewSource
        {
            get { return _viewSource; }
            set { _viewSource = value; }
        }

        public CalligrapherViewModel()
        {
            _viewSource = new CollectionViewSource();
            ObservableCollection<Calligraphyer> calligraphyers = DatabaseOperation.Load();
            _viewSource.Source = calligraphyers;
        }

        public void AddCalligrapher()
        {
            Calligraphyer calligraphyer = new Calligraphyer();
            calligraphyer.Name = "努力学习";
            calligraphyer.Description = "天天向上";
            calligraphyer.Status = DatabaseTest.Entity.EntityBase.Statuses.New;
            ((ObservableCollection<Calligraphyer>)_viewSource.Source).Add(calligraphyer);
        }

        public void Save()
        {
            DatabaseOperation.Save((ObservableCollection<Calligraphyer>)_viewSource.Source);
        }

        public void Delect(string c)
        {
            DatabaseOperation.Delect(c);
        }

    }
}
