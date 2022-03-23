using System;

namespace lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { Age = 20, Id = 7, GroupNumber = 31, Name = "Семён", Surname = "Иванов"};
            Student student2 = new Student() { Age = 21, Id = 5, GroupNumber = 32, Name = "Алексей", Surname = "Фралов"};

            student1.Add(student2);
            student2.AddThree(student1, student2);
            Console.WriteLine("Student1:");
            Console.WriteLine($"Id = {student1.Id}, Age = {student1.Age}, Name = {student1.Name}, Surname = {student1.Surname}, GroupNumber = {student1.GroupNumber}");
            Console.WriteLine("Student2:");
            Console.WriteLine($"Id = {student2.Id}, Age = {student2.Age}, Name = {student2.Name}, Surname = {student2.Surname}, GroupNumber = {student2.GroupNumber}");
        }
    }
}
