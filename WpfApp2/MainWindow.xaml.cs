using System;
using System.Collections;
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

namespace WpfApp2
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
       

        private void acBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultLbl.Content = "0";


        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if(ResultLbl.Content.ToString()== "0")
            {
                ResultLbl.Content = "7";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}7";
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "8";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}8";
            }
        }

        int check = 1;
        private void minus_Click(object sender, RoutedEventArgs e)
        {
            

            




            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "-";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}-";
            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "6";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}6";
            }

        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "1";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}1";
            }

        }

        private void two_Click(object sender, RoutedEventArgs e)
        {

            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "2";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}2";
            }

        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "3";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}3";
            }

        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {

            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "+";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}+";
            }
        }

        private void null_Click(object sender, RoutedEventArgs e)
        {
            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "0";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}0";
            }

        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = ".";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}.";
            }

        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void asterisk_Click(object sender, RoutedEventArgs e)
        {
            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "*";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}*";
            }

        }

        private void five_Click(object sender, RoutedEventArgs e)
        {

            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "5";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}5";
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "9";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}9";
            }

        }

       

        private void percent_Click(object sender, RoutedEventArgs e)
        {

            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "%";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}%";
            }
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {

            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "/";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}/";
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (ResultLbl.Content.ToString() == "0")
            {
                ResultLbl.Content = "4";
            }
            else
            {
                ResultLbl.Content = $"{ResultLbl.Content}4";
            }
        }
    }
}
