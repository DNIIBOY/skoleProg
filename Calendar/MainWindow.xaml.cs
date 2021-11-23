using System;
using System.Windows;
using System.IO;

namespace Dato
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DateTime date = DateTime.Today;
        public Aftaler aftaler = new Aftaler();
        public MainWindow(){
            InitializeComponent();
            MyDate.Content = date.ToShortDateString();
        }

        private void Button_Click_next(object sender, RoutedEventArgs e)
        {
            liste_af_aftaler.Text = "Ingen aftaler";
            date = date.AddDays(1);
            MyDate.Content = date.ToShortDateString();
            liste_af_aftaler.Text = aftaler.Load(date);
            dagbogField.Text = aftaler.LoadDagbog(date);
        }

        private void Button_Click_prev(object sender, RoutedEventArgs e)
        {
            liste_af_aftaler.Text = "Ingen aftaler";
            date = date.AddDays(-1);
            MyDate.Content = date.ToShortDateString();
            liste_af_aftaler.Text = aftaler.Load(date);
            dagbogField.Text = aftaler.LoadDagbog(date);
        }

        private void Button_Click_save(object sender, RoutedEventArgs e)
        {
            aftaler.Save(date, tidField.Text, aftaleField.Text, dagbogField.Text);
        }

        private void Button_Click_load(object sender, RoutedEventArgs e)
        {
            aftaler.Load(date);
        }
    }
}
