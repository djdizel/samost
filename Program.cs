using System;
using System.Collections.Generic;

namespace samost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Merchandise> merchandiseNames = new List<Merchandise> {
            new Merchandise("Laptop", 1200.50, "Dell", 5, new DateTime(2021,1,1)),
            new Merchandise("Smartphone", 799.99, "Samsung", 10, new DateTime(2022,3,2)),
            new Merchandise("Tablet", 499.99, "Apple", 7, new DateTime(2020,4,1)),
            new Merchandise("Smartwatch", 199.99, "Fitbit", 15, new DateTime(2023,5,6)),
            };
            while (true)
            {
                Console.WriteLine("1 - Вывести продукты");
                Console.WriteLine("2 - Добавить продукт");
                Console.WriteLine("3 - Удалить продукт");
                Console.WriteLine("4 - Сколько прошло времени с выхода продукта");
                Console.WriteLine("5 - Выход");
                Console.Write("Выберите действие (1-5): ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 5.");
                    continue;
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Список продуктов:");
                        foreach (var item in merchandiseNames)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 2:
                        Console.Write("Введите название продукта: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите цену продукта: ");
                        if (!double.TryParse(Console.ReadLine(), out double price))
                        {
                            Console.WriteLine("Ошибка: введите корректную цену.");
                            continue;
                        }
                        Console.Write("Введите производителя продукта: ");
                        string producer = Console.ReadLine();
                        Console.Write("Введите количество продукта: ");
                        if (!int.TryParse(Console.ReadLine(), out int count))
                        {
                            Console.WriteLine("Ошибка: введите корректное количество.");
                            continue;
                        }
                        Console.Write("Введите год выпуска продукта (yyyy/m/d): ");
                        if (!int.TryParse(Console.ReadLine(), out int day))
                        {
                            Console.WriteLine("Ошибка: введите корректный день.");
                            continue;
                        }
                        if (!int.TryParse(Console.ReadLine(), out int month))
                        {
                            Console.WriteLine("Ошибка: введите корректный месяц.");
                            continue;
                        }
                        if (!int.TryParse(Console.ReadLine(), out int year))
                        {
                            Console.WriteLine("Ошибка: введите корректный год.");
                            continue;
                        }
                        merchandiseNames.Add(new Merchandise(name, price, producer, count, new DateTime(day,month,year)));
                        break;
                    case 3:
                        Console.Write("Введите название продукта для удаления: ");
                        string removeName = Console.ReadLine();
                        var itemToRemove = merchandiseNames.Find(m => m.Name.Equals(removeName, StringComparison.OrdinalIgnoreCase));
                        if (itemToRemove.Name != null)
                        {
                            merchandiseNames.Remove(itemToRemove);
                            Console.WriteLine($"Продукт {removeName} удален.");
                        }
                        else
                        {
                            Console.WriteLine($"Продукт {removeName} не найден.");
                        }
                        break;
                    case 4:
                        Console.Write("Введите название продукта для проверки времени выпуска: ");
                        string checkName = Console.ReadLine();
                        var itemToCheck = merchandiseNames.Find(m => m.Name.Equals(checkName, StringComparison.OrdinalIgnoreCase));
                        if (itemToCheck.Name != null)
                        {
                            TimeSpan timeSinceRelease = DateTime.Now - itemToCheck.Year;
                            Console.WriteLine($"С момента выпуска продукта {checkName} прошло {timeSinceRelease.TotalDays:F0} дней.");
                        }
                        else
                        {
                            Console.WriteLine($"Продукт {checkName} не найден.");
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка: выберите действие от 1 до 5.");break;
                }
            }
        }
    }
}