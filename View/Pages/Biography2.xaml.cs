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
using WpfApp3.Core;

namespace WpfApp3.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Biography2.xaml
    /// </summary>
    public partial class Biography2 : Page
    {
        public Biography2()
        {
            InitializeComponent();

            OpasAnim txt = new OpasAnim();
            var gs = txt.OpasAnim1();
            txt1.BeginAnimation(OpacityProperty, gs);
            txt2.BeginAnimation(OpacityProperty, gs);
            txt3.BeginAnimation(OpacityProperty, gs);
            txt4.BeginAnimation(OpacityProperty, gs);
            txt5.BeginAnimation(OpacityProperty, gs);
            img1.BeginAnimation(OpacityProperty, gs);
            img2.BeginAnimation(OpacityProperty, gs);
            img3.BeginAnimation(OpacityProperty, gs);
            
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyCore.MyFrameCore.Navigate(new HomePage());
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyCore.MyFrameCore.Navigate(new Biography());
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MyCore.MyFrameCore.Navigate(new Biography3());
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MyCore.MyFrameCore.Navigate(new Gallery());
        }
    }
}
