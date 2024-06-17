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

namespace VanshenDiplomWork.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для KorzinaPage.xaml
    /// </summary>
    public partial class KorzinaPage : Page
    {
        private List<Product> productsInKor;

        public KorzinaPage(List<Product> productsInKor)
        {
            if (productsInKor == null)
            {
                throw new ArgumentNullException(nameof(productsInKor), "Список продуктов в корзине не может быть  пусто.");
            }


            InitializeComponent();

   
            ProductsLv.ItemsSource = productsInKor;
            var sum = productsInKor.Select(x => x.Price ?? 0).Sum();
            SumTb.Text = Convert.ToString(sum); 

        }

        private void BuyBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Благодарим за заказ, скоро наши операторы позвонят для уточнения заказа");
            ProductsLv.ItemsSource = null;
            SumTb.Text = string.Empty;
        }

       
        }
        }
        

