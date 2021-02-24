using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LINQLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2941, 11, 12, 99, 70, 100, 101 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13)); 
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            List<Student> drivers = students.Where(x => x.CanDrive == true).ToList();
            //Find min and max
            int min = nums.Min();
            int max = nums.Max();
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maximum: {max}");

            //Find max less than 10000
            int boundedMax = nums.Where(x => x < 10000).Max();
            Console.WriteLine($"Max less than 10k: {boundedMax}");

            //Values between 10 - 100
            List<int> tenToHundred = nums.Where(x => x > 10 && x < 100).ToList();
            Console.WriteLine("Numbers between 10 and 100:");
            foreach(int n in tenToHundred)
            {
                Console.WriteLine(n);
            }

            //Values between 100000 - 9999999
            List<int> bigToBigger = nums.Where(x => x > 100000 && x < 9999999).ToList();
            Console.WriteLine("Numbers between 100000 and 9999999");
            foreach(int n in bigToBigger)
            {
                Console.WriteLine(n);
            }

            //Count evens
            int evenCount = nums.Count(x => x % 2 == 0);
            Console.WriteLine($"How many evens? {evenCount}");

            //Students over 21 (didn't put linq statement in model to practice regular statements)
            List<Student> over21 = students.Where(x => x.Age >= 21).ToList();
            Console.WriteLine("Students over 21:");
            foreach(Student s in over21)
            {
                Console.WriteLine(s.Name);
            }

            //Oldest student
            int maxAge = students.Max(x => x.Age);
            Student oldestStudent = students[students.FindIndex(x => x.Age == maxAge)];
            Console.WriteLine($"Oldest student: {oldestStudent.Name}");

            //Youngest student
            int minAge = students.Min(x => x.Age);
            Student youngestStudent = students[students.FindIndex(x => x.Age == minAge)];
            Console.WriteLine($"Youngest student: {youngestStudent.Name}");

            //Oldest student under 25
            List<Student> under25 = students.Where(x => x.Age < 25).ToList();
            int maxUnder25 = under25.Max(x => x.Age);
            Student oldestUnder25 = under25[under25.FindIndex(x => x.Age == maxUnder25)];
            Console.WriteLine($"Oldest under 25: {oldestUnder25.Name}");

            //Students over 21 with even ages
            List<Student> over21AndEven = students.Where(x => x.Age > 21 && x.Age % 2 == 0).ToList();
            Console.WriteLine("Students over 21 with even ages:");
            foreach(Student s in over21AndEven)
            {
                Console.WriteLine(s.Name);
            }

            //Students between 13-19
            List<Student> teens = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            foreach(Student s in teens)
            {
                Console.WriteLine(s.Name);
            }

            //Students starting with a vowel (kind of a hacky work-around)
            char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
            List<Student> vowelStart = students.Where(x => x.Name.ToLower().IndexOfAny(vowels) == 0).ToList();
            Console.WriteLine("Students with names starting with a vowel:");
            foreach(Student s in vowelStart)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
