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
using VanshenDiplomWork.AppData;
using VanshenDiplomWork.Models;


namespace VanshenDiplomWork.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();

        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.BodyFrame.Navigate(new Views.Pages.MainBodyPage());
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.BodyFrame.Navigate(new Views.Pages.SearchPage());
        }

        private void KorzinaBtn_Click(object sender, RoutedEventArgs e)
        {          
            var productsInKor = new List<Product>(); 
            FrameClass.BodyFrame.Navigate(new Views.Pages.KorzinaPage(productsInKor));
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.BodyFrame.Navigate(new Views.Pages.ProfilePage());
        }
    }
}
