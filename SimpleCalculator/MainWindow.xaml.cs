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

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        int[] a = new int[10];
        char[] b = new char[10];
        int c = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainText.Text += "1";
            a[c] *= 10;
            a[c] += 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainText.Text += "2";
            a[c] *= 10;
            a[c] += 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainText.Text += "3";
            a[c] *= 10;
            a[c] += 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainText.Text += "4";
            a[c] *= 10;
            a[c] += 4;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainText.Text += "5";
            a[c] *= 10;
            a[c] += 5;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MainText.Text += "6";
            a[c] *= 10;
            a[c] += 6;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MainText.Text += "7";
            a[c] *= 10;
            a[c] += 7;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainText.Text += "8";
            a[c] *= 10;
            a[c] += 8;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MainText.Text += "9";
            a[c] *= 10;
            a[c] += 9;
        }

        private void Button_Click_plus(object sender, RoutedEventArgs e)
        {
            MainText.Text += "+";
            b[c] = '+';
            c++;
        }

        private void Button_Click_minus(object sender, RoutedEventArgs e)
        {
            MainText.Text += "-";
            b[c] = '-';
            c++;
        }

        private void Button_Click_multiply(object sender, RoutedEventArgs e)
        {
            MainText.Text += "*";
            b[c] = '*';
            c++;
        }

        private void Button_Click_divide(object sender, RoutedEventArgs e)
        {
            MainText.Text += "/";
            b[c] = '/';
            c++;
        }

        private void Button_Click_calculate(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < c; ++i)
            {
                switch (b[i])
                {
                    case '+':
                        a[i + 1] = a[i] + a[i + 1];
                        break;
                    case '-':
                        a[i + 1] = a[i] - a[i + 1];
                        break;
                    case '*':
                        a[i + 1] = a[i] * a[i + 1];
                        break;
                    case '/':
                        a[i + 1] = a[i] / a[i + 1];
                        break;
                }
            }
            Answer.Text = Convert.ToString(a[c]);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Answer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
