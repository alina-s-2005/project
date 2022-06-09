using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace project
{
    /// <summary>
    /// Логика взаимодействия для epizod_final.xaml
    /// </summary>
    public partial class epizod_final : UserControl
    {
        public epizod_final()
        {
            InitializeComponent();
        }

        private void yes_Checked(object sender, RoutedEventArgs e)
        {
            ep_f_win.Visibility = Visibility.Hidden;
        }

        private void no_Checked(object sender, RoutedEventArgs e)
        {
            ep_f_win.Visibility = Visibility.Hidden;
        }
        xp win_xp = new xp();
        private void ButtonXP_Click(object sender, RoutedEventArgs e)
        {
            win_xp.Title = "0";
            win_xp.Show();
            win_xp.Closing += PerenosXP;

        }

        private void PerenosXP(object sender, CancelEventArgs e)
        {
            XPLabel.Content = win_xp.Title;
            ButtonXP.IsEnabled = false;
        }
    }
}
