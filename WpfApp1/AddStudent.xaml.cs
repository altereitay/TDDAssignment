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
            if (!int.TryParse(Grade1.Text, out tempGrade))
            {
                MessageBox.Show("grades should only contain numbers");
                return;
            }
            grades[0] = tempGrade;
            if (!int.TryParse(Grade2.Text, out tempGrade))
            {
                MessageBox.Show("grades should only contain numbers");
                return;
            }
            grades[1] = tempGrade;
            if (!int.TryParse(Grade3.Text, out tempGrade))
            {
                MessageBox.Show("grades should only contain numbers");
                return;
            }
            grades[2] = tempGrade;
            if (!int.TryParse(Grade4.Text, out tempGrade))
            {
                MessageBox.Show("grades should only contain numbers");
                return;
            }
            grades[3] = tempGrade;
            if (!int.TryParse(Grade5.Text, out tempGrade))
            {
                MessageBox.Show("grades should only contain numbers");
                return;
            }
            grades[4] = tempGrade;

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

       

            var s = new Student(fName, lName, id, email, phone, grades);
            temp.AddStudent(s);
            StudentControl student_page = new StudentControl(temp);
            temp.mainFrame.Content = student_page;


        }
    }
}
