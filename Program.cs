using System;

/* Задание: Дана матрица А, состоящая из М строк и М столбцов. 
 * В каждой строке заменить максимальный элемент суммой элементов с четными индексами.*/

namespace Collection02
{
    class Program
    {
        static void Main()
        {
            int[,] array = MyArray.CreateArray();   // Создаем массив

            Console.WriteLine("\nЗаданный массив:");
            MyArray.PrintArray(array);              // Выводим созданный массив на консоль

            MyArray.EditArray(array);               // Форматируем массив

            Console.WriteLine("\nРезультирующий массив:");
            MyArray.PrintArray(array);              // Выводим измененный массив на консоль

            Console.ReadKey();
        }
    }
}