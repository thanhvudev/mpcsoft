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
namespace TVD_MathPhyChe_Software
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Toan toanhoc = new Toan();
            toanhoc.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            About gtphanmem = new About();
            gtphanmem.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            VatLi vatli = new VatLi();
            vatli.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Hoahoc hoahoc = new Hoahoc();
            hoahoc.Show();
        }
        private void rotate(object sender, RoutedEventArgs e)
        {
            DoubleAnimation rt = new DoubleAnimation();
            rt.From = 0;
            rt.To = 180;
            rt.Duration = new Duration(TimeSpan.FromSeconds(1.5));

            RotateTransform rtani = new RotateTransform();
            loadingimg.RenderTransform = rtani;
            rtani.BeginAnimation(RotateTransform.AngleProperty, rt);
            loadingbutton.Visibility = Visibility.Hidden;
        }
    }
}
