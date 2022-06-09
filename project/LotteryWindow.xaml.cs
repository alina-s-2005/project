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
    /// Логика взаимодействия для LotteryWindow.xaml
    /// </summary>
    public partial class LotteryWindow : Window
    {
        public LotteryWindow()
        {
            InitializeComponent();
        }
        Random random = new Random();
        
        List<TextBlock> textBlocks = new List<TextBlock>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button.IsEnabled = false;
            textBlocks.Add(P30);
            textBlocks.Add(P25);
            textBlocks.Add(P20);
            textBlocks.Add(P15);
            textBlocks.Add(P10);
            textBlocks.Add(P5);
            textBlocks.Add(M30);
            textBlocks.Add(M25);
            textBlocks.Add(M20);
            textBlocks.Add(M15);
            textBlocks.Add(M10);
            textBlocks.Add(M5);
            foreach (var i in textBlocks) {
                i.Background = new SolidColorBrush(Color.FromRgb(216, 165, 113));
            }
            
            
            int prize = random.Next(12); 
            textBlocks[prize].Background = new SolidColorBrush(Color.FromRgb(234, 98, 47));
            switch (prize)
            {
                case 0:
                    this.Title=  Convert.ToString(30);
                    break;
                case 1:
                    this.Title =  Convert.ToString(25);
                    break;
                case 2:
                    this.Title = Convert.ToString(20);
                    break;
                case 3:
                    this.Title = Convert.ToString(15);
                    break;
                case 4:
                    this.Title =   Convert.ToString(10);
                    break;
                case 5:
                    this.Title =   Convert.ToString(5);
                    break;
                case 6:
                    this.Title =  Convert.ToString(-30);
                    break;
                case 7:
                    this.Title = Convert.ToString(-25);
                    break;
                case 8:
                    this.Title =  Convert.ToString(-20);
                    break;
                case 9:
                    this.Title = Convert.ToString(-15);
                    break;
                case 10:
                    this.Title = Convert.ToString(-10);
                    break;
                case 11:
                    this.Title = Convert.ToString(-5);
                    break;
            }

        }

    }

        
            

    }

