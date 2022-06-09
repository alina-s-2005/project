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

namespace project
{
    /// <summary>
    /// Логика взаимодействия для Advertisement.xaml
    /// </summary>
    public partial class Advertisement : Window
    {
        public Advertisement()
        {
            InitializeComponent();
            this.Loaded += vidio;
        }
        int time = 10;
        private void vidio(object sender, RoutedEventArgs e)
        {
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            System.Windows.Threading.DispatcherTimer timer1sec = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 11);
            timer.Start();
            timer1sec.Interval = new TimeSpan(0, 0, 1);
            timer1sec.Start();
            timer1sec.Tick += new EventHandler(timerTick1sec);
        }
        private void timerTick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timerTick1sec(object sender, EventArgs e)
        {
            SecAdvert.Text = Convert.ToString(time-1);
            time -= 1;
            
        }
    }
}
