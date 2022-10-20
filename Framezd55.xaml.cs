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
    /// Логика взаимодействия для Framezd55.xaml
    /// </summary>
    public partial class Framezd55 : Page
    {
        public Framezd55()
        {
            InitializeComponent();
            List<Stroka> strokas = new List<Stroka>();
            strokas.Add(new Stroka() { ID = 1, Det = new DateTime(2016, 6, 24), UserID = "Admin", IssueSubject = "Initial Logged Job", Screen = "Initial Logged Job", FurtherInformation = "Initial Logged Job", JobStatus = "Closed" });

            dg.ItemsSource = strokas;
        }

        public class Stroka
        {
            public int ID { get; set; }

            public string UserID { get; set; }

            public string IssueSubject { get; set; }

            public string Screen { get; set; }

            public string FurtherInformation { get; set; }

            public string JobStatus { get; set; }

            public DateTime Det { get; set; }

        }

    }
}
