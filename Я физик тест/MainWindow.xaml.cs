using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
using Я_физик_тест.Classes;
using Я_физик_тест.Pages;

namespace Я_физик_тест
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        string PasswordCheck = string.Empty;
        public void BtnRegistrationConfirm_Click(object sender, RoutedEventArgs e)
        {
            UserClass user = new UserClass();
            user.Login = LoginInputTxt.Text;
            user.Password = PasswordInputTxt.Password;
            string checkPassword = PasswordInputCheckTxt.Password;
            if (LoginInputTxt.Text == "" && PasswordInputTxt.Password == "" && PasswordInputCheckTxt.Password == "")
            {
                MessageBox.Show("Заполните хотя бы одно из полей", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (LoginInputTxt.Text == "")
            {
                MessageBox.Show("Заполните поле: Логин", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (PasswordInputTxt.Password == "")
            {
                MessageBox.Show("Заполните поле: Пароль", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (checkPassword != user.Password)
            {
                 MessageBox.Show("Пароли не совпадают", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RadBtnBeginner.IsChecked == false && RadBtnMidle.IsChecked == false && RadBtnЕxperienced.IsChecked == false) 
            {
                MessageBox.Show("Выберите свой уровень знаний по физике", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Close();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            }
        }
        private void ChkBxShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            PasswordInputTxtVisible.Visibility = Visibility.Visible;
            PasswordInputTxt.Visibility = Visibility.Collapsed;
            PasswordInputTxtVisible.Text = PasswordInputTxt.Password;
        }

        private void ChkBxShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordInputTxt.Password = PasswordInputTxtVisible.Text;
            PasswordInputTxtVisible.Visibility = Visibility.Collapsed;
            PasswordInputTxt.Visibility = Visibility.Visible;
            PasswordInputTxt.Focus();
        }
    }
 }

