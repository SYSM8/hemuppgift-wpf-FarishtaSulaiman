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
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (int.TryParse(txtBox1.Text, out int row) && int.TryParse(txtBox2.Text, out int column))
            {

                // Kolla antalet rader och kolumner
                int totalRows = gridContainer.RowDefinitions.Count;
                int totalColumns = gridContainer.ColumnDefinitions.Count;

                // Kontrollera om rad och kolumn är inom gridens gränser
                if (!string.IsNullOrEmpty(txtBox1.Text) &&
                !string.IsNullOrEmpty(txtBox2.Text))
                {
                    
                    // Skapa en ny TextBlock som kommer att visa rad och kolumn
                    TextBlock textBlock = new TextBlock
                    {
                        Text = $"Row: {row}, Column: {column}"
                    };
                  
                    Border border = new Border
                    {
                        Background = Brushes.LightGreen, // Färg på cellen
                        Child = textBlock
                    };
                   

                    Grid.SetRow(border, row);
                    Grid.SetColumn(border, column);
                    gridContainer.Children.Add(border);



                    // jag får inte rätt på den delen med att rensa cellen innan nästa ruta ska bli färgad och få en text, har verkligen försökt allt? 
                    // har testat på flera olika sätt och olika koder 
                    // if (border.Background != null && textBlock.Text != null)
                   // {
                     //   border.Background = new SolidColorBrush(Colors.Transparent);
                      //  textBlock.Text = string.Empty;
                    // }

                }

            }
            else
            {
                MessageBox.Show("Please enter valid numbers for Row and Column.");
            }
        }

    }
}

        

