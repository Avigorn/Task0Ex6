// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
double ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

double[,] GenerateArray(double rows, double cols)
{
    int rowsI = Convert.ToInt32(rows);
    int colsN = Convert.ToInt32(cols);
    double[,] arrayD2 = new double[rowsI, colsN];
    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int n = 0; n < arrayD2.GetLength(1); n++)
        {
            arrayD2[i, n] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        }
    }
    return arrayD2;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");

        }
        System.Console.WriteLine();
    }
}

double rows = ReadInt("Введите число строк");
double columns = ReadInt("Введите число столбцов");
ShowArray(GenerateArray(rows, columns));