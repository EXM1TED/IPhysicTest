using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Я_физик_тест.Classes 
{
    class UserClass : MainWindow
    {
        private string login;
        private string email;
        private string password;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public UserClass()
        {
            login = string.Empty;
            email = string.Empty;
            password = string.Empty;
        }

        public UserClass(string login, string email, string password)
        {
            Login = login;
            Email = email;
            Password = password;
        }

       public void RegConfirm() 
        {
           Login = LoginInputTxt.Text;
           Password = PasswordInputTxt.Password;
        }
    }
}
