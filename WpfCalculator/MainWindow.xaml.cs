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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string zero = "0";
        string one = "1";
        string two = "2";
        string three = "3";
        string four = "4";
        string five = "5";
        string six = "6";
        string seven = "7";
        string eight = "8";
        string nine = "9";
        int sum = 0;
        bool isAddition = false;
       
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Click_Zero(object sender, RoutedEventArgs e)
        {
            textBox.Text += zero;
            sum += Convert.ToInt32(textBox.Text);


        }
        private void Click_One(object sender, RoutedEventArgs e)
        {

            textBox.Text += one;
            sum += Convert.ToInt32(textBox.Text);

        }
        private void Click_Two(object sender, RoutedEventArgs e)
        {
            textBox.Text += two;
            sum += Convert.ToInt32(textBox.Text);
        }
        private void Click_Three(object sender, RoutedEventArgs e)
        {
            textBox.Text += three;
            sum += Convert.ToInt32(textBox.Text);



        }
        private void Click_Four(object sender, RoutedEventArgs e)
        {
            textBox.Text += four;
            sum += Convert.ToInt32(textBox.Text);

        }
        private void Click_Five(object sender, RoutedEventArgs e)
        {
            textBox.Text += five;
            sum += Convert.ToInt32(textBox.Text);

        }
        private void Click_Six(object sender, RoutedEventArgs e)
        {
            textBox.Text += six;
            sum += Convert.ToInt32(textBox.Text);
        }
        private void Click_Seven(object sender, RoutedEventArgs e)
        {
            textBox.Text += seven;
            sum += Convert.ToInt32(textBox.Text);

        }
        private void Click_Eight(object sender, RoutedEventArgs e)
        {
            textBox.Text += eight;
            sum += Convert.ToInt32(textBox.Text);

        }

        private void Click_Nine(object sender, RoutedEventArgs e)
        {
            textBox.Text += nine;
            sum += Convert.ToInt32(textBox.Text);

        }
        private void Click_add(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            isAddition = true;
        }
        private void Click_Equal(object sender, RoutedEventArgs e)
        {

            textBox.Text = sum.ToString();
            //sum = 0;
        }
    }
}
