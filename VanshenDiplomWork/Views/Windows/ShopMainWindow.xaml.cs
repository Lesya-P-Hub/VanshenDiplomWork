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
using VanshenDiplomWork.AppData;

namespace VanshenDiplomWork.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для ShopMainWindow.xaml
    /// </summary>
    public partial class ShopMainWindow : Window
    {
        public ShopMainWindow()
        {
            InitializeComponent();

            FrameClass.LogoFrame = LogoFrm;
            LogoFrm.Navigate(new Views.Pages.LogoPage());
            FrameClass.BodyFrame = BodyFrm;
            BodyFrm.Navigate(new Views.Pages.MainBodyPage());
            FrameClass.MenuFrame = MenuFrm;
            MenuFrm.Navigate(new Views.Pages.MenuPage());
        }

        private void BodyFrm_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
