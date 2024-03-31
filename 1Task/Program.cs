// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы
// на их квадраты.
// Пример
//      0   1  2  3

// 0    2   3  4  3

// 1    4   3  4  1

// 2    2   9  5  4

// 4 3 16 3
// 4 3 4 1
// 2 9 25 4

int[ , ] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }

    }
    Console.Write("]");
}