using System.Collections.ObjectModel;

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


        public bool Check(string login, string password, string passwordBoxText)
        {
            foreach (var user in GetUsersList())
            {
                if (user.Login == login && user.Password == password) return true;
                else return false;
            }
            return false;
        }
    }
}
