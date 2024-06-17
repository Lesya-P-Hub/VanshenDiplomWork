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
using VanshenDiplomWork.Models;
using System.Data.Entity;

namespace VanshenDiplomWork.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void RegistBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrEmpty(NameTb.Text))
            {
                mes += "Введите имя!\n";
            }
            if (string.IsNullOrEmpty(SurnameTb.Text))
            {
                mes += "Введите фамилию!\n";
            }
            if (string.IsNullOrEmpty(PhoneTb.Text))
            {
                mes += "Введите телефон (логин)!\n";
            }
            if (string.IsNullOrEmpty(PasswordPb.Password))
            {
                mes += "Введите пароль!\n";
            }
            if (ChekCb.IsChecked == false)
            {
                mes += "Без согласия на обработку данных мы не можем допустить вас к использованию приложения\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            User user = new User
            {
                Name = NameTb.Text,
                Surname = SurnameTb.Text,
                Patronimyc = PatronimycTb.Text,
                Phone = PhoneTb.Text,
                Address = "Не указан",
                StatusId = 1,
                Password = PasswordPb.Password
            };
            App.context.User.Add(user);
            App.context.SaveChanges();
            App.enteredUser = user;
            ShopMainWindow shopMainWindow = new ShopMainWindow();
            shopMainWindow.Show();
            this.Close();
        }

        private void NameTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsLetter(c) || c < 'А' || c > 'я')
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void SurnameTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsLetter(c) || c < 'А' || c > 'я')
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void PatronimycTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsLetter(c) || c < 'А' || c > 'я')
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void PhoneTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsNumber(e.Text.First()))
            {
                e.Handled = true;
            }
        }
    }
}
