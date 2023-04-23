using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        [STAThread()]
        public void sortStudentsTest()
        {
            MainWindow T = new WpfApp1.MainWindow();

            // Define the test data
            int[] arr1 = { 100, 90, 80, 99, 100 };
            int[] arr2 = { 100, 100, 100, 100, 100 };
            int[] arr3 = { 60, 90, 80, 50, 100 };
            var students = new List<Student>();
            students.Add(new Student("nir", "kanimach", "208212191", "lior@", "0509196562", arr1));
            students.Add(new Student("etay", "alter", "208212191", "lior@", "0509196562", arr3));
            students.Add(new Student("lior", "gofman", "208212191", "lior@", "0509196562", arr2));

            // Define the expected result
            var sorted_students = new List<Student>();
            sorted_students.Add(new Student("lior", "gofman", "208212191", "lior@", "0509196562", arr2));
            sorted_students.Add(new Student("nir", "kanimach", "208212191", "lior@", "0509196562", arr1));
            sorted_students.Add(new Student("etay", "alter", "208212191", "lior@", "0509196562", arr3));

            // Run the test code on the UI thread
            T.Dispatcher.Invoke(() =>
            {
                // Call the sortStudents method and get the result
                var result = T.sortStudents(students);

                // Compare the result to the expected value
                CollectionAssert.AreEqual(sorted_students, result);
            });
        }
    }
}