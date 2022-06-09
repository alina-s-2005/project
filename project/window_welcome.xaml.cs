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
using System.Windows.Threading;

namespace project
{
    /// <summary>
    /// Логика взаимодействия для window_welcome.xaml
    /// </summary>
    public partial class window_welcome : UserControl
    {
        DispatcherTimer timer = new DispatcherTimer();
        public window_welcome()
        {
            InitializeComponent();

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        int count = 10;
        private void timer_Tick(object sender, EventArgs e)
        {
            time.Content = count;
            --count;

            if (count == -1)
            {
                timer.Stop();
            }
        }
    }
}
