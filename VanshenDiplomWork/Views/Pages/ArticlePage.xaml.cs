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
    /// Логика взаимодействия для ArticlePage.xaml
    /// </summary>
    public partial class ArticlePage : Page
    {
        public ArticlePage(Article selectedArticle)
        {
            InitializeComponent();

            DataContext = selectedArticle;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.BodyFrame.Navigate(new Views.Pages.MainBodyPage());
        }
    }
}
