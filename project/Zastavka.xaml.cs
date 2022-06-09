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
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace project
{
    /// <summary>
    /// Логика взаимодействия для Zastavka.xaml
    /// </summary>
    public partial class Zastavka : UserControl
    {
        public Zastavka()
        {
            InitializeComponent();

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 187;
            animation.To = 250;
            animation.Duration = TimeSpan.FromSeconds(3);
            animation.RepeatBehavior = new RepeatBehavior(10);
            animation.AutoReverse = true;
            start.BeginAnimation(Button.WidthProperty, animation);


            animation.RepeatBehavior = new RepeatBehavior(10);

            DoubleAnimation animation2 = new DoubleAnimation();
            animation2.From = 52;
            animation2.To = 100;
            animation2.Duration = TimeSpan.FromSeconds(3);
            animation2.RepeatBehavior = new RepeatBehavior(10);
            animation2.AutoReverse = true;
            start.BeginAnimation(Button.HeightProperty, animation2);


            animation2.RepeatBehavior = new RepeatBehavior(10);
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {

            zast.Visibility = Visibility.Hidden;
        }

    }
}
