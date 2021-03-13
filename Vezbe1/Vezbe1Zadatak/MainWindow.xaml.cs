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

namespace Vezbe1Zadatak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Color Color = Colors.Red;

        public MainWindow()
        {
            InitializeComponent();
            lblText.Foreground = new SolidColorBrush(Color);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblText.Content = txtBox1.Text;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void changeColor_Click(object sender, RoutedEventArgs e)
        {
            ChangeColor colorWindow = new ChangeColor();
            colorWindow.ShowDialog();
            lblText.Foreground = new SolidColorBrush(Color);
        }
    }
}