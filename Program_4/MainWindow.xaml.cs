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

namespace Program_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateDol.Text);
            double sumDollar = Convert.ToDouble(sumDol.Text);
            double resDollar = rateDollar * sumDollar;
            resSumDol.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateEu.Text);
            double sumEuro = Convert.ToDouble(sumEu.Text);
            double resEuro = rateEuro * sumEuro;
            resSumEu.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double ratePound = Convert.ToDouble(rateGBP.Text);
            double sumPound = Convert.ToDouble(sumGBP.Text);
            double resPound = ratePound * sumPound;
            resSumGBP.Text = resPound.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateYuan = Convert.ToDouble(rateCNY.Text);
            double sumYuan = Convert.ToDouble(sumCNY.Text);
            double resYuan = rateYuan * sumYuan;
            resSumCNY.Text = resYuan.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {            
            double rateInch = Convert.ToDouble(rateIn.Text);
            double resInch = 2.54 * rateInch;
            resSumIn.Text = resInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateFeet = Convert.ToDouble(rateFt.Text);
            double resFeet = 30.48 * rateFeet;
            resSumFt.Text = resFeet.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateMile = Convert.ToDouble(rateMi.Text);
            double resMile = 1610 * rateMile;
            resSumMi.Text = resMile.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rateVr.Text);
            double resVerst = 1066.8 * rateVerst;
            resSumVr.Text = resVerst.ToString();
        }
    }
}
