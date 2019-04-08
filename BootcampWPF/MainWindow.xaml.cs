using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace BootcampWPF
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

        private void Process_Btn_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("^$");
            int first, second, result;

            if (!regex.IsMatch(FirstNumber_Txt.Text))
            {
                first = Convert.ToInt32(FirstNumber_Txt.Text);
            }
            else
            {
                FirstNumber_Txt.Text = "0";
                first = 0;
            }

            if (!regex.IsMatch(SecondNumber_Txt.Text))
            {
                second = Convert.ToInt32(SecondNumber_Txt.Text);
            }
            else
            {
                SecondNumber_Txt.Text = "0";
                second = 0;
            }

            result = first * second;
            Result_TxtBlock.Text = result.ToString();
        }
        private void Number_Txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }
    }
}
