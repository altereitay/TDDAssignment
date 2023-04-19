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
            ID.Visibility = Visibility.Visible;
            IDLabel.Visibility = Visibility.Visible;
            Email.Visibility = Visibility.Visible;
            EmailLabel.Visibility = Visibility.Visible; 
            Phone.Visibility = Visibility.Visible;
            PhoneLabel.Visibility = Visibility.Visible;
            GradesLabel.Visibility = Visibility.Visible;
            Grade1.Visibility = Visibility.Visible;   
            Grade2.Visibility = Visibility.Visible;
            Grade3.Visibility = Visibility.Visible;
            Grade4.Visibility = Visibility.Visible;
            Grade5.Visibility = Visibility.Visible;
            AddOne.Visibility = Visibility.Visible;
            ShowStudents.Visibility = Visibility.Hidden;
            AddStudent.Visibility = Visibility.Hidden;
            AddBulk.Visibility = Visibility.Hidden;
        }

        private void addBulk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addOne_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
