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
    /// Логика взаимодействия для xp.xaml
    /// </summary>
    public partial class xp : Window
    {
        public xp()
        {
            InitializeComponent();
            this.Loaded += vidio;
        }

        int time = 30;
        private void vidio(object sender, RoutedEventArgs e)
        {
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            System.Windows.Threading.DispatcherTimer timer1sec = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 31);
            timer.Start();
            timer1sec.Interval = new TimeSpan(0, 0, 1);
            timer1sec.Start();
            timer1sec.Tick += new EventHandler(timerTick1sec);
        }
        private void timerTick(object sender, EventArgs e)
        {
            scores.Content = " + " + Convert.ToString(XP) + " xp";
            scores.Visibility = Visibility.Visible;
            close.Visibility = Visibility.Visible;

        }
        private void timerTick1sec(object sender, EventArgs e)
        {
            time_str.Content = Convert.ToString(time - 1);
            time -= 1;

        }

        int XP = 0;
        int count = 0;

        private void answer_Click(object sender, RoutedEventArgs e)
        {
            ++count;
            if(count == 1)
            {
                if(kamni_ans1.Text == "сухих")
                {
                    XP += 10;
                    right.Visibility = Visibility.Visible;
                }
                else
                {
                    bad.Visibility = Visibility.Visible;
                }

                System.Windows.Threading.DispatcherTimer timer1 = new System.Windows.Threading.DispatcherTimer();
                timer1.Tick += new EventHandler(timerTick_);
                timer1.Interval = new TimeSpan(0, 0, 2);
                timer1.Start();

                kamni_ans1.Visibility = Visibility.Hidden;
                kamni_q1.Visibility = Visibility.Hidden;

                people.Visibility = Visibility.Visible;
                three1.Visibility = Visibility.Visible;
                four1.Visibility = Visibility.Visible;
                six1.Visibility = Visibility.Visible;
            }
            else if(count == 2)
            {
                if(three1.IsChecked == true)
                {
                    XP += 10;
                    right.Visibility = Visibility.Visible;
                }
                else
                {
                    bad.Visibility = Visibility.Visible;
                }

                System.Windows.Threading.DispatcherTimer timer2 = new System.Windows.Threading.DispatcherTimer();
                timer2.Tick += new EventHandler(timerTick_);
                timer2.Interval = new TimeSpan(0, 0, 2);
                timer2.Start();

                people.Visibility = Visibility.Hidden;
                three1.Visibility = Visibility.Hidden;
                four1.Visibility = Visibility.Hidden;
                six1.Visibility = Visibility.Hidden;

                houses.Visibility = Visibility.Visible;
                rich.Visibility = Visibility.Visible;
                poor.Visibility = Visibility.Visible;
                none.Visibility = Visibility.Visible;
            }
            else
            {
                if (none.IsChecked == true)
                {
                    XP += 10;
                    right.Visibility = Visibility.Visible;
                }
                else
                {
                    bad.Visibility = Visibility.Visible;
                }
                answer.Visibility = Visibility.Hidden;


                System.Windows.Threading.DispatcherTimer timer3 = new System.Windows.Threading.DispatcherTimer();
                timer3.Tick += new EventHandler(timerTick_);
                timer3.Interval = new TimeSpan(0, 0, 2);
                timer3.Start();

                houses.Visibility = Visibility.Hidden;
                rich.Visibility = Visibility.Hidden;
                poor.Visibility = Visibility.Hidden;
                none.Visibility = Visibility.Hidden;
            }
        }
        private void timerTick_(object sender, EventArgs e)
        {
            right.Visibility = Visibility.Hidden;
            bad.Visibility = Visibility.Hidden;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Title = Convert.ToString(XP);
            this.Close();
        }

        private void xp_win_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                ++count;
                if (count == 1)
                {
                    if (kamni_ans1.Text == "сухих")
                    {
                        XP += 10;
                        right.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        bad.Visibility = Visibility.Visible;
                    }

                    System.Windows.Threading.DispatcherTimer timer1 = new System.Windows.Threading.DispatcherTimer();
                    timer1.Tick += new EventHandler(timerTick_);
                    timer1.Interval = new TimeSpan(0, 0, 2);
                    timer1.Start();

                    kamni_ans1.Visibility = Visibility.Hidden;
                    kamni_q1.Visibility = Visibility.Hidden;

                    people.Visibility = Visibility.Visible;
                    three1.Visibility = Visibility.Visible;
                    four1.Visibility = Visibility.Visible;
                    six1.Visibility = Visibility.Visible;
                }
                else if (count == 2)
                {
                    if (three1.IsChecked == true)
                    {
                        XP += 10;
                        right.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        bad.Visibility = Visibility.Visible;
                    }

                    System.Windows.Threading.DispatcherTimer timer2 = new System.Windows.Threading.DispatcherTimer();
                    timer2.Tick += new EventHandler(timerTick_);
                    timer2.Interval = new TimeSpan(0, 0, 2);
                    timer2.Start();

                    people.Visibility = Visibility.Hidden;
                    three1.Visibility = Visibility.Hidden;
                    four1.Visibility = Visibility.Hidden;
                    six1.Visibility = Visibility.Hidden;

                    houses.Visibility = Visibility.Visible;
                    rich.Visibility = Visibility.Visible;
                    poor.Visibility = Visibility.Visible;
                    none.Visibility = Visibility.Visible;
                }
                else
                {
                    if (none.IsChecked == true)
                    {
                        XP += 10;
                        right.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        bad.Visibility = Visibility.Visible;
                    }
                    answer.Visibility = Visibility.Hidden;


                    System.Windows.Threading.DispatcherTimer timer3 = new System.Windows.Threading.DispatcherTimer();
                    timer3.Tick += new EventHandler(timerTick_);
                    timer3.Interval = new TimeSpan(0, 0, 2);
                    timer3.Start();

                    houses.Visibility = Visibility.Hidden;
                    rich.Visibility = Visibility.Hidden;
                    poor.Visibility = Visibility.Hidden;
                    none.Visibility = Visibility.Hidden;
                }
            }
        }
    }
 }
    
