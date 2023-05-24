int GetRandom(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

int[,] GetRandomArray()
{
    int dimensionSize = GetRandom(4, 6);
    int[,] array = new int[dimensionSize, dimensionSize];

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

int GetMaxSum(int[,] array)
{
    int line = 0;
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }

        if(line == 0)
        {
            line = 1;
            sum = temp;
        }

        else if(temp > sum)
        {
            line = i + 1;
            sum = temp;
        }
    }

    return line;
}

int[,] array = GetRandomArray();
PrintArray(array);
Console.WriteLine($"\n Max sum of digits in {GetMaxSum(array)} line");
