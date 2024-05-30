using System.Collections.ObjectModel;
using System;
using System.Windows;
using System.Windows.Input;
using WpfSchoolPaper.ViewModel;
using Inditas.Models;

namespace WpfSchoolPaper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Persones> Emberkék;
        public PeopleContext db;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new TaskViewModel();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public class PeopleContext
    {
    }
}