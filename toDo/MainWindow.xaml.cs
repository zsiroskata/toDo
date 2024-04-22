using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace toDo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Closing += MainWindow_Closing;
        }

        // Hozzáadás gomb 
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (list.Items.Contains(txtBox.Text))
            {
                MessageBox.Show($"Ez már benne van");
                txtBox.Text = "";
            }
            else if (!string.IsNullOrWhiteSpace(txtBox.Text))
            {
                list.Items.Add(txtBox.Text);
                txtBox.Text = "";
            }
            else
            {
                MessageBox.Show($"Nem írtál semmit se a textboxba!");

            }

        }

        // Módosítás gomb 
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null && !string.IsNullOrWhiteSpace(txtBox.Text))
            {
                int selectedIndex = list.SelectedIndex;
                list.Items[selectedIndex] = txtBox.Text;
                txtBox.Text = "";
            }
        }

        // Törlés gomb 
        private void btn3T_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();
        }

        // Törlés gomb a kijelölt elemre
        private void btn4T_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null)
            {
                list.Items.Remove(list.SelectedItem);
            }
        }

        // Másolás gomb
        private void btn5C_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null)
            {
                list_Copy.Items.Add(list.SelectedItem);
            }
            else
            {
                MessageBox.Show($"Semmit nem jelöltél ki");
            }
        }

        //  növekvő gomb 
        private void novekvo_Click(object sender, RoutedEventArgs e)
        {
            //nem tudom :(      
        }

        //  csökkenőbe gomb 
        private void csokkeno_Click(object sender, RoutedEventArgs e)
        {
            list.Items.SortDescriptions.Add( new SortDescription("Content", ListSortDirection.Descending));
        }


        // Fel nyíl gomb 
        private void fel_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = list.SelectedIndex;
            if (selectedIndex > 0)
            {
                object selectedItem = list.SelectedItem;
                list.Items.RemoveAt(selectedIndex);
                list.Items.Insert(selectedIndex - 1, selectedItem);
                list.SelectedIndex = selectedIndex - 1;
            }
            else
            {
                MessageBox.Show("Az első elemet nem lehet feljebb vinni!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Le nyíl gomb 
        private void le_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = list.SelectedIndex;
            if (selectedIndex < list.Items.Count - 1 && selectedIndex != -1)
            {
                object selectedItem = list.SelectedItem;
                list.Items.RemoveAt(selectedIndex);
                list.Items.Insert(selectedIndex + 1, selectedItem);
                list.SelectedIndex = selectedIndex + 1;
            }
            else
            {
                MessageBox.Show("Az utolsó elemet nem lehet lejjebb vinni vagy nincs kijelölt elem!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Ablak bezárásának letiltása
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show($"Végrehajtott feladatok száma: {list.Items.Count}");
            e.Cancel = true; 
        }

        // ALT + F4 letiltása
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; 
            base.OnClosing(e);
        }



        // Kilépés gomb 
        private void kilep_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Végrehajtott feladat(ok) száma: {list.Items.Count}");
            Application.Current.Shutdown();
        }


    }
}
