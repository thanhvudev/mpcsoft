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
    /// Interaction logic for VatLi.xaml
    /// </summary>
    public partial class VatLi : Window
    {
        public VatLi()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            choncongcu.Visibility = Visibility.Hidden;
            textketqua.Visibility = Visibility.Visible;
            textthoigian.Visibility = Visibility.Visible;
            textquangduong.Visibility = Visibility.Visible;
            quangduong.Visibility = Visibility.Visible;
            thoigian.Visibility = Visibility.Visible;
            nuttinhtoan.Visibility = Visibility.Visible;
            ketqua.Visibility = Visibility.Visible;
            ketquaarchimede.Visibility = Visibility.Hidden;
            ketquatinharchimede.Visibility = Visibility.Hidden;
            bemat.Visibility = Visibility.Hidden;
            thetich.Visibility = Visibility.Hidden;
            nuttinhtoan2.Visibility = Visibility.Hidden;
            textbemat.Visibility = Visibility.Hidden;
            textthetich.Visibility = Visibility.Hidden;
            luctacdungtext.Visibility = Visibility.Hidden;
            luctacdung.Visibility = Visibility.Hidden;
            dichchuyentext.Visibility = Visibility.Hidden;
            quangduongdiduoc.Visibility = Visibility.Hidden;
            ketquacongcohoc.Visibility = Visibility.Hidden;
            ketquacong.Visibility = Visibility.Hidden;
            nuttinhtoan3.Visibility = Visibility.Hidden;
        }
        private void nuttinhtoan_Click(object sender, RoutedEventArgs e)
        {

            string a = quangduong.Text;
            string b = thoigian.Text;
            switch (a)
            {
                case "VD: 30":
                    MessageBox.Show("Bạn chưa nhập dữ liệu quãng đường");
                    break;
                case "":
                    MessageBox.Show("Bạn chưa nhập dữ liệu quãng đường");
                    break;
                default:
                    string bienquangduong = quangduong.Text;
                    decimal bientinh1 = Convert.ToDecimal(bienquangduong);
                    string bienthoigian = thoigian.Text;
                    decimal bientinh2 = Convert.ToDecimal(bienthoigian);
                    decimal bientinh3 = bientinh1 / bientinh2;
                    string biendem = Convert.ToString(bientinh3);
                    ketqua.Text = biendem;
                    break;
            }
            switch (b)
            {
                case "VD: 0.5":
                    MessageBox.Show("Bạn chưa nhập dữ liệu thời gian");
                    break;
                case "":
                    MessageBox.Show("Bạn chưa nhập dữ liệu thời gian");
                    break;
                default:
                    string bienquangduong = quangduong.Text;
                    decimal bientinh1 = Convert.ToDecimal(bienquangduong);
                    string bienthoigian = thoigian.Text;
                    decimal bientinh2 = Convert.ToDecimal(bienthoigian);
                    decimal bientinh3 = bientinh1 / bientinh2;
                    string biendem = Convert.ToString(bientinh3);
                    ketqua.Text = biendem;
                    break;
            }
        }

        private void quangduong_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            quangduong.Text = "";
        }

        private void thoigian_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            thoigian.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            choncongcu.Visibility = Visibility.Hidden;
            textketqua.Visibility = Visibility.Hidden;
            textthoigian.Visibility = Visibility.Hidden;
            textquangduong.Visibility = Visibility.Hidden;
            quangduong.Visibility = Visibility.Hidden;
            thoigian.Visibility = Visibility.Hidden;
            nuttinhtoan.Visibility = Visibility.Hidden;
            ketqua.Visibility = Visibility.Hidden;
            ketquaarchimede.Visibility = Visibility.Visible;
            ketquatinharchimede.Visibility = Visibility.Visible;
            bemat.Visibility = Visibility.Visible;
            thetich.Visibility = Visibility.Visible;
            nuttinhtoan2.Visibility = Visibility.Visible;
            textbemat.Visibility = Visibility.Visible;
            textthetich.Visibility = Visibility.Visible;
            luctacdungtext.Visibility = Visibility.Hidden;
            luctacdung.Visibility = Visibility.Hidden;
            dichchuyentext.Visibility = Visibility.Hidden;
            quangduongdiduoc.Visibility = Visibility.Hidden;
            ketquacongcohoc.Visibility = Visibility.Hidden;
            ketquacong.Visibility = Visibility.Hidden;
            nuttinhtoan3.Visibility = Visibility.Hidden;
        }

        private void nuttinhtoan2_Click(object sender, RoutedEventArgs e)
        {
            
            string a = thetich.Text;
            string b = bemat.Text;
            switch(a)
            {
                case "VD: 0.25":
                    MessageBox.Show("Bạn chưa nhập dữ liệu thể tích");
                    break;
                case "":
                    MessageBox.Show("Bạn chưa nhập dữ liệu thể tích");
                    break;
                default:
                    string bientlr = bemat.Text;
                    decimal bientinh1 = Convert.ToDecimal(bientlr);
                    string bienthetich = thetich.Text;
                    decimal bientinh2 = Convert.ToDecimal(bienthetich);
                    decimal bientinh3 = bientinh1 * bientinh2;
                    string biendem = Convert.ToString(bientinh3);
                    ketquaarchimede.Text = biendem;
                    break;
            }
            switch (b)
            {
                case "VD: 10000":
                    MessageBox.Show("Bạn chưa nhập dữ liệu trọng lượng riêng");
                    break;
                case "":
                    MessageBox.Show("Bạn chưa nhập dữ liệu trọng lượng riêng");
                    break;
                default:
                    string bientlr = bemat.Text;
                    decimal bientinh1 = Convert.ToDecimal(bientlr);
                    string bienthetich = thetich.Text;
                    decimal bientinh2 = Convert.ToDecimal(bienthetich);
                    decimal bientinh3 = bientinh1 * bientinh2;
                    string biendem = Convert.ToString(bientinh3);
                    ketquaarchimede.Text = biendem;
                    break;
            }

        }

        private void bemat_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            bemat.Text = "";
        }

        private void thetich_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            thetich.Text = "";
        }

        private void nuttinhtoan3_Click(object sender, RoutedEventArgs e)
        {
            string a=luctacdung.Text;
            string b = quangduongdiduoc.Text;
            switch (a)
            {
                case "VD: 1000":
                    MessageBox.Show("Bạn chưa nhập dữ liệu lực tác dụng");
                    break;
                case "":
                    MessageBox.Show("Bạn chưa nhập dữ liệu lực tác dụng");
                    break;
                default:
                    string bienluctd = luctacdung.Text;
                    decimal bientinh1 = Convert.ToDecimal(bienluctd);
                    string biendichchuyen = quangduongdiduoc.Text;
                    decimal bientinh2 = Convert.ToDecimal(biendichchuyen);
                    decimal bientinh3 = bientinh1 * bientinh2;
                    string biendem = Convert.ToString(bientinh3);
                    ketquacongcohoc.Text = biendem;
                    break;
            }
            switch (b)
            {
                case "VD: 500":
                    MessageBox.Show("Bạn chưa nhập dữ liệu quãng đường vật dịch chuyển");
                    break;
                case "":
                    MessageBox.Show("Bạn chưa nhập dữ liệu quãng đường vật dịch chuyển");
                    break;
                default:
                    string bienluctd = luctacdung.Text;
                    decimal bientinh1 = Convert.ToDecimal(bienluctd);
                    string biendichchuyen = quangduongdiduoc.Text;
                    decimal bientinh2 = Convert.ToDecimal(biendichchuyen);
                    decimal bientinh3 = bientinh1 * bientinh2;
                    string biendem = Convert.ToString(bientinh3);
                    ketquacongcohoc.Text = biendem;
                    break;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            choncongcu.Visibility = Visibility.Hidden;
            textketqua.Visibility = Visibility.Hidden;
            textthoigian.Visibility = Visibility.Hidden;
            textquangduong.Visibility = Visibility.Hidden;
            quangduong.Visibility = Visibility.Hidden;
            thoigian.Visibility = Visibility.Hidden;
            nuttinhtoan.Visibility = Visibility.Hidden;
            ketqua.Visibility = Visibility.Hidden;
            ketquaarchimede.Visibility = Visibility.Hidden;
            ketquatinharchimede.Visibility = Visibility.Hidden;
            bemat.Visibility = Visibility.Hidden;
            thetich.Visibility = Visibility.Hidden;
            nuttinhtoan2.Visibility = Visibility.Hidden;
            textbemat.Visibility = Visibility.Hidden;
            textthetich.Visibility = Visibility.Hidden;
            luctacdungtext.Visibility = Visibility.Visible;
            luctacdung.Visibility = Visibility.Visible;
            dichchuyentext.Visibility = Visibility.Visible;
            quangduongdiduoc.Visibility = Visibility.Visible;
            ketquacongcohoc.Visibility = Visibility.Visible;
            ketquacong.Visibility = Visibility.Visible;
            nuttinhtoan3.Visibility = Visibility.Visible;
        }

        private void luctacdung_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            luctacdung.Text = "";
        }

        private void quangduongdiduoc_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            quangduongdiduoc.Text = "";
        }
    }
}
