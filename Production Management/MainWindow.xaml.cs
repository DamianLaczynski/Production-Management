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

namespace Production_Management
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

        private void signInPageButton_Click(object sender, RoutedEventArgs e)
        {
            signOrRegisterFrame.Content = new SignInPage();

            GradientStopCollection gradientStops = new GradientStopCollection();
            gradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FF5EB3B9"), 1));
            gradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FF0815DE"), 0));
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
            linearGradientBrush.StartPoint = new Point(0.5, 0);
            linearGradientBrush.EndPoint = new Point(0.5, 1);
            linearGradientBrush.GradientStops = gradientStops;
            registerPageButton.Background = new SolidColorBrush((Color)Colors.Transparent);
            signInPageButton.Background = linearGradientBrush;
        }

        private void registerPageButton_Click(object sender, RoutedEventArgs e)
        {
            signOrRegisterFrame.Content = new RegisterPage();

            GradientStopCollection gradientStops = new GradientStopCollection();
            gradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FF5EB3B9"), 1));
            gradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FF0815DE"), 0));
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
            linearGradientBrush.StartPoint = new Point(0.5, 0);
            linearGradientBrush.EndPoint = new Point(0.5, 1);
            linearGradientBrush.GradientStops = gradientStops;
            registerPageButton.Background = linearGradientBrush;
            signInPageButton.Background = new SolidColorBrush((Color)Colors.Transparent);
        }
    }
}
