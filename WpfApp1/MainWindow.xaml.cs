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

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public List<Student> getStudent()
        {
            return students;
        }
        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudent student_page = new AddStudent(this);
            mainFrame.Content= student_page;
        }

        private void ShowStudent_Click(object sender, RoutedEventArgs e)
        {
            students =sortStudents(students);
            StudentInfo student_page = new StudentInfo(this);
            mainFrame.Content = student_page;
        }

        private void AddStudents_Click(object sender, RoutedEventArgs e)
        {
         

            string[] firstNames = { "Adam", "Ben", "Charlie", "David", "Emma", "Frank", "Grace", "Hannah", "Isaac", "Julia", "Kevin", "Lena", "Mike", "Nora", "Olivia", "Peter", "Quinn", "Rachel", "Sarah", "Tom", "Ursula", "Victoria", "Walter", "Xander", "Yara", "Zoe" };
            string[] lastNames = { "Anderson", "Brown", "Clark", "Davis", "Evans", "Foster", "Garcia", "Hernandez", "Ibrahim", "Jones", "Kim", "Lopez", "Martinez", "Nguyen", "O'Connor", "Parker", "Quinn", "Robinson", "Smith", "Thompson", "Underwood", "Vargas", "Walker", "Xu", "Young", "Zhang" };
            string[] domains = { "gmail.com", "yahoo.com", "hotmail.com", "outlook.com" };
            Random rnd = new Random();

            for (int i = 0; i < 10000; i++)
            {
                Student student = new Student();
                student.firstName = firstNames[rnd.Next(firstNames.Length)];
                student.lastName = lastNames[rnd.Next(lastNames.Length)];
                student.ID = rnd.Next(1000000, 10000000).ToString();
                student.Email = student.firstName.ToLower() + "." + student.lastName.ToLower() + "@" + domains[rnd.Next(domains.Length)];
                student.phone = rnd.Next(1000000, 10000000).ToString();
                student.grades = new int[5];
                for (int j = 0; j < 5; j++)
                {
                    student.grades[j] = rnd.Next(0, 101);
                }
                student.avargae = student.grades.Average();
                students.Add(student);
            }
            StudentControl student_page = new StudentControl(this);
            mainFrame.Content = student_page;
        }
        public List<Student> sortStudents(List<Student> students)
        {

            if (students.Count <= 1)
            {
                return students;
            }

            int middleIndex = students.Count / 2;
            List<Student> left = new List<Student>();
            List<Student> right = new List<Student>();

            for (int i = 0; i < middleIndex; i++)
            {
                left.Add(students[i]);
            }
            for (int i = middleIndex; i < students.Count; i++)
            {
                right.Add(students[i]);
            }

            left = sortStudents(left);
            right = sortStudents(right);

            return Merge(left, right);
        }

        private List<Student> Merge(List<Student> left, List<Student> right)
        {
            List<Student> result = new List<Student>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0].avargae > right[0].avargae)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
