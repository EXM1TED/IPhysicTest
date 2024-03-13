﻿using System;
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

        string Login = string.Empty;
        string Email = string.Empty;
        string Password = string.Empty;
        string PasswordCheck = string.Empty;
        public void BtnRegistrationConfirm_Click(object sender, RoutedEventArgs e)
        {
            Login = LoginInputTxt.Text;
            Email = EmailInputTxt.Text;
            Password = PasswordInputTxt.Password;
            PasswordCheck = PasswordInputCheckTxt.Password;
            if (LoginInputTxt.Text == "" && EmailInputTxt.Text == "" && PasswordInputTxt.Password == "" && PasswordInputCheckTxt.Password == "")
            {
                MessageBox.Show("Заполните хотя бы одно из полей", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (LoginInputTxt.Text == "")
            {
                MessageBox.Show("Заполните поле: Логин", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (EmailInputTxt.Text == "")
            {
                MessageBox.Show("Заполните поле: Электронная почта", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (PasswordInputTxt.Password == "")
            {
                MessageBox.Show("Заполните поле: Пароль", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (PasswordCheck != Password)
            {
                 MessageBox.Show("Пароли не совпадают", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RadBtnBeginner.IsChecked == false && RadBtnMidle.IsChecked == false && RadBtnЕxperienced.IsChecked == false) 
            {
                MessageBox.Show("Выберите свой уровень знаний по физике", "Ошибка регистрации", MessageBoxButton.OK, MessageBoxImage.Error);
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
            PasswordInputTxtVisible.Visibility = Visibility.Collapsed;
            PasswordInputTxt.Visibility = Visibility.Visible;
            PasswordInputTxt.Focus();
        }
    }
 }

