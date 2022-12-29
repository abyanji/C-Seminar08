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

void IndexMinimum(int[,] array, out int rowIndex, out int columnIndex)
{
    rowIndex = 0;
    columnIndex = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                rowIndex = i;
                columnIndex = j;
            }
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"{rowIndex + 1} {columnIndex + 1}");
}

int[,] NewArray(int[,] array, int rowIndex, int columnIndex)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == rowIndex)
        {
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == columnIndex)
            {
                continue;
            }
            newArray[k, l] = array[i, j];
            l++;
        }
        k++;
        l = 0;
    }
    return newArray;
}

int rows = DataEntry("Enter the value of rows: ");
int columns = DataEntry("Enter the value of columns: ");
int[,] matrix = CreateRandomArray(rows, columns, 1, 9);
PrintArray(matrix);
IndexMinimum(matrix, out int rowIndex, out int columnIndex);
int[,] newMatrix = NewArray(matrix, rowIndex, columnIndex);
System.Console.WriteLine();
PrintArray(newMatrix);