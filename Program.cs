using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Вывести список студентов");
                Console.WriteLine("3. Вывести средний балл студента");
                Console.WriteLine("4. Вывести студентов со средним баллом выше 4");
                Console.WriteLine("5.Выход");
                Console.Write("Выберите действие (1-5): ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Неверный ввод. Введите число от 1 до 5.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите ФИО студента: ");
                        string name = Console.ReadLine();

                        Console.Write("Введите группу студента: ");
                        string group = Console.ReadLine();

                        Console.Write("Введите оценку по информатике: ");
                        int inf = int.TryParse(Console.ReadLine(), out inf) ? inf : 0;

                        Console.Write("Введите оценку по физике: ");
                        int physics = int.TryParse(Console.ReadLine(), out physics) ? physics : 0;

                        Console.Write("Введите оценку по истории: ");
                        int history = int.TryParse(Console.ReadLine(), out history) ? history : 0;

                        students.Add(new Student
                        {
                            Name = name,
                            Group = group,
                            Inf = inf,
                            Physics = physics,
                            History = history
                        });
                        break;
                    case 2:
                        Console.WriteLine("Список студентов:");
                        if (students.Count == 0)
                        {
                            Console.WriteLine("Нет данных о студентах.");
                        }
                        else
                        {
                            foreach (var student in students)
                            {
                                Console.WriteLine(student.ToString());
                            }
                        }
                        break;

                    case 3:

                        break;
                         

                    case 4:
                        var filteredStudents = students.Where(s => s.GetAverage() > 4).ToList();
                        Console.WriteLine($"Количество студентов со средним баллом выше 4: {filteredStudents.Count}");
                        foreach (var student in filteredStudents)
                        {
                            Console.WriteLine(student.ToString());
                        }
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        static int? TryParseNullable(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            return null;
            }
    }
}
