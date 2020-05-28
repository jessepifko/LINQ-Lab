using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Console_App_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

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

            //1.
            //int max = nums.Max();
            //Console.WriteLine(max);

            //2.
            //int min = nums.Min();
            //Console.WriteLine(min);
            //  3.
            //var maxVal = nums.Where(x => x < 10000).Max();
            //Console.WriteLine(maxVal);
            //4.
            //List<int> nums2 = nums.Where(x => x >= 10 && x < 100).ToList();
            //foreach (int s in nums2)
            //{
            //Console.WriteLine(s);
            //}
            //5.
            //List<int> nums2 = nums.Where(x => x > 10000 && x < 999999).ToList();
            //foreach (int s in nums2)
            //{
            //    Console.WriteLine(s);
            //}
            //6.
            //var count = nums.Where(a => a % 2 == 0).Count();
            //Console.WriteLine(count);

            //For Students
            //1.
            //List < Student > aged21 = students.Where(x => x.Age >= 21).ToList();
            //foreach (var s in aged21)
            //{
            //    Console.WriteLine(s.Name);
            //}

            //2.
            //var oldest = students.Max(x => x.Age);
            //var oldestName = from s in students
            //                 where s.Age == oldest
            //                 select s.Name;

            //foreach (var v in oldestName)
            //{
            //    Console.WriteLine(v);
            //}

            //3.
            //var youngest = students.Min(x => x.Age);
            //var youngestName = from s in students
            //                   where s.Age == youngest
            //                   select s.Name;

            //foreach (var v in youngestName)
            //{
            //    Console.WriteLine(v);
            //}

            //4.
            //var youngest25 = students.First(x => x.Age == (students.Where(x => x.Age < 25).Max(x => x.Age)));
            //Console.WriteLine(youngest25.Name);
            //5.
            //var evenOver21 = students.Where(x => x.Age % 2 == 0 && x.Age > 21).ToList();
            //foreach (var v in evenOver21)
            //{
            //    Console.WriteLine(v.Name);
            //}
            //6.
            //var teenAgers = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            //foreach (var v in teenAgers)
            //{
            //    Console.WriteLine(v.Name);
            //}
            //7.
            //var hasVowel = students.Where(x => x.Name.ToLower().StartsWith("a") || x.Name.ToLower().StartsWith("e") || x.Name.ToLower().StartsWith("i") || x.Name.ToLower().StartsWith("o") || x.Name.ToLower().StartsWith("u")).ToList();
            //foreach (var s in hasVowel)
            //{
            //    Console.WriteLine(s.Name);
            //}



        }
    }
}
