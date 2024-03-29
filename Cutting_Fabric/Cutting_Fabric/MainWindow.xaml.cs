﻿using System;
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

namespace Cutting_Fabric
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
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double rollLength = double.Parse(rollLengthTextBox.Text);
                double rollWidth = double.Parse(rollWidthTextBox.Text);
                double productArea = double.Parse(productAreaTextBox.Text);
                double totalArea = rollLength * rollWidth * 100;
                int numberOfProducts = (int)(totalArea / productArea);
                resultTextBlock.Text = numberOfProducts.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число!", "Ошибка!");
            }
        }
    }
}
