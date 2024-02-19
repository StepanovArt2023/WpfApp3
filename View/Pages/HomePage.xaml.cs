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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3.Core;

namespace WpfApp3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();

            DoubleAnimation gojo = new DoubleAnimation();
            gojo.From = 150;
            gojo.To = 430;
            gojo.From = 150;
            gojo.To = 430;
            gojo.Duration = TimeSpan.FromSeconds(2);
            Gojo1.BeginAnimation(Image.WidthProperty, gojo);
        }

        private void Gojo1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 1) {
                MyCore.MyFrameCore.Navigate(new HomePage2());
            }
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyCore.MyFrameCore.Navigate(new Biography());
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MyCore.MyFrameCore.Navigate(new Gallery());
        }
    }
}
