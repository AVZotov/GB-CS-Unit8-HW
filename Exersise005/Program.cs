
int[,] FillArray(int[,] arrayToFill)
{
    int[,] fillControl = new int[arrayToFill.GetLength(0), arrayToFill.GetLength(1)];
    int stepsNumber = arrayToFill.GetLength(0);
    int value = 1;
    int line = 0;
    
    for (int i = 0; i < stepsNumber; i++)
    {
        arrayToFill[line, i] = value;
        value ++;
        fillControl[line, i] = 1;
    }

    while (true)
    {
        value = MoveDownLeft(arrayToFill, value);
        if(value > arrayToFill.GetLength(0) * arrayToFill.GetLength(1)) break;

        value = MoveUpRight(arrayToFill, value);
        if(value > arrayToFill.GetLength(0) * arrayToFill.GetLength(1)) break;
    }


    return arrayToFill;
}

int MoveDownLeft(int[,] arrayToFill, int value)
{
    int line = 0;
    int column = arrayToFill.GetLength(1) - 1;
    bool isCorrectPositionToFill = false;

    while (isCorrectPositionToFill == false)
    {
        if (arrayToFill[line + 1, column] == 0)
        {
            isCorrectPositionToFill = true;
            line ++;
        }
        else
        {
            line ++;
            column --;
        }
    }

    for (; line < arrayToFill.GetLength(1); line++)
    {
        if(arrayToFill[line, column] != 0) 
            break;
        
        arrayToFill[line, column] = value;
        value++;
    }

    column --;
    line --;

    for (; column >= 0; column--)
    {
        if(arrayToFill[line, column] != 0) 
            break;
        
        arrayToFill[line, column] = value;
        value++;
    }

    return value;
}

int MoveUpRight(int[,] arrayToFill, int value)
{
    int line = arrayToFill.GetLength(0) - 1;
    int column = 0;
    bool isCorrectPositionToFill = false;

    while (isCorrectPositionToFill == false)
    {
        if (arrayToFill[line - 1, column] == 0)
        {
            isCorrectPositionToFill = true;
            line --;
        }
        else
        {
            line --;
            column ++;
        }
    }

    for (; line >= 0; line--)
    {
        if(arrayToFill[line, column] != 0) 
            break;
        
        arrayToFill[line, column] = value;
        value++;
    }

    line ++;
    column++;

    for (; column < arrayToFill.GetLength(1); column++)
    {
        if(arrayToFill[line, column] != 0) 
            break;
        
        arrayToFill[line, column] = value;
        value++;
    }

    return value;
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

int[,] array = new int[4, 4];
PrintArray(FillArray(array));