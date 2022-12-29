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

int[,] ChangeRows(int[,] array)
{
    int buffer;
    int i = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        buffer = array[i , j];
        array[i , j] = array [array.GetLength(0) - 1, j];
        array [array.GetLength(0) - 1, j] = buffer;
    }
    return array;
}

int rows = DataEntry("Enter the value of rows: ");
int columns = DataEntry("Enter the value of columns: ");
int[,] matrix = CreateRandomArray(rows, columns, 1, 9);
PrintArray(matrix);
matrix = ChangeRows(matrix);
System.Console.WriteLine();
PrintArray(matrix);
