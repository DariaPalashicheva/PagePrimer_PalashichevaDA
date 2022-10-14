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
    /// Логика взаимодействия для Zadanie6.xaml
    /// </summary>
    public partial class Zadanie6 : Window
    {
        public Zadanie6()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            main.Navigate(new Uri("Main.xaml", UriKind.Relative));
        }
    }
}
