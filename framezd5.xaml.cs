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
    /// Логика взаимодействия для framezd5.xaml
    /// </summary>
    public partial class framezd5 : Page
    {
        public framezd5()
        {
            InitializeComponent();
            List<Stroka> strokas = new List<Stroka>();
            strokas.Add(new Stroka() { Id = 1, Place = "Вход офис", Point = "У двери", Ser = 55454403, IP = "192.168.201.89", MAC = "00:60:J5:35:22:02:CE", Podkl="Подключен", Det= new DateTime(2016, 6, 24) });

            dg.ItemsSource = strokas;
        }
        public class Stroka
        {
            public int Id { get; set; }

            public string Place { get; set; }

            public string Point { get; set; }
            public Int32 Ser { get; set; }
            public string IP { get; set; }
            public string MAC { get; set; }
            public string Podkl { get; set; }
            public DateTime Det { get; set; }

        }


    }
}
