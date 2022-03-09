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
    /// Логика взаимодействия для Avtorizacia.xaml
    /// </summary>
    public partial class Avtorizacia : Page
    {
        
        public Avtorizacia()
        {
            InitializeComponent();

        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            if (Nametxt.Text == "0000")
            {
                MessageBox.Show("Вы вошли как администраторатор.", "Авторизация прошла успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                PageLoad.MainFrame.Navigate(new PageService(1));
            }
            else
            {
                MessageBox.Show("Пароль неверный\nПопробуйте снова", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void VhodGost_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы вошли как гость.", "Зачем оно вам надо...", MessageBoxButton.OK, MessageBoxImage.Information);
            PageLoad.MainFrame.Navigate(new PageService());
        }
    }
}
