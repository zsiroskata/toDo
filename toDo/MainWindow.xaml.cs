using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace toDo
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Add((string)txtBox.Text);
            txtBox.Clear();
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            int szam = list.SelectedItems.IndexOf(list.SelectedItems);
            list.SelectedIndex = szam;
            
        }

        private void btn3T_Click(object sender, RoutedEventArgs e)
        {
           
            if (list.Items.Count != 0)
            { 
                list.Items.Clear();
            } 
            else {
                MessageBox.Show("A listbox üres, töltse fel mielött törölne.", "Save error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
        private void btn4T_Click(object sender, RoutedEventArgs e)
        {
            if (list.Items.Count > 0)
            {
                list.Items.Remove(list.SelectedItem);
            }
            else
            {
                MessageBox.Show("A listbox üres, töltse fel mielött törölne.", "Save error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void kilep_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}