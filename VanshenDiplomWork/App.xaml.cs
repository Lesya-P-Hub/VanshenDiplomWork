using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VanshenDiplomWork.Models;

namespace VanshenDiplomWork
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static VanshenDatabaseEntities1 context = new VanshenDatabaseEntities1();
       
        public static User enteredUser;
        public static Article selectedArticle;
        public static Product selectedProduct;
    }
}
