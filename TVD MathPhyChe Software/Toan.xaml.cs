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
using System.Windows.Media.Animation;

namespace TVD_MathPhyChe_Software
{
    /// <summary>
    /// Interaction logic for Toan.xaml
    /// </summary>
    public partial class Toan : Window
    {
        public Toan()
        {
            InitializeComponent();
            onhapsomaytinh.MaxLength = 14;
            if (onhapsomaytinh.MaxLength>14)
            {
                onhapsomaytinh.FontSize = 30;
            }
            onhapsomaytinh.MaxLines = 1;
            string bienchuyendoi = onhapsomaytinh.Text;
            for (int i = 0; i < bienchuyendoi.Length; i++) ;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            choncongcu.Visibility = Visibility.Hidden;
            onhapsomaytinh.Visibility = Visibility.Visible;
            nutso1.Visibility = Visibility.Visible;
            nutso2.Visibility = Visibility.Visible;
            nutso3.Visibility = Visibility.Visible;
            nutso4.Visibility = Visibility.Visible;
            nutso5.Visibility = Visibility.Visible;
            nutso6.Visibility = Visibility.Visible;
            nutso7.Visibility = Visibility.Visible;
            nutso8.Visibility = Visibility.Visible;
            nutso9.Visibility = Visibility.Visible;
            nutso0.Visibility = Visibility.Visible;
            nutdaubang.Visibility = Visibility.Visible;
            nutdaucong.Visibility = Visibility.Visible;
            nutdauchia.Visibility = Visibility.Visible;
            nutdaunhan.Visibility = Visibility.Visible;
            nutdautru.Visibility = Visibility.Visible;
            nhapvao.Visibility = Visibility.Visible;
            nhapvao2.Visibility = Visibility.Visible;
            nutdaucham.Visibility = Visibility.Visible;
            labelimg.Visibility = Visibility.Visible;
            backg.Visibility = Visibility.Visible;
            nutdel.Visibility = Visibility.Visible;
            nutxoa.Visibility = Visibility.Visible;
            nuttieptheo.Visibility = Visibility.Visible;
    }
        //Xuất hiện giao diện máy tính giao diện Flat Design
        
        private void nutso1_Click(object sender, RoutedEventArgs e)
        {
            string themgtvaobien = "1";
            string giatridem = onhapsomaytinh.Text;
            giatridem += themgtvaobien;

            onhapsomaytinh.Text = giatridem;

        }
        //Hành động khi user nhấn vào nút số 1
        private int Tinhtoan()
        {
            int nhapvaomaytinh = 0;
            int onhapsomaytinh = nhapvaomaytinh;
            return 0;
        }

        public void nutdaucong_Click(object sender, RoutedEventArgs e)
        {
            string textvar = onhapsomaytinh.Text;
            nhapvao.Text=textvar;
            onhapsomaytinh.Text = "";
            labelimg.Text = "+";
        }

        private void nutso2_Click(object sender, RoutedEventArgs e)
        {
            string themgtvaobien = "2";
            string giatridem = onhapsomaytinh.Text;
            giatridem += themgtvaobien;

            onhapsomaytinh.Text = giatridem;

        }

        private void nutso3_Click(object sender, RoutedEventArgs e)
        {
            string themgtvaobien = "3";
            string giatridem = onhapsomaytinh.Text;
            giatridem += themgtvaobien;

            onhapsomaytinh.Text = giatridem;

        }

        private void nutso4_Click(object sender, RoutedEventArgs e)
        {
            string themgtvaobien = "4";
            string giatridem = onhapsomaytinh.Text;
            giatridem += themgtvaobien;

            onhapsomaytinh.Text = giatridem;

        }

        private void nutso5_Click(object sender, RoutedEventArgs e)
        {
            string themgtvaobien = "5";
            string giatridem = onhapsomaytinh.Text;
            giatridem += themgtvaobien;

            onhapsomaytinh.Text = giatridem; 
           
        }

        private void nutso6_Click(object sender, RoutedEventArgs e)
        {
            string themgtvaobien = "6";
            string giatridem = onhapsomaytinh.Text;
            giatridem += themgtvaobien;

            onhapsomaytinh.Text = giatridem;

        }

        private void nutso7_Click(object sender, RoutedEventArgs e)
        {
            string themgtvaobien = "7";
            string giatridem = onhapsomaytinh.Text;
            giatridem += themgtvaobien;

            onhapsomaytinh.Text = giatridem;

        }

        private void nutso8_Click(object sender, RoutedEventArgs e)
        {
            string themgtvaobien = "8";
            string giatridem = onhapsomaytinh.Text;
            giatridem += themgtvaobien;

            onhapsomaytinh.Text = giatridem;

        }

        private void nutso9_Click(object sender, RoutedEventArgs e)
        {
            string themgtvaobien = "9";
            string giatridem = onhapsomaytinh.Text;
            giatridem += themgtvaobien;

            onhapsomaytinh.Text = giatridem;

        }

        private void nutso0_Click(object sender, RoutedEventArgs e)
        {
            string themgtvaobien = "0";
            string giatridem = onhapsomaytinh.Text;
            giatridem += themgtvaobien;

            onhapsomaytinh.Text = giatridem;

        }

        private void nutdaucham_Click(object sender, RoutedEventArgs e)
        {
            string themgtvaobien = ".";
            string giatridem = onhapsomaytinh.Text;
            giatridem += themgtvaobien;

            onhapsomaytinh.Text = giatridem;
        }

        private void nutdaubang_Click(object sender, RoutedEventArgs e)
        {
            string textvar = nhapvao.Text;
            string text = onhapsomaytinh.Text;
            decimal textvar2 = Convert.ToDecimal(text);
            decimal textvarde = Convert.ToDecimal(textvar);

            nhapvao2.Text = text;
            
            string daulabel = labelimg.Text;
            switch (daulabel)
            {
                case "+":
                    {

                        decimal bientinh = textvar2 + textvarde;
                        string kw = Convert.ToString(bientinh);
                        onhapsomaytinh.Text = kw;
                        break;
                    }
                case "-":
                    {

                        decimal bientinh = textvar2 - textvarde;
                        string kw = Convert.ToString(bientinh);
                        onhapsomaytinh.Text = kw;
                        break;
                    }
                case "*":
                    {
                        decimal bientinh = textvar2 * textvarde;
                        string kw = Convert.ToString(bientinh);
                        onhapsomaytinh.Text = kw;
                        break;
                    }
                case "÷":
                    {
                        decimal bientinh = textvar2 / textvarde;
                        string kw = Convert.ToString(bientinh);
                        onhapsomaytinh.Text = kw;
                        break;
                    }
                default:
                    {
                        onhapsomaytinh.Text = "Bạn chưa chọn phép tính";
                        break;
                    }
            }
        }

        private void nutxoa_Click(object sender, RoutedEventArgs e)
        {
            onhapsomaytinh.Text = "";
            nhapvao2.Text = "";
            nhapvao.Text = "";
            labelimg.Text = "";
        }

        private void nutdautru_Click(object sender, RoutedEventArgs e)
        {
            string textvar = onhapsomaytinh.Text;
            switch(textvar)
            {
                case "":
                    onhapsomaytinh.Text += "-";
                    break;
                default:
                    nhapvao.Text = textvar;
                    onhapsomaytinh.Text = "";
                    labelimg.Text = "-";
                    break;
            }

        }

        private void nutdaunhan_Click(object sender, RoutedEventArgs e)
        {
            string textvar = onhapsomaytinh.Text;
            nhapvao.Text = textvar;
            onhapsomaytinh.Text = "";
            labelimg.Text = "*";
        }

        private void nutdauchia_Click(object sender, RoutedEventArgs e)
        {
            string textvar = onhapsomaytinh.Text;
            nhapvao.Text = textvar;
            onhapsomaytinh.Text = "";
            labelimg.Text = "÷";
        }
        
        private void nutdel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nuttieptheo_Click(object sender, RoutedEventArgs e)
        {
            nutdaumongoac.Visibility = Visibility.Visible;
            nuttan.Visibility = Visibility.Visible;
            nutsin.Visibility = Visibility.Visible;
            nutcos.Visibility = Visibility.Visible;
            nutdongngoac.Visibility = Visibility.Visible;
            nutln.Visibility = Visibility.Visible;
            nutghi.Visibility = Visibility.Visible;
            nutcanbac.Visibility = Visibility.Visible;
            nutdaumu.Visibility = Visibility.Visible;
            nute.Visibility = Visibility.Visible;
            nutdaucong_Copy.Visibility = Visibility.Visible;
            nutdautru_Copy.Visibility = Visibility.Visible;
            nutdaunhan_Copy.Visibility = Visibility.Visible;
            nutdauchia_Copy.Visibility = Visibility.Visible;
            nutdaucham_Copy.Visibility = Visibility.Visible;
            nutso1.Visibility = Visibility.Hidden;
            nutso2.Visibility = Visibility.Hidden;
            nutso3.Visibility = Visibility.Hidden;
            nutso4.Visibility = Visibility.Hidden;
            nutso5.Visibility = Visibility.Hidden;
            nutso6.Visibility = Visibility.Hidden;
            nutso7.Visibility = Visibility.Hidden;
            nutso8.Visibility = Visibility.Hidden;
            nutso9.Visibility = Visibility.Hidden;
            nutso0.Visibility = Visibility.Hidden;
            nutdaubang.Visibility = Visibility.Visible;
            nutdaucong.Visibility = Visibility.Hidden;
            nutdauchia.Visibility = Visibility.Hidden;
            nutdaunhan.Visibility = Visibility.Hidden;
            nutdautru.Visibility = Visibility.Hidden;
            nhapvao.Visibility = Visibility.Visible;
            nhapvao2.Visibility = Visibility.Visible;
            nutdaucham.Visibility = Visibility.Hidden;
            nuttieptheo.Visibility = Visibility.Hidden;
            nuttrolai.Visibility = Visibility.Visible;
        }

        private void nutdaumongoac_Click(object sender, RoutedEventArgs e)
        {
            string dataval = "(";
            onhapsomaytinh.Text += dataval;
        }

        private void nutdongngoac_Click(object sender, RoutedEventArgs e)
        {
            string dataval = ")";
            onhapsomaytinh.Text += dataval;
        }

        private void nutcanbac_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nutdaumu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nutsin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nutcos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nuttan_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nute_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nutghi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nutln_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nuttrolai_Click(object sender, RoutedEventArgs e)
        {
            nutdaumongoac.Visibility = Visibility.Hidden;
            nuttan.Visibility = Visibility.Hidden;
            nutsin.Visibility = Visibility.Hidden;
            nutcos.Visibility = Visibility.Hidden;
            nutdongngoac.Visibility = Visibility.Hidden;
            nutln.Visibility = Visibility.Hidden;
            nutghi.Visibility = Visibility.Hidden;
            nutcanbac.Visibility = Visibility.Hidden;
            nutdaumu.Visibility = Visibility.Hidden;
            nute.Visibility = Visibility.Hidden;
            nutdaucong_Copy.Visibility = Visibility.Hidden;
            nutdautru_Copy.Visibility = Visibility.Hidden;
            nutdaunhan_Copy.Visibility = Visibility.Hidden;
            nutdauchia_Copy.Visibility = Visibility.Hidden;
            nutdaucham_Copy.Visibility = Visibility.Hidden;
            nutso1.Visibility = Visibility.Visible;
            nutso2.Visibility = Visibility.Visible;
            nutso3.Visibility = Visibility.Visible;
            nutso4.Visibility = Visibility.Visible;
            nutso5.Visibility = Visibility.Visible;
            nutso6.Visibility = Visibility.Visible;
            nutso7.Visibility = Visibility.Visible;
            nutso8.Visibility = Visibility.Visible;
            nutso9.Visibility = Visibility.Visible;
            nutso0.Visibility = Visibility.Visible;
            nutdaubang.Visibility = Visibility.Visible;
            nutdaucong.Visibility = Visibility.Visible;
            nutdauchia.Visibility = Visibility.Visible;
            nutdaunhan.Visibility = Visibility.Visible;
            nutdautru.Visibility = Visibility.Visible;
            nhapvao.Visibility = Visibility.Visible;
            nhapvao2.Visibility = Visibility.Visible;
            nutdaucham.Visibility = Visibility.Visible;
            nuttieptheo.Visibility = Visibility.Visible;
            nuttrolai.Visibility = Visibility.Hidden;
        }



        }
    }

