using System;

namespace Collection02
{
    class MyArray
    {
        // Метод для создания массива
        public static int[,] CreateArray()
        {
            Random random = new Random();
            Console.Write("Укажите размер матрицы (m * m): ");
            int m = int.Parse(Console.ReadLine());

            // Формируем массив
            int[,] array = new int[m, m];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 21);
                }
            }

            return array;
        }

        // Метод, который в каждой строке меняет значение максимального
        // элемента на сумму элементов с четными индексами
        public static void EditArray(int[,] array)
        {
            int max, indexJ;
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                max = array[i, 0];
                indexJ = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        indexJ = j;
                    }
                    if (j % 2 == 0) sum += array[i, j];
                }
                array[i, indexJ] = sum;
                sum = 0;
            }
        }

        // Метод для вывода массива на консоль
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,2} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
