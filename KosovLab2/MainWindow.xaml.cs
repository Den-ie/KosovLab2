using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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
using Lib_4;
using LibArray;

namespace KosovLab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Косов Даниил ИСП-34 \nПрактическая №2 \nВычислить для чисел > 0 функцию x . Результат обработки каждого числа вывести на экран.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        Array<double> _array;

        private void CreateArray(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(ArraySize.Text, out int count))
            {
                MessageBox.Show("Неверный размер массива", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (count <= 0)
            {
                MessageBox.Show("Размер массива должен быть больше 0", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            _array = new Array<double>(count);
            _array.Init();

            Table.ItemsSource = _array.ToDataTable().DefaultView;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            string[] massiveString = AddingMas.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            double[] numbers = new double[massiveString.Length];

            for (int i = 0; i < massiveString.Length; i++)
            {
                int.TryParse(massiveString[i], out int value);
                numbers[i] = value;
            }

            _array.AddRange(numbers);
            Table.ItemsSource = _array.ToDataTable().DefaultView;
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            _array.Clear();
            Table.ItemsSource = null;
        }

        private void DeleteElem(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Removing.Text, out int item))
            {
                if(_array.Remove(item))
                {
                Table.ItemsSource = _array.ToDataTable().DefaultView;
                }
                else MessageBox.Show("Такого элемента нет");
            }
            else MessageBox.Show("Некорректные значения");

        }
    }
}
