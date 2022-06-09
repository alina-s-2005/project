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
using System.ComponentModel;

namespace project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        MediaPlayer player = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();

            player.Open(new Uri("Howard Shore - Bag End.mp3", UriKind.Relative));
            player.Volume = 0.7;
            player.Play();
        }


        int XP = 30;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Advertisement advertisementWindow = new Advertisement();
            advertisementWindow.Title = "Advertisement";
            advertisementWindow.Topmost = true;
            advertisementWindow.Owner = this;
            advertisementWindow.Show();
            advertisementWindow.Closed += plusXP;
        }

        private void plusXP(object sender, EventArgs e)
        {
            XP += 5;
            TextXP.Text = XP + " xp";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LotteryWindow lottery = new LotteryWindow();
            lottery.Title = "Lottery";
            lottery.Owner = this;
            lottery.Show();
            XP -= 10;
            TextXP.Text = XP + " xp";
            if (XP == 0) { lottery.Title = "0"; lottery.Close(); }
            lottery.Closing += Prize;
        }

        private void Prize(object sender, CancelEventArgs e)
        {
            foreach (Window w in this.OwnedWindows)
            {
                XP += Convert.ToInt32(w.Title);
                w.Title = Convert.ToString(0);
            }
            TextXP.Text = XP + " xp";
            if (XP < 50)
            {
                Ep_f.yes.IsEnabled = false;
            }
        }







        //-------------------------------------просто нада
        private void Zastavka_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Ep1_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Ep2_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Ep3_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Ep4_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Ep5_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Ep_f_Loaded(object sender, RoutedEventArgs e)
        {

        }
        //---------------------------------

        private void Zastavka_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Zastavka.Visibility == Visibility.Hidden)
            {
                Ep1.Visibility = Visibility.Visible;
                player.Stop();
                player.Open(new Uri("second_music.mp3", UriKind.Relative));
                player.Volume = 0.7;
                player.Play();
            }
        }

        private void Ep1_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Ep1.Visibility == Visibility.Hidden)
            {
                player.Stop();
                player.Open(new Uri("third.mp3", UriKind.Relative));
                player.Volume = 0.7;
                player.Play();
                Ep2.Visibility = Visibility.Visible;

                XP += Convert.ToInt32(Ep1.about_sam.Text);
                TextXP.Text = XP + " xp";

            }
        }
        private void Ep2_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Ep2.Visibility == Visibility.Hidden)
            {
                player.Stop();
                player.Open(new Uri("Howard Shore - Rivendell.mp3", UriKind.Relative));
                player.Volume = 0.7;
                player.Play();
                Ep3.Visibility = Visibility.Visible;
                XP += Convert.ToInt32(Ep2.strider.Text);
                TextXP.Text = XP + " xp";
            }
        }
        private void Ep3_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Ep3.Visibility == Visibility.Hidden)
            {
                player.Stop();
                player.Open(new Uri("Howard Shore - The Taming of Smeagol.mp3", UriKind.Relative));
                player.Volume = 0.7;
                player.Play();
                Ep4.Visibility = Visibility.Visible;
                XP += Convert.ToInt32(Ep3.choice.Text);
                TextXP.Text = XP + " xp";
            }
        }

        private void Ep4_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Ep4.Visibility == Visibility.Hidden)
            {
                player.Stop();
                player.Open(new Uri("Howard Shore - Minas Morgul.mp3", UriKind.Relative));
                player.Volume = 0.7;
                player.Play();
                Ep5.Visibility = Visibility.Visible;
                XP += Convert.ToInt32(Ep4.gollum.Text);
                TextXP.Text = XP + " xp";
            }
        }

        private void Ep5_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Ep5.Visibility == Visibility.Hidden)
            {
                player.Stop();
                player.Open(new Uri("Howard Shore feat. Renee Fleming - The End of All Things (feat. Renee Fleming).mp3", UriKind.Relative));
                player.Volume = 0.7;
                player.Play();
                Ep_f.Visibility = Visibility.Visible;
                XP += Convert.ToInt32(Ep5.trust.Text);
                TextXP.Text = XP + " xp";
                if (XP < 50)
                {
                    Ep_f.yes.IsEnabled = false;
                }
            }
        }

        private void Ep_f_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Ep_f.Visibility == Visibility.Hidden)
            {
                player.Stop();
                player.Open(new Uri("Howard Shore feat. Sir James Galway - The Grey Havens (feat. Sir James Galway).mp3", UriKind.Relative));
                player.Volume = 0.7;
                player.Play();
                
                XP += Convert.ToInt32(Ep_f.XPLabel.Content);

                if(Ep_f.yes.IsChecked == true)
                {
                    Winning window_win = new Winning();
                    window_win.Show();
                    window_win.Topmost = true;
                    window_win.Owner = this;
                    window_win.Closing += LossChoice;
                }
                else
                {
                    Loss loss = new Loss();
                    loss.Title = "Loss";
                    loss.Topmost = true;
                    loss.Owner = this;
                    loss.Show();

                    loss.Closing += LossChoice;
                }
            }
        }
        private void TextXP_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (XP >= 50)
            {
                Ep_f.yes.IsEnabled = true;
            }
            if (XP <= 0)
            {
               
            }
        }

        private void LossChoice(object sender, CancelEventArgs e)
        {
            foreach (Window r in this.OwnedWindows)
            {
                if (r.Title == "Exit") { 
                    this.Close(); 
                }
                if (r.Title == "Restate")
                {
                    Ep1.Visibility = Visibility.Hidden;
                    Ep2.Visibility = Visibility.Hidden;
                    Ep3.Visibility = Visibility.Hidden;
                    Ep4.Visibility = Visibility.Hidden;
                    Ep5.Visibility = Visibility.Hidden;
                    Ep_f.Visibility = Visibility.Hidden;

                    Zastavka.Visibility = Visibility.Visible;
                    XP = 30;
                    TextXP.Text = XP + " xp";
                    Ep_f.no.IsChecked = false;
                    Ep_f.yes.IsChecked = false;

                    player.Open(new Uri("first_music.mp3", UriKind.Relative));
                    player.Volume = 0.7;
                    player.Play();
                }

            }
        }

    }
}
