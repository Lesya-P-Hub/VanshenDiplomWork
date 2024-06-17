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
using VanshenDiplomWork.Views.Windows;

namespace VanshenDiplomWork.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainBodyPage.xaml
    /// </summary>
    public partial class MainBodyPage : Page
    {
        public MainBodyPage()
        {
            InitializeComponent();

            
            ArticleLb.ItemsSource = App.context.Article.ToList();

        }

        private void ProductLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product selectedProduct = (Models.Product)ArticleLb.SelectedItem;
            FrameClass.BodyFrame.Navigate(new Views.Pages.ProductPage(selectedProduct));
        }

        private void ArticleLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Article selectedArticle = (Models.Article)ArticleLb.SelectedItem;
            FrameClass.BodyFrame.Navigate(new Views.Pages.ArticlePage(selectedArticle));
        }

        private void BannerBtn_Click(object sender, RoutedEventArgs e)
        {
            TestWindow testWindow = new TestWindow();
            testWindow.Show();  
        }
    }
}
