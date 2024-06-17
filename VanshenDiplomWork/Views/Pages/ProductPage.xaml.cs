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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page

    {

       
        public ProductPage(Product selectedProduct, List<Product> productsInKor = null)
        {
            InitializeComponent();

            
            var product = selectedProduct;

            
            DataContext = product;

            ProductsInKor = productsInKor ?? new List<Product>();
            SelectedProduct = selectedProduct;
        }

        public Product SelectedProduct { get; set; }
        public List<Product> ProductsInKor { get; set; }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.BodyFrame.Navigate(new Views.Pages.MainBodyPage());
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
         
            ProductsInKor.Add(SelectedProduct);
            MessageBox.Show("Добавлено в корзину");
            FrameClass.BodyFrame.Navigate(new Views.Pages.KorzinaPage(ProductsInKor));
        }
    }
}
