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
using System.Data;

namespace SimpleCalculator
{
    public partial class MainWindow : Window
    {
        private double result;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                MainText.Text += button.Content;
            }
        }

        private void Button_Click_calculate(object sender, RoutedEventArgs e)
        {
            bool error = false;
            foreach(char character in MainText.Text)
            {
                if (Char.IsDigit(character) || character == '+' || character == '-' || character == '*' || character == '/') continue;
                else error = true;
            }
            if (error) Answer.Text = "Недопустимый символ";
            else
            {
                result = Convert.ToDouble(new DataTable().Compute(MainText.Text, ""));
                Answer.Text = Convert.ToString(result);
            }
        }
    }
}
