using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Data;
using CalligraphySample.DataHelper;
using CalligraphySample.Entities;
using System.Data.SqlClient;

namespace CalligraphySample.ViewModel
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
            ObservableCollection<Calligraphyer> calligraphyers = CalligrapherDataHelper.Load();
            _viewSource.Source = calligraphyers;
            
        }

     

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
        public void Delete()
        {
            
            //var cnn = DataHelper.CreateConnection();
            //string sql = @"DELETE FROM T_Calligrapher1 WHERE Id = @ID";
            //SqlCommand cmmd = new SqlCommand(sql, cnn);
            //cmmd.Parameters.Add(new SqlParameter("ID", c.Id));
            //cnn.Open();
            //cmmd.ExecuteNonQuery();
            //cnn.Close();

 
        }
    }
}
