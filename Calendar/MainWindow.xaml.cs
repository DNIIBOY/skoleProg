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

namespace Dato
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DateTime date = new DateTime(2021, 11, 22);
        public Aftaler aftaler = new Aftaler();
        public MainWindow()
        {
            InitializeComponent();
            MyDate.Content = date.ToShortDateString();
        }

        private void Button_Click_next(object sender, RoutedEventArgs e)
        {
            liste_af_aftaler.Text = "Ingen aftaler";
            date = date.AddDays(1);
            MyDate.Content = date.ToShortDateString();
            liste_af_aftaler.Text = aftaler.Load(date);
        }

        private void Button_Click_prev(object sender, RoutedEventArgs e)
        {
            liste_af_aftaler.Text = "Ingen aftaler";
            date = date.AddDays(-1);
            MyDate.Content = date.ToShortDateString();
            liste_af_aftaler.Text = aftaler.Load(date);
        }

        private void Button_Click_save(object sender, RoutedEventArgs e)
        {
            aftaler.Save(date);
        }

        private void Button_Click_load(object sender, RoutedEventArgs e)
        {
            aftaler.Load(date);
        }
    }
}
