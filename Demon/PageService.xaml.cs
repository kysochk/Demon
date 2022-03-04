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

namespace Demon
{
    /// <summary>
    /// Логика взаимодействия для PageService.xaml
    /// </summary>
    public partial class PageService : Page
    {
        LoadList LoadS;
        List<Service> ls;
        public PageService()
        {
            InitializeComponent();
            ServiceList.ItemsSource = LoadS.service;
            ls = LoadS.service;
            DiscountCB.SelectedIndex = 0;
           
        }

        private void EditService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewZapis_Click(object sender, RoutedEventArgs e)
        {

        }

        private void autorizBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextZap_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CostSortBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBarTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DiscountCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
