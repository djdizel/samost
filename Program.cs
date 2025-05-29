using System;
using System.Collections.Generic;

namespace samost
{
    internal class Program
    {
        // Define the Student class
        static void Main(string[] args)
        {
            // Initialize the list of students
            List<Student> students = new List<Student>
            {
                new Student { Name = "Иванов Иван Иванович", Group = "Группа 1", Inf = 5, Physics = 4, History = 3 },
                new Student { Name = "Петров Петр Петрович", Group = "Группа 2", Inf = 4, Physics = 5, History = 4 },
                new Student { Name = "Сидоров Сидор Сидорович", Group = "Группа 1", Inf = 3, Physics = 2, History = 4 }
            };

            while (true)
            {
                Console.WriteLine("1 - Вывести студентов Группы 1");
                Console.WriteLine("2 - Вывести студентов Группы 2");
                Console.WriteLine("3 - Вывести всех студентов");
                Console.WriteLine("4 - Посчитать средний балл");
                Console.WriteLine("5 - Выход");
                Console.Write("Выберите действие: ");

                // Handle invalid input
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 5.");
                    continue;
                }

                if (choice == 5)
                {
                    break;
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Введите номер студента (1-" + students.Count + "):");
                    if (int.TryParse(Console.ReadLine(), out int studentIndex) && studentIndex >= 1 && studentIndex <= students.Count)
                    {
                        Student student = students[studentIndex - 1];
                        double average = student.GetAverage();
                        Console.WriteLine($"Средний балл студента {student.Name}: {average:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: неверный номер студента.");
                    }
                }
                else if (choice >= 1 && choice <= 3)
                {
                    foreach (var student in students)
                    {
                        if (choice == 1 && student.Group == "Группа 1" ||
                            choice == 2 && student.Group == "Группа 2" ||
                            choice == 3)
                        {
                            Console.WriteLine(student);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: выберите действие от 1 до 5.");
                }

                Console.WriteLine(); // Empty line for readability
            }
        }
    }
}