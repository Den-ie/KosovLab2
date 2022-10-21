﻿using System;
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

        private void CreateArray(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(ArraySize.Text);

            Array<double> array = new Array<double>(x);

            for (int i = 0; i < x; i++)
            {
                array.Add(i);
            }

            answer.Text = string.Join(" ", array.ToArray());
        }
    }
}
