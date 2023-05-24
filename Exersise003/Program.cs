

using System.ComponentModel;

int GetRandom(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

int[,] GetRandomArray(int lines, int columns)
{
    int[,] array = new int[lines, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = GetRandom(0, 9);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+ " ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        System.Console.WriteLine("Matrix cant be multilplyed");
        throw new Exception("Matrixes are not equal");
    }

    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }

    return result;
}

int[,] array1 = GetRandomArray(2, 3);

int[,] array2 = GetRandomArray(3, 2);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(MatrixMultiplication(array1, array2));

