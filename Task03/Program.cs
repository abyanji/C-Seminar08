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

void FrequencyOfNumbers(int[,] array, int leftRange, int rightRange)
{
    int count = 0;
    int max = rightRange;
    for (int min = leftRange; min <= max; min++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (min == array[i, j]) count++;
            }
        }
        if (count != 0) System.Console.WriteLine($"{min} appears {count} times");
        count = 0;
    }
}

int rows = DataEntry("Enter the value of rows: ");
int columns = DataEntry("Enter the value of columns: ");
int[,] matrix = CreateRandomArray(rows, columns, 1, 9);
PrintArray(matrix);
FrequencyOfNumbers(matrix, 1, 9);