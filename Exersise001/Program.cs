int GetRandom(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

int[,] GetRandomArray()
{
    int[,] array = new int[GetRandom(3, 5), GetRandom(3, 5)];

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

int[,] OrderLinesDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if( array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }

    return array;
}

int[,] array = GetRandomArray();
PrintArray(array);
Console.WriteLine();
PrintArray(OrderLinesDescending(array));

