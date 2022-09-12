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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            string login, password, passwordBoxText;

            login = loginTextBox.Text;
            password = passwordTextBox.Text;
            passwordBoxText = passwordBox.Password.ToString();

            VerificateUser verificateUser = new VerificateUser();
            bool result = verificateUser.Check(login, password, passwordBoxText);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            passwordTextBox.Visibility = Visibility.Visible;
            passwordTextBox.Text = passwordBox.Password.ToString();
            passwordBox.Visibility = Visibility.Hidden;
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Visibility = Visibility.Visible;
            passwordBox.Password = passwordTextBox.Text;
            passwordTextBox.Visibility = Visibility.Hidden;
        }
    }
}
