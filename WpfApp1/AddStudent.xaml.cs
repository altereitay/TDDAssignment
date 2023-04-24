using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Page
    {

        private MainWindow temp;
        HashSet<String> studentIds = new HashSet<string>();
        public AddStudent(MainWindow m1)
        {

            InitializeComponent();
            this.temp = m1;
        }

        private void AddOne_Click(object sender, RoutedEventArgs e)
        {
            var fName = FirstName.Text;
            var lName = LastName.Text;
            var id = ID.Text;
            var email = Email.Text;
            var phone = Phone.Text;
            int[] grades = new int[5];
            int tempGrade;

            if (string.IsNullOrEmpty(Grade1.Text))
            {
                grades[0] = 777;
            }
            else if (!int.TryParse(Grade1.Text, out tempGrade))
            {
                MessageBox.Show("grades should only contain numbers");
                return;
            }
            else
            {
                if (tempGrade < 0 || tempGrade > 100)
                {
                    MessageBox.Show("grades should be between 0-100");
                    return;
                }
                grades[0] = tempGrade;
            }

            if (string.IsNullOrEmpty(Grade2.Text))
            {
                grades[1] = 777;
            }
            else if (!int.TryParse(Grade2.Text, out tempGrade))
            {
                MessageBox.Show("grades should only contain numbers");
                return;
            }
            else
            {   
                if(tempGrade < 0 || tempGrade>100) 
                {
                    MessageBox.Show("grades should be between 0-100");
                    return;
                }
                grades[1] = tempGrade;
            }

            if (string.IsNullOrEmpty(Grade3.Text))
            {
                grades[2] = 777;
            }
            else if (!int.TryParse(Grade3.Text, out tempGrade))
            {
                MessageBox.Show("grades should only contain numbers");
                return;
            }
            else
            {
                if (tempGrade < 0 || tempGrade > 100)
                {
                    MessageBox.Show("grades should be between 0-100");
                    return;
                }
                grades[2] = tempGrade;
            }

            if (string.IsNullOrEmpty(Grade4.Text))
            {
                grades[3] = 777;
            }
            else if (!int.TryParse(Grade4.Text, out tempGrade))
            {
                MessageBox.Show("grades should only contain numbers");
                return;
            }
            else
            {
                if (tempGrade < 0 || tempGrade > 100)
                {
                    MessageBox.Show("grades should be between 0-100");
                    return;
                }
                grades[3] = tempGrade;
            }

            if (string.IsNullOrEmpty(Grade5.Text))
            {
                grades[4] = 777;
            }
            else if (!int.TryParse(Grade5.Text, out tempGrade))
            {
                MessageBox.Show("grades should only contain numbers");
                return;
            }
            else
            {
                if (tempGrade < 0 || tempGrade > 100)
                {
                    MessageBox.Show("grades should be between 0-100");
                    return;
                }
                grades[4] = tempGrade;
            }

            if (!Regex.IsMatch(id,@"^[0-9]{9}$"))
            {
                MessageBox.Show("Id need to be 9 chars and only numbers ");
                return;
            }

            if (!Regex.IsMatch(phone, @"^[0-9]{10}$"))
            {
                MessageBox.Show("phone need to be 10 chars and only numbers ");
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("email not valid");
                return;
            }

            if (!Regex.IsMatch(fName, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("first name should only contain letters");
                return;
            }

            if (!Regex.IsMatch(lName, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("last name should only contain letters");
                return;
            }
            studentIds = new HashSet<String>(temp.getStudentNames());
            if (studentIds.Contains(id))
            {
                MessageBox.Show("The id already exists");
                return;
            }
            var s = new Student(fName, lName, id, email, phone, grades);
            temp.AddStudent(s);
            StudentControl student_page = new StudentControl(temp);
            temp.mainFrame.Content = student_page;


        }
    }
}
