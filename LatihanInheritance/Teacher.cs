using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public Teacher(string name, int age, string teacherid, string subject)
        {
            Name = name;
            Age = age;
            TeacherId = teacherid;
            Subject = subject;
        }
        public void GetNameAndAge()
        {
            Console.WriteLine("The Persen Has Name : {0} and Age : {1}", Name, Age);
        }
    }
}