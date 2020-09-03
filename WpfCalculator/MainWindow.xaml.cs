using System;
using System.Windows;

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
        double sum = 0;
        bool isAddition = false;
        bool isSubtraction = false;
        bool isMultiplication = false;
        bool isDivision = false;
        double result = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Click_Zero(object sender, RoutedEventArgs e)
        {
           
            textBox.Text += zero;
          
        }
        private void Click_One(object sender, RoutedEventArgs e)
        {
            
            textBox.Text += one;
        

        }
        private void Click_Two(object sender, RoutedEventArgs e)
        {
            textBox.Text += two;
        }
        private void Click_Three(object sender, RoutedEventArgs e)
        {
            textBox.Text += three;
         

        }
        private void Click_Four(object sender, RoutedEventArgs e)
        {
            textBox.Text += four;
          

        }
        private void Click_Five(object sender, RoutedEventArgs e)
        {
            textBox.Text += five;
            

        }
        private void Click_Six(object sender, RoutedEventArgs e)
        {
            textBox.Text += six;
          
        }
        private void Click_Seven(object sender, RoutedEventArgs e)
        {
            textBox.Text += seven;

        }
        private void Click_Eight(object sender, RoutedEventArgs e)
        {
            textBox.Text += eight;

        }

        private void Click_Nine(object sender, RoutedEventArgs e)
        {
            textBox.Text += nine;

        }
        private void Click_add(object sender, RoutedEventArgs e)
        {
            sum += Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            isAddition = true;
        } 
        private void Click_Sub(object sender, RoutedEventArgs e)
        {
            sum += Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            isSubtraction = true;
        }
        private void Click_Mul(object sender, RoutedEventArgs e)
        {
            sum += Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            isMultiplication = true;
        }
        private void Click_Div(object sender, RoutedEventArgs e)
        {
            sum += Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            isDivision = true;
        }
        private void Click_Equal(object sender, RoutedEventArgs e)
        {


            if (isAddition == true)
            {
                sum += Convert.ToDouble(textBox.Text);
                
            }
            else if (isSubtraction == true)
            {
                sum -= Convert.ToDouble(textBox.Text);
            }
            else if (isMultiplication == true)
            {
                sum *= Convert.ToDouble(textBox.Text);

            }
            else if (isDivision == true)
            {
                sum /= Convert.ToDouble(textBox.Text);

            }
            result = sum;
            textBox.Text = result.ToString();
            sum = 0;
            

        }
        private void Click_Del(object sender, RoutedEventArgs e)
        {
            sum = 0;
            textBox.Text = "";
        }
    }
}
