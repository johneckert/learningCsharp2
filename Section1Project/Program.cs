using System;
using System.Collections.Generic;

namespace Section1Project
{
  class Program
  {
    static void Main(string[] args)
    {
      var Students = new List<Student>();
      var Teachers = new List<Teacher>();
      var cont = true;

      while (cont)
      {
        try
        {
          Console.WriteLine("Are you a teacher? y/n");
          if (Console.ReadLine() != "y")
          {
            var newStudent = new Student();
            newStudent.Name = Util.Console.Ask("Name:");
            var result = int.TryParse(Util.Console.Ask("Grade:"), out newStudent.Grade);
            while (!result)
            {
              result = int.TryParse(Util.Console.Ask("Grade:"), out newStudent.Grade);
            }
            newStudent.Birthday = Util.Console.Ask("DOB:");
            newStudent.Address = Util.Console.Ask("Address:");
            newStudent.Phone = int.Parse(Util.Console.Ask("Phone:"));
            Students.Add(newStudent);

          }
          else
          {
            var newTeacher = new Teacher();
            newTeacher.Name = Util.Console.Ask("Name:");
            newTeacher.Subject = Util.Console.Ask("Subject:");
            newTeacher.Address = Util.Console.Ask("Address:");
            newTeacher.Phone = int.Parse(Util.Console.Ask("Phone:"));
            Teachers.Add(newTeacher);
          }

          Console.WriteLine("Add another Person? (y/n)");
          if (Console.ReadLine() != "y")
          {
            cont = false;
          };
        }
        catch (Exception)
        {
          Console.WriteLine("Nooope");
        }
      }
      foreach (var student in Students)
      {
        student.Display();
      }
      Console.WriteLine($"There are {Student.Count} students.");

      foreach (var teacher in Teachers)
      {
        teacher.Display();
      }
      Console.WriteLine($"There are {Teacher.Count} teachers.");
    }
  }

  class Member
  {
    public string Name;
    public string Address;
    protected int phone;
  }
  class Student : Member
  {
    static public int Count;
    public int Grade;
    public string Birthday;

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

    public int Phone
    {
      set { phone = value; }
    }

    public int getPhone()
    {
      return phone;
    }

    public void Display()
    {
      Console.WriteLine($"Name: {Name}");
      Console.WriteLine($"Grade: {Grade}");
      Console.WriteLine($"Birthday: {Birthday}");
    }
  }

  class Teacher : Member
  {
    static public int Count;
    public string Subject;

    public Teacher()
    {
      Count++;
    }

    public Teacher(string name, string subject, int phone)
    {
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


    public void Display()
    {
      Console.WriteLine($"Name: {Name}");
      Console.WriteLine($"Subject: {Subject}");
      Console.WriteLine($"Phone: {getPhone()}");
    }
  }
}
