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

namespace SimpleCalculator
{
    public partial class MainWindow : Window
    {
        private int[] a = new int[10];
        private char[] b = new char[10];
        private int c = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Digit_Input(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                MainText.Text += button.Content;
                a[c] *= 10;
                a[c] += Convert.ToInt32(button.Content);
            }
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
