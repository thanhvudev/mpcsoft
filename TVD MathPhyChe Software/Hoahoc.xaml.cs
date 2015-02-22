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

namespace TVD_MathPhyChe_Software
{
    /// <summary>
    /// Interaction logic for Hoahoc.xaml
    /// </summary>
    public partial class Hoahoc : Window
    {
        public Hoahoc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            choncongcu.Visibility = Visibility.Hidden;
            tracuu.Visibility = Visibility.Visible;
            text2nthh.Visibility = Visibility.Visible;
            textnthh.Visibility = Visibility.Visible;
            khhh.Visibility = Visibility.Visible;
            ketquakhhh.Visibility = Visibility.Visible;
        }

        private void tracuu_Click(object sender, RoutedEventArgs e)
        {
            string kihieuhh = khhh.Text;
            switch(kihieuhh)
            {
                case "Fe":
                    ketquakhhh.Text = "56";
                    break;
                case "Na":
                    ketquakhhh.Text = "14";
                    break;
                case "H":
                    ketquakhhh.Text = "1";
                    break;
                case "O":
                    ketquakhhh.Text = "16";
                    break;
                case "Cl":
                    ketquakhhh.Text = "35.5";
                    break;
                case "S":
                    ketquakhhh.Text = "32";
                    break;
                default:
                    MessageBox.Show("Bạn chưa nhập kí hiệu hoá học (Chú ý phân biệt chữ hoa và chữ thường)");
                    break;
            }
        }

    }
}
