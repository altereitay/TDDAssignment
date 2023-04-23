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
            sortStudents();
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
        public void sortStudents()
        {
            for(int i=0; i<students.Count; i++)
            {
                for (int j=i+1;j< students.Count;j++)
                {
                    Student temp;
                    if (students[j].avargae > students[i].avargae)
                    {
                        temp= students[j];
                        students[j]= students[i];
                        students[i]= temp;
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
