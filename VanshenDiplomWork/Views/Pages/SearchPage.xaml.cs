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
    /// Логика взаимодействия для SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {

        List<Filter> categories = new List<Filter>();
        public SearchPage()
        {
            InitializeComponent();

            ProductLb.ItemsSource = App.context.Product.ToList();
            categories = App.context.Filter.ToList();
            categories.Insert(0, new Filter { Name = "Все категории" });
            TypeCmb.ItemsSource = categories;
        }

        private void ProductLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product selectedProduct = (Models.Product)ProductLb.SelectedItem;
            FrameClass.BodyFrame.Navigate(new Views.Pages.ProductPage(selectedProduct));
        }

        private void TypeCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TypeCmb.SelectedIndex != 0)
            {
                ProductLb.ItemsSource = App.context.Product.Where(x => x.Id == TypeCmb.SelectedIndex).ToList();
            }

            else
            {
                ProductLb.ItemsSource = App.context.Product.ToList();
            }
        }

        private void SearchTb_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (SearchTb.Text == String.Empty)
            {
                ProductLb.ItemsSource = App.context.Product.ToList();
            }
        }

        private void FreshBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SearchTb.Text != string.Empty)
            {
                ProductLb.ItemsSource = App.context.Product.Where(x => x.Name.ToLower().Contains(SearchTb.Text.ToLower())).ToList();
            }

            else
            {
                ProductLb.ItemsSource = App.context.Product.ToList();
            }
        }

        private void SearchTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
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
    }
}
