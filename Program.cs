using System;
using System.Collections.Generic;
using System.Linq;

// Задание №3 по LINQ: Сортировка по возрастанию

namespace LinqToObjectsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Задача 3: Сортировка по возрастанию
            Console.WriteLine("Задача 3: Сортировка по возрастанию");
            Task3_SortAscending();
            Console.WriteLine();
        }

        // Задача 3: Сортировка чисел по возрастанию
        // OrderBy сортирует элементы в порядке возрастания
        static void Task3_SortAscending()
        {
            int[] numbers = { 5, 2, 8, 1, 9 };

            // LINQ запрос для сортировки по возрастанию
            var sorted = numbers.OrderBy(n => n);

            Console.WriteLine($"Исходный массив: {string.Join(", ", numbers)}");
            Console.WriteLine($"Отсортированный массив: {string.Join(", ", sorted)}");

            // Дополнительная проверка через Assert (если нужны тесты)
            int[] expected = { 1, 2, 5, 8, 9 };
            bool isCorrect = sorted.SequenceEqual(expected);
            Console.WriteLine($"Правильный результат: {isCorrect}");
        }
    }
}