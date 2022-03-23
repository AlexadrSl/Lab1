using System;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1");
            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };
            a.Add(b);
            Console.WriteLine($"a = {a.Real} + {a.Imag}i");
            a.Substract(b);
            Console.WriteLine($"a = {a.Real} + {a.Imag}i");
            b.Multiply(a);
            Console.WriteLine($"b = {b.Real} + {b.Imag}i");
            b.Divide(a);
            Console.WriteLine($"b = {b.Real} + {b.Imag}i");

            Student student1 = new Student() { Age = 20, Id = 7, GroupNumber = 31, Name = "Семён", Surname = "Иванов" };
            Student student2 = new Student() { Age = 21, Id = 5, GroupNumber = 32, Name = "Алексей", Surname = "Фралов" };

            student1.Add(student2);
            student2.AddThree(student1, student2);
            Console.WriteLine("Student1:");
            Console.WriteLine($"Id = {student1.Id}, Age = {student1.Age}, Name = {student1.Name}, Surname = {student1.Surname}, GroupNumber = {student1.GroupNumber}");
            Console.WriteLine("Student2:");
            Console.WriteLine($"Id = {student2.Id}, Age = {student2.Age}, Name = {student2.Name}, Surname = {student2.Surname}, GroupNumber = {student2.GroupNumber}");
        }
    }
}
