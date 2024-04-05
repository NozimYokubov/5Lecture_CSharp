// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Начальные условия:

// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };
// Выводится: 1

// int[] SumRows(int[,] array)
//     {
//       //Напишите свое решение здесь
//       int rows = array.GetLength(0);
//       int cols = array.GetLength(1);
//       int[] sums = new int[rows];
//       for (int i = 0; i < rows; i++)
//       {
//         int rowSum = 0;
//         for (int j = 0; j < cols; j++)
//         {
//             rowSum += array[i,j];
//         }
//         sums[i] = rowSum;
//       }
//       return sums;
//     }

// Console.WriteLine(SumRows(numbers));

// Console.WriteLine(numbers[numbers.GetLength(0) - 1, numbers.GetLength(1) - 1]);
// int one = numbers.GetLength(1);
// int zero = numbers.GetLength(0);
// Console.WriteLine(one);
// Console.WriteLine(zero);


////////////////////////////
using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
      //Напишите свое решение здесь
      int rows = array.GetLength(0);
      int cols = array.GetLength(1);
      int[] sums = new int[rows];
      for (int i = 0; i < rows; i++)
      {
        int rowSum = 0;
        for (int j = 0; j < cols; j++)
        {
            rowSum += array[i,j];
        }
        sums[i] = rowSum;
      }
      return sums;
    }
    
    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
       //Напишите свое решение здесь
       int indexMin = 0;
       int min = array[indexMin];
       for (int i = 0; i < array.Length; i++)
       {
        if (min >= array[i])
        {
            indexMin = i;
        }
       }
       return indexMin;
    }
    public static void PrintResult(int[,] numbers)
    {   
       //Напишите свое решение здесь
       int[] result = SumRows(numbers);
       int answer = MinIndex(result);
       Console.WriteLine(answer);

    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            
            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };      
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}