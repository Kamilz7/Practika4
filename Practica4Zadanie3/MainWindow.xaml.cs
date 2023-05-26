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

namespace Practica4Zadanie3
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
            int NumberElements = Convert.ToInt32(textBoxNumber.Text);
            double a = Convert.ToDouble(textBoxA.Text);
            double c = 0;
            double h = 0;
            double S = 0;
            c = a * Math.Sqrt(2);
            h = c / 2;
            S = c * h / 2;


            switch (NumberElements)
            {
                case 1:

                    Result.Content = $"a = {a:f2}";
                    break;
                case 2:

                    Result2.Content = $"c = {c:f2}";

                    break;
                case 3:
                    Result3.Content = $"h = {h:f2}";
                    break;
                case 4:

                    Result4.Content = $"S = {S}";
                    break;

            }
        }
    }
}
    

