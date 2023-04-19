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
        private List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void showStudents_Click(object sender, RoutedEventArgs e)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            StudentsGrid.Visibility = Visibility.Visible;
            StudentsGrid.ItemsSource = students.ToList();
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
            var fName = FirstName.Text;
            var lName = LastName.Text;
            var id = ID.Text;
            var email = Email.Text;
            var phone = Phone.Text;
            int[] grades = new int[5];
            grades[0] = Int32.Parse(Grade1.Text);
            grades[1] = Int32.Parse(Grade2.Text);
            grades[2] = Int32.Parse(Grade3.Text);
            grades[3] = Int32.Parse(Grade4.Text);
            grades[4] = Int32.Parse(Grade5.Text);
            if (id.Length != 9)
            {
                Console.WriteLine("id too short");
            }
            if (phone.Length != 10) 
            {
                Console.WriteLine("id too short");
            }
            if (!email.Contains("@"))
            {
                Console.WriteLine("email not valid");
            }
            var s = new Student(fName, lName, id, email, phone, grades);
            students.Add(s);

            FirstName.Visibility = Visibility.Hidden;
            FirstNameLabel.Visibility = Visibility.Hidden;
            LastName.Visibility = Visibility.Hidden;
            LastNameLabel.Visibility = Visibility.Hidden;
            ID.Visibility = Visibility.Hidden;
            IDLabel.Visibility = Visibility.Hidden;
            Email.Visibility = Visibility.Hidden;
            EmailLabel.Visibility = Visibility.Hidden;
            Phone.Visibility = Visibility.Hidden;
            PhoneLabel.Visibility = Visibility.Hidden;
            GradesLabel.Visibility = Visibility.Hidden;
            Grade1.Visibility = Visibility.Hidden;
            Grade2.Visibility = Visibility.Hidden;
            Grade3.Visibility = Visibility.Hidden;
            Grade4.Visibility = Visibility.Hidden;
            Grade5.Visibility = Visibility.Hidden;
            AddOne.Visibility = Visibility.Hidden;
            ShowStudents.Visibility = Visibility.Visible;
            AddStudent.Visibility = Visibility.Visible;
            AddBulk.Visibility = Visibility.Visible;

            /*
            FirstName.Text = "";
            LastName.Text = "";
            ID.Text = "";
            Email.Text = "";
            Phone.Text = "";
            Grade1.Text = "";
            Grade2.Text = "";
            Grade3.Text = "";
            Grade4.Text = "";
            Grade5.Text = "";
            */

        }
        
    }
}
