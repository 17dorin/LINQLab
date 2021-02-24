using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQLab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool CanDrive => Age >= 16;

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
