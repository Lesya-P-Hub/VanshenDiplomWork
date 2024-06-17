using System.Windows;

namespace VanshenDiplomWork.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        public int TestA { get; set; }
        public ResultWindow()
        {
            InitializeComponent();

            DataContext = this;

            if (TestA == 3 || TestA <= 4)
            {
                ResultTb.Text = "Ваш результат теста... Шу Пуэр! Данный чай получился таким же необычным, как и его вкус. Этот сорт не для всех, его могут оценить только истинные гурманы.";
            }

            if (TestA <= 5 || TestA <= 6)
            {
                ResultTb.Text = "Ваш результат теста... Сюэ Я! Данный чай оказался для вас наиболее подходящим, открывая новые грани вкуса и аромата, а так же дарит заряд бодрости";
            }

            else
            {
                ResultTb.Text = "Ваш результат теста... Серебрянные иглы! Данный чай, обладающий нежным и изысканным вкусом, идеально подходит для тех, кто ценит утонченность и легкость в напитках.";
            }
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
