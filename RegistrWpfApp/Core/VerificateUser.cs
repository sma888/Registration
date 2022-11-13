﻿using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;

namespace RegistrWpfApp
{
    public class VerificateUser
    {

        public string Login { get; set; }
        public string Password { get; set; }


        public static ObservableCollection<VerificateUser> GetUsersList()
        {

            var userList = new ObservableCollection<VerificateUser>()
            {
                new VerificateUser() { Login = "Мага", Password = "123" },
            };

            return userList;
        }


        public async Task<bool> Check(string login, string password)
        {
            if (login != "" && password != "")
            {
                foreach (var user in GetUsersList())
                {
                    if (user.Login == login && user.Password == password)
                    {
                        MessageBox.Show("Вход выполнен успешно", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                        await Task.FromResult(true);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Stop);
                        return false;
                    }
                }
            }
            else MessageBox.Show("Не все поля заполнены!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Stop);
            return false;
        }
    }
}
