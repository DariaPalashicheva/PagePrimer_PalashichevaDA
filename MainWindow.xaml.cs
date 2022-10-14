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

namespace PagePrimer_PalashichevaDA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zd2_Click(object sender, RoutedEventArgs e)
        {
            //zd.Navigate(new Uri("zadanie2.xaml", UriKind.Relative)); просто оставила на будущее как пример
            zadanie2 zadanie2 = new zadanie2();
            zadanie2.Show();
        }
        private void Zd3_Click(object sender, RoutedEventArgs e)
        {
            //zd.Navigate(new Uri("zadanie2.xaml", UriKind.Relative)); просто оставила на будущее как пример
            zadanie3 zadanie3 = new zadanie3();
            zadanie3.Show();
        }

        private void Zd4_Click(object sender, RoutedEventArgs e)
        {
            //zd.Navigate(new Uri("zadanie2.xaml", UriKind.Relative)); просто оставила на будущее как пример
            zadanie4 zadanie4 = new zadanie4();
            zadanie4.Show();
        }
    }
}
