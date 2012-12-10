using CalligraphySample.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace CalligraphySample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            CalligrapherViewModel cvm = this.Resources["cvm"] as CalligrapherViewModel;
            cvm.AddCalligrapher();
            cvm.Save();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            CalligrapherViewModel cvm = this.Resources["cvm"] as CalligrapherViewModel;

            cvm.Save();

        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            
            
           
   
        }

      



        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void nima_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
    