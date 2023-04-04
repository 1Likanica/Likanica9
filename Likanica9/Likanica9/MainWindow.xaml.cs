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

namespace Likanica9
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

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double X = double.Parse(textbox1.Text);
            double Y = double.Parse(textbox2.Text);
            int N = int.Parse(textbox3.Text);
            int K = int.Parse(textbox4.Text);
            double z = 0;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    z += (i * Math.Pow(X, 2 * i) + j * Math.Pow(Y, 2 * j)) / (Math.Pow(i, 2) * Math.Pow(j, 2));
                }
            }
            textbox5.Text = z.ToString();

        }
    }
}
