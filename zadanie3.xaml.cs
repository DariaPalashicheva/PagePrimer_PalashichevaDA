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
using System.Windows.Shapes;

namespace PagePrimer_PalashichevaDA
{
    /// <summary>
    /// Логика взаимодействия для zadanie3.xaml
    /// </summary>
    public partial class zadanie3 : Window
    {
        public zadanie3()
        {
            InitializeComponent();
        }

        private void St1_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Uri("Step1.xaml", UriKind.Relative));
        }
        private void St2_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Uri("Step2.xaml", UriKind.Relative));
        }
        private void St3_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Uri("Step3.xaml", UriKind.Relative));
        }
    }
}
