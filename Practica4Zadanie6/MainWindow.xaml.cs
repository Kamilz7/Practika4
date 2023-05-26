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

namespace Practica4Zadanie6
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

        private void OnCheckButtonClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(textBoxA.Text, out int number))

            {
                bool containsTwo = false;
                while (number > 0)
                {
                    int digit = number % 10;
                    if (digit == 2)
                    {
                        containsTwo = true;
                        break;
                    }
                    number /= 10;
                }
                Result.Content = containsTwo ? "true" : "false";
            }
            else
            {
                Result.Content = "Некорректный ввод";
            }
        }
    }
}