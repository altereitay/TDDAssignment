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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<student> students;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void showStudents_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            FirstName.Visibility = Visibility.Visible;
            FirstNameLabel.Visibility = Visibility.Visible;
            LastName.Visibility = Visibility.Visible;
            LastNameLabel.Visibility = Visibility.Visible;

        }

        private void addBulk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addOne_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
