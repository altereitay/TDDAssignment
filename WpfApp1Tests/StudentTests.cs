using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1Tests;

namespace WpfApp1.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void getavgTest()
        {
            int[] grades = { 10, 10, 10, 10, 10 };
            var T = new WpfApp1.Student("NIR", "SHAY", "209375906", "NIR@", "0528283977", grades);
            double avfExpected = 10.0;
            double avfActual = T.getavg(grades);
            Assert.AreEqual(avfExpected, avfActual);
        }
        [TestMethod()]
        public void getavgTest1()
        {
            int[] grades = { 777, 10, 15, 15, 10 };
            var T = new WpfApp1.Student("NIR", "SHAY", "209375906", "NIR@", "0528283977", grades);
            double avfExpected = 12.5;
            double avfActual = T.getavg(grades);
            Assert.AreEqual(avfExpected, avfActual);
        }
        [TestMethod()]
        public void getavgTest2()
        {
            int[] grades = { 777, 10, 777, 777, 10 };
            var T = new WpfApp1.Student("NIR", "SHAY", "209375906", "NIR@", "0528283977", grades);
            double avfExpected = 470.2;
            double avfActual = T.getavg(grades);
            Assert.AreNotEqual(avfExpected, avfActual);
        }



        [WpfTestMethod]
        public void sortStudentsTest1()
        {
            var T = new WpfApp1.MainWindow();
            int []grades= { 10, 10, 10, 10, 10 };
            int[]grades1= { 15, 15, 15, 15, 15 };
            int[]grades2 = { 20, 20, 20, 20, 20 };
            Student a = new Student("NIR", "SHAY", "209375906", "NIR@", "0528283977", grades);
            Student b = new Student("NIR1", "SHAY1", "209375906", "NIR@", "0528283977", grades1);
            Student c = new Student("NIR2", "SHAY2", "209375906", "NIR@", "0528283977", grades2);
            List<Student> s = new List<Student>()
            {
                a,b,c
            };
            List<Student> ExptedList =new List<Student> { c, b, a };
            List <Student> ActualList=T.sortStudents(s);
            CollectionAssert.AreEqual(ExptedList, ActualList);
        }

        [WpfTestMethod]
        public void sortStudentsTest2()
        {
            var T = new WpfApp1.MainWindow();
            int[] grades = { 777, 10, 10, 10, 10 };
            int[] grades1 = { 777, 20, 20, 100, 20 };
            int[] grades2 = { 20, 20, 20, 20 };
            Student a = new Student("NIR", "SHAY", "209375906", "NIR@", "0528283977", grades);
            Student b = new Student("NIR1", "SHAY1", "209375906", "NIR@", "0528283977", grades1);
            Student c = new Student("NIR2", "SHAY2", "209375906", "NIR@", "0528283977", grades2);
            List<Student> s = new List<Student>()
            {
                a,b,c
            };
            List<Student> ExptedList = new List<Student> { b, c, a };
            List<Student> ActualList = T.sortStudents(s);
            CollectionAssert.AreEqual(ExptedList, ActualList);
        }
    }
}