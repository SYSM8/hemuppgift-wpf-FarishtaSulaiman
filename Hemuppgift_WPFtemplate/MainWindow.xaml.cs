using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Window windowGrid = new Window();
            windowGrid.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
           Window windowStackPanel = new Window();   
            windowStackPanel.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Window windowWrapPanel = new Window();  
            windowWrapPanel.Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Window windowDockPanel = new Window();  
            windowDockPanel.Show();
        }
    }
}