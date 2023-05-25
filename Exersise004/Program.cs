
int [,,] GetRandomArray()
{
    int minArrayValue = 10;
    int maxArrayValue = 99;
    int minArrayLength = 1;
    int maxArrayLength = 3;
    int counter = 0;
    int dimensionSize = new Random().Next(minArrayLength, maxArrayLength + 1);
    int lines = new Random().Next(minArrayLength, maxArrayLength + 1);
    int columns = new Random().Next(minArrayLength, maxArrayLength + 1);
    int[,,] array = new int[dimensionSize, lines, columns];
    int[] tempArray = new int[dimensionSize*lines*columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                bool isExist = true;
                while (isExist)
                {
                    int value = new Random().Next(minArrayValue, maxArrayValue + 1);

                    if (Array.IndexOf(tempArray, value) == -1)
                    {
                        isExist = false;
                        tempArray[counter] = value;
                        counter++;
                        array[i, j, k] = value;
                    }
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}

PrintArray(GetRandomArray());