using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    public class Student
    { 
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudentId { get; set; }
        public string Email { get; set; }

        public Student(string name, int age, string studentid, string email)
        {
            Name = name;
            Age = age;
            StudentId = studentid;
            Email = email;
        }
        public void GetNameAndAge()
        {
            Console.WriteLine("The Persen Has Name : {0} and Age : {1}", Name, Age);
        }

    }
}
