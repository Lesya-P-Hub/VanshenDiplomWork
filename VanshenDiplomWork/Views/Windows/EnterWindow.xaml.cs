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

namespace VanshenDiplomWork.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для EnterWindow.xaml
    /// </summary>
    public partial class EnterWindow : Window
    {
        public EnterWindow()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrEmpty(PnoheTb.Text))
            {
                mes += "Введите телефон (логин)!\n";
            }
            if (string.IsNullOrEmpty(PasswordPb.Password))
            {
                mes += " Введите пароль!\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            User user = App.context.User.FirstOrDefault(w => w.Phone == PnoheTb.Text && w.Password == PasswordPb.Password);
            if (user != null)
            {
                App.enteredUser = user;
                ShopMainWindow shopMainWindow = new ShopMainWindow();
                shopMainWindow.Show();
                this.Close();
            }

           
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void PnoheTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsNumber(e.Text.First()))
            {
                e.Handled = true;
            }
        }
    }
}
