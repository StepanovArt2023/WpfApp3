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
    /// Логика взаимодействия для HomePage2.xaml
    /// </summary>
    public partial class HomePage2 : Page
    {
        public HomePage2()
        {
            InitializeComponent();

            DoubleAnimation gojo1 = new DoubleAnimation();
            gojo1.From = 310;
            gojo1.To = 320;
            gojo1.From = 400;
            gojo1.To = 410;
            gojo1.Duration = TimeSpan.FromSeconds(2);
            Gojo2.BeginAnimation(Image.WidthProperty, gojo1);

            OpasAnim txt = new OpasAnim();
            var gs = txt.OpasAnim1();
            txt1.BeginAnimation(OpacityProperty, gs);
            txt2.BeginAnimation(OpacityProperty, gs);
            txt3.BeginAnimation(OpacityProperty, gs);
            txt4.BeginAnimation(OpacityProperty, gs);
            txt5.BeginAnimation(OpacityProperty, gs);
            txt6.BeginAnimation(OpacityProperty, gs);
            txt7.BeginAnimation(OpacityProperty, gs);
            txt8.BeginAnimation(OpacityProperty, gs);
            txt9.BeginAnimation(OpacityProperty, gs);
            txt10.BeginAnimation(OpacityProperty, gs);
            txt11.BeginAnimation(OpacityProperty, gs);
            txt12.BeginAnimation(OpacityProperty, gs);
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 1)
            {
                MyCore.MyFrameCore.Navigate(new HomePage());
            }
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyCore.MyFrameCore.Navigate(new HomePage());
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MyCore.MyFrameCore.Navigate(new HomePage3());
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MyCore.MyFrameCore.Navigate(new Biography());
        }

        private void TextBlock_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            MyCore.MyFrameCore.Navigate(new Gallery());
        }
    }
}
