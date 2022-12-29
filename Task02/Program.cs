Console.Clear();

int DataEntry(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange + 1);
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
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void SwapRowsAndColumns(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int buffer;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int j = i;
            while (j < array.GetLength(1))
            {
                buffer = array[i , j];
                array[i , j] = array[j , i];
                array[j , i] = buffer;
                j++;
            }
        }
    PrintArray(array);
    }
    else
    {
        System.Console.WriteLine("Imposible to swap rows and columns");
    }
}

int rows = DataEntry("Enter the value of rows: ");
int columns = DataEntry("Enter the value of columns: ");
int[,] matrix = CreateRandomArray(rows, columns, 1, 9);
PrintArray(matrix);
System.Console.WriteLine();
SwapRowsAndColumns(matrix);