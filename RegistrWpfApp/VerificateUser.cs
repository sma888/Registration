using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RegistrWpfApp
{
    public class VerificateUser
    {

        //public string Login { get; set; }
        //public string Password { get; set; }

        //public VerificateUser(string login, string password)
        //{
        //    Login = login;
        //    Password = password;
        //}

        public bool Check(string login, string password, string passwordBoxText)
        {
            if (login != "" || password != ""|| passwordBoxText != "")
            {
                if (login == "Мага" && password == "123"|| passwordBoxText == "123")
                {
                    MessageBox.Show("Вход выполнен успешно", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Stop);
                    return false;
                }
            }
            else MessageBox.Show("Не все поля заполнены!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Stop);
            return false;
        }
    }
}
