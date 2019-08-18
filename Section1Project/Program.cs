using System;
using System.Collections.Generic;

namespace Section1Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var Students = new List<Student>();

            var cont = true;
            
            while (cont) {
                var newStudent = new Student();
                
                newStudent.Name = Util.Console.Ask("Name:");

                newStudent.Grade = int.Parse(Util.Console.Ask("Grade:"));

                newStudent.Birthday = Util.Console.Ask("DOB:");

                newStudent.Address = Util.Console.Ask("Address:");

                newStudent.Phone = int.Parse(Util.Console.Ask("Phone:"));

                Students.Add(newStudent);

                Console.WriteLine("Add another Student? (y/n)");
                if (Console.ReadLine() != "y") {
                    cont = false;
                };
            } 

            foreach (var student in Students) {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Birthday: {student.Birthday}, Address: {student.Address}, Phone: {student.getPhone()}.");
            }
            Console.WriteLine($"{Student.Count} students.");
        }
    }

    class Student
    {
        static public int Count;
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private int phone;

        public Student()
        {
            Count++;
        }
        public Student(string name, int grade, string birthday, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;

            Count++;
        }

        public  int Phone
        {
            set { phone = value;}
        }

        public int getPhone() {
            return phone;
        }
    }

    class Teacher
    {
        static public int Count;

        public string Name;

        public string Subject;

        private int phone;

        public Teacher() {
            Count++;
        }

        public Teacher(string name, string subject, int phone) {
            Name = name;
            Subject = subject;
            Phone = phone;

            Count++;
        }

        public int Phone
        {
            set { phone = value; }
        }

        public int getPhone()
        {
            return phone;
        }
    }
}
