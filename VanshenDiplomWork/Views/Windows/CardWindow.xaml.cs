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
using VanshenDiplomWork.Views.Pages;

namespace VanshenDiplomWork.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для CardWindow.xaml
    /// </summary>
    public partial class CardWindow : Window
    {
        public CardWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrEmpty(CardTb.Text))
            {
                MessageBox.Show("Введите номер карты!");

            }
            else if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            BankCard card = new BankCard()
            {
                Num = CardTb.Text,
                Period = DateTime.Parse("19/06/2024"),
                CVC = 111
            };

            App.context.BankCard.Add(card);
            App.context.SaveChanges();
            this.Close();

            
            var profilePage = new ProfilePage();
            var comboBox = profilePage.FindName("CardCmb") as ComboBox;
            comboBox.Items.Refresh();
            comboBox.DisplayMemberPath = "Num";

            this.Close();
        }

        private void CardTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsNumber(e.Text.First()))
            {
                e.Handled = true;
            }
        }
    }
}
