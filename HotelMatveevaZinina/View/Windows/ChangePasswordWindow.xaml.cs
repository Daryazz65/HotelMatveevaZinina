﻿using HotelMatveevaZinina.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelMatveevaZinina.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Window
    {
        public ChangePasswordWindow()
        {
            InitializeComponent();
        }

        private void ChangePasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            ChangedPassword();
        }

        public void ChangedPassword()
        {
            if (string.IsNullOrEmpty(OldPasswordPb.Password) || 
                string.IsNullOrEmpty(NewPasswordPb.Password) || 
                string.IsNullOrEmpty(AcceptNewPasswordPb.Password))
            {
                MessageBoxHelper.Warning
                    ("Все поля обязательны для заполнения! Заполните каждое поле!");
            }
            else if (OldPasswordPb.Password != App.currentUser.Password)
            {
                MessageBoxHelper.Error("Неверно введен текущий пароль! Попробуйте снова.");
            }
            else if (NewPasswordPb.Password != AcceptNewPasswordPb.Password)
            {
                MessageBoxHelper.Error("Новые пароли не совпадают! Попробуйте снова.");

            }
            else if(OldPasswordPb.Password == NewPasswordPb.Password)
            {
                MessageBoxHelper.Error("Старый и новый пароль совпадают! Придумайте новый пароль.");
            }
            else
            {
                App.currentUser.Password = NewPasswordPb.Password;
                App.currentUser.IsActiveted = true;

                App.context.SaveChanges();

                MessageBoxHelper.Information("Пароль успешно изменен!");

                Close();
            }
        }
    }
}
