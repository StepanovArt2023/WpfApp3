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
    /// Логика взаимодействия для HomePage4.xaml
    /// </summary>
    public partial class HomePage4 : Page
    {
        public HomePage4()
        {
            InitializeComponent();
            OpasAnim txt = new OpasAnim();
            var gs = txt.OpasAnim1();
            txt1.BeginAnimation(OpacityProperty, gs);
            txt2.BeginAnimation(OpacityProperty, gs);
            TextFieldName.BeginAnimation(OpacityProperty, gs);
            TextFieldName2.BeginAnimation(OpacityProperty, gs);
            but1.BeginAnimation(OpacityProperty, gs);
            Gojo3.BeginAnimation(OpacityProperty, gs);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextFieldName2.Text == "")
            {
                ErorTExtName2.Visibility = Visibility.Visible;
                TextFieldName2.BorderBrush = Brushes.Red;
            }
            else if(TextFieldName2.Text != "")
            {
                ErorTExtName2.Visibility = Visibility.Hidden;
                TextFieldName2.BorderBrush = Brushes.White;
            }
                //ErorTExtName
            if (TextFieldName.Text == "")
            {
                ErorTExtName.Visibility = Visibility.Visible;
                TextFieldName.BorderBrush = Brushes.Red;
            }
            else if(TextFieldName.Text != "")
            {
                ErorTExtName.Visibility = Visibility.Hidden;
                TextFieldName.BorderBrush = Brushes.White;

            }
            if(TextFieldName.Text != ""&& TextFieldName2.Text != "")
            Thanksq.Visibility = Visibility.Visible;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MyCore.MyFrameCore.Navigate(new HomePage3());
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
