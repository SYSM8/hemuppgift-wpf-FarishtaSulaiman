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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for WrapPanel.xaml
    /// </summary>
    public partial class WrapPanel : Window
    {
        public WrapPanel()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (btn3.IsChecked == true)
            {
                EllipsePanel.Orientation = Orientation.Horizontal;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (btn4.IsChecked == true)
            {
                EllipsePanel.Orientation = Orientation.Vertical;
            }
        }
        

    }
}
