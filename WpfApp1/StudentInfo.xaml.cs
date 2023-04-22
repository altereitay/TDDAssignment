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
    /// Interaction logic for StudentInfo.xaml
    /// </summary>
    public partial class StudentInfo : Page
    {
        private MainWindow temp;


        public StudentInfo(MainWindow m1)
        {
            InitializeComponent();
            temp = m1;
           

            List<string[]> displayStudents = new List<string[]>();

            foreach (var student in temp.getStudent())
            {
                string[] displayStudent = { student.firstName, student.lastName, student.ID, student.Email, student.avargae.ToString() };
                displayStudents.Add(displayStudent);
            }

            Student_Info.ItemsSource = displayStudents;
        }
    }
}