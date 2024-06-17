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

namespace VanshenDiplomWork.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для TestNextWindow.xaml
    /// </summary>
    public partial class TestNextWindow : Window
    {
        public int TestA { get; set; }
        public TestNextWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Rb1.IsChecked == true)
            {
                TestA += 1;
                ResultWindow result= new ResultWindow();
                result.TestA = TestA;
                result.Show();
                this.Close();
            }

            if (Rb2.IsChecked == true)
            {
                TestA += 2;
                ResultWindow result = new ResultWindow();
                result.TestA = TestA;
                result.Show();
                this.Close();
            }

            if (Rb3.IsChecked == true)
            {
                TestA += 3;
                ResultWindow result = new ResultWindow();
                result.TestA = TestA;
                result.Show();
                this.Close();
            }

            if (!(Rb1.IsChecked ?? false) && !(Rb2.IsChecked ?? false) && !(Rb3.IsChecked ?? false))
            {
                MessageBox.Show("Выберите опцию");
                return;
            }
        }
    }
}
