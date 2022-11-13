using RegistrWpfApp.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace RegistrWpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel _mainViewModel;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _mainViewModel = new MainWindowViewModel();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
