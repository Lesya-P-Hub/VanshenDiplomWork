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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VanshenDiplomWork.Models;
using VanshenDiplomWork.Views.Windows;

namespace VanshenDiplomWork.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();


            var user = App.enteredUser;
            DataContext = user;

            NameTb.DataContext = user;
            SurnameTb.DataContext = user;
            

            
            var bankCards = App.context.BankCard.Local;
            CardCmb.ItemsSource = bankCards;
            CardCmb.DisplayMemberPath = "Num";
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            CardWindow cardWindow = new CardWindow ();
            cardWindow.Show();
      
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Window.GetWindow(this).Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
