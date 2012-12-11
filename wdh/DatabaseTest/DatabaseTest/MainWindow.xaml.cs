using System;
using DatabaseTest.ViewModel;
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
using DatabaseTest;

namespace DatabaseTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            CalligrapherViewModel cvm =this.Resources["cvm"] as CalligrapherViewModel;
            cvm.AddCalligrapher();
            cvm.Save();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            CalligrapherViewModel cvm = this.Resources["cvm"] as CalligrapherViewModel;
            cvm.Save();
        }

        private void Delect_Click(object sender, RoutedEventArgs e)
        {
            string _name = shabi.SelectedItem.ToString();
            //string _name = shabi.ItemsSource.ToString();
            CalligrapherViewModel cvm = this.Resources["cvm"] as CalligrapherViewModel;
            cvm.Delect(_name);
            cvm.Save();
        }

    }
}
