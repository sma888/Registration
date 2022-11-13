using RegistrWpfApp.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RegistrWpfApp.ViewModel
{
    class MainWindowViewModel : BaseViewModel
    {
        private string _password;
        private string _login;
        private readonly VerificateUser verificate;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand NextButton
        {
            get;
        }

        public MainWindowViewModel()
        {
            verificate = new VerificateUser();
            NextButton = new DelegateCommand(Check);
        }

        public async void Check(object obj)
        {
            bool result = await verificate.Check(Login, Password);
            if (result == true)
            {
                NextWindow next = new NextWindow();
                next.Show();

                foreach (Window w in App.Current.Windows)
                {
                    if (w.Title == "Регистрация")
                        w.Close();
                }
            }
        }
    }
}
