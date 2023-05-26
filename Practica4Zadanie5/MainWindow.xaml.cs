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

namespace Practica4Zadanie5
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

        private void OnCalculateButtonClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(initialDistanceTextBox.Text, out double initialDistance) &&
                double.TryParse(percentIncreaseTextBox.Text, out double percentIncrease) &&
                percentIncrease > 0 && percentIncrease < 50)
            {
                double distance = initialDistance;
                double totalDistance = initialDistance;
                int day = 1;
                while (totalDistance < 200)
                {
                    distance *= 1 + percentIncrease / 100;
                    totalDistance += distance;
                    day++;
                }
                MessageBox.Show($"Количество дней: {day}, суммарный пробег: {totalDistance:F1} км");
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
        }
    }
}