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
            grades[0] = String.IsNullOrEmpty(Grade1.Text) ? 777 : Int32.Parse(Grade1.Text);
            grades[1] = String.IsNullOrEmpty(Grade2.Text) ? 777 : Int32.Parse(Grade2.Text);
            grades[2] = String.IsNullOrEmpty(Grade3.Text) ? 777 : Int32.Parse(Grade3.Text);
            grades[3] = String.IsNullOrEmpty(Grade4.Text) ? 777 : Int32.Parse(Grade4.Text);
            grades[4] = String.IsNullOrEmpty(Grade5.Text) ? 777 : Int32.Parse(Grade5.Text);
            
            if(!Regex.IsMatch(id,@"^[0-9]{9}$"))
            {
                MessageBox.Show("Id need to be 9 chars ");
                return;
            }

            if (!Regex.IsMatch(phone, @"^[0-9]{10}$"))
            {
                MessageBox.Show("phone need to be 10 chars ");
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

            foreach (var grade in grades)
            {
                if (!Regex.IsMatch(grade.ToString(), @"^[0-9]+$"))
                {
                    MessageBox.Show("grades should only contain numbers");
                    return;
                }
            }

            var s = new Student(fName, lName, id, email, phone, grades);
            temp.AddStudent(s);
            StudentControl student_page = new StudentControl(temp);
            temp.mainFrame.Content = student_page;


        }
    }
}
