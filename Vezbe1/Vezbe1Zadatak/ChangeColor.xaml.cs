using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vezbe1Zadatak
{
    /// <summary>
    /// Interaction logic for ChangeColor.xaml
    /// </summary>
    public partial class ChangeColor : Window
    {
        public ChangeColor()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }

        private void cmbColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(cmbColors.SelectedItem as PropertyInfo).GetValue(1, null);
            MainWindow.Color = selectedColor;
        }
    }
}