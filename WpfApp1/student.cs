﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public string ID;
        public string Email;
        public string phone;
        public int[] grades;
        public double avargae;
        public Student() { }
        public Student (string firstName, string lastName, string ID, string Email, string phone, int[] grades)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ID = ID;
            this.Email = Email;
            this.phone = phone;
            this.grades = grades;
            this.avargae = getavg(grades);
       
        }
        public double getavg(int[] grades)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] != 777)
                {
                    count++;
                    sum += grades[i];
                }
            }
            return sum / count;

        }
    }
}
