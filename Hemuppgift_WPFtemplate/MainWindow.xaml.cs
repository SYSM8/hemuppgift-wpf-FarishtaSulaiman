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
            GridWindow windowGrid = new GridWindow();
            windowGrid.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
           
            StackPanel windowStackPanel = new StackPanel();
            windowStackPanel.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            
            WrapPanel windowWrapPanel = new WrapPanel();
            windowWrapPanel.Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {

            DockPanel windowDockPanel = new DockPanel();
            windowDockPanel.Show();
        }
    }
}