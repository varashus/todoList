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

namespace todo
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

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ElvListBox.Items.Remove(ElvListBox.SelectedItem);
           
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ElvListBox.Items.Add(New.Text);
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            

            if (ElvListBox.SelectedItem == null)
            {
                MessageBox.Show("Nincs kiválasztva elem");
            }
            else
            {
                int Index = ElvListBox.SelectedIndex;
                ElvListBox.Items.RemoveAt(Index);
                ElvListBox.Items.Add((New.Text).ToString());
            }

        }
    }
}