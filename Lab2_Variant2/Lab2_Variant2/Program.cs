using System;

namespace Lab2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Завдання 1: Список групи ===");
            Console.WriteLine("Введіть номер студента у списку групи (від 1 до 10):");

            if (int.TryParse(Console.ReadLine(), out int studentNum))
            {
                switch (studentNum)
                {
                    case 1:
                        Console.WriteLine("1: Іван Петренко");
                        break;
                    case 2:
                        Console.WriteLine("2: Марія Шевченко");
                        break;
                    case 3:
                        Console.WriteLine("3: Олександр Коваль");
                        break;
                    case 4:
                        Console.WriteLine("4: Анна Мельник");
                        break;
                    case 5:
                        Console.WriteLine("5: Дмитро Бондаренко");
                        break;
                    case 6:
                        Console.WriteLine("6: Софія Бойко");
                        break;
                    case 7:
                        Console.WriteLine("7: Максим Ткаченко");
                        break;
                    case 8:
                        Console.WriteLine("8: Вікторія Кравченко");
                        break;
                    case 9:
                        Console.WriteLine("9: Артем Ковальчук");
                        break;
                    case 10:
                        Console.WriteLine("10: Анастасія Олійник");
                        break;
                    default:
                        Console.WriteLine("Помилка: номер має бути в діапазоні від 1 до 10.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Помилка: введено не ціле число.");
            }
            Console.ReadKey();
        }
    }
}