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

namespace project
{
    /// <summary>
    /// Логика взаимодействия для epizod1.xaml
    /// </summary>
    public partial class epizod1 : UserControl
    {
        public epizod1()
        {
            InitializeComponent();
        }

        private void no_Checked(object sender, RoutedEventArgs e)
        {
            about_sam.Text = "-10";
            next.Visibility = Visibility.Visible;
        }

        private void yes_Checked(object sender, RoutedEventArgs e)
        {
            about_sam.Text = "10";
            next.Visibility = Visibility.Visible;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            ep1_win.Visibility = Visibility.Hidden;
            no.IsChecked = false;
            yes.IsChecked = false;
        }
    }
}
