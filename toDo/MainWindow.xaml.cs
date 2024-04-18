using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
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
                  
            list.Items.Add(txtBox.Text);
            txtBox.Clear();
            
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
		{
			list.Items.Remove(list.Items[list.SelectedIndex]);
			list.Items.Add(txtBox.Text);


			//         foreach (ListBoxItem item in list.SelectedItems)  
			//         {
			//             csere += item.Content.ToString();
			//             if (txtCsere == csere)
			//             {
			//		MessageBox.Show("Ez ugyan az a szöveg.", "Save error", MessageBoxButton.OK, MessageBoxImage.Error);
			//	}
			//             else
			//             {
			//                 item.Content = txtCsere;
			//             }
			//}
            txtBox.Clear();
            
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
		/* kiválasztott elem törlése */
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
        /* másolás */
        private void btn5C_Click(object sender, RoutedEventArgs e)
        {
            string copyContent = string.Empty;
            foreach (ListBoxItem item in list.SelectedItems)
            {
                copyContent += item.Content.ToString();
            }

            list_Copy.Items.Add(copyContent);
        }

		private void kilep_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

	}
}