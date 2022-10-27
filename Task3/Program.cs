/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3*/
//получение числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[,] InitArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           newArray[i, j] = rnd.Next(2,10);
        }
    }
    return newArray;
}
double GetAverage(int[,] matrix)
{
    double summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        for (int j = 0; j < matrix.GetLength(1);j++)
        {
            if (j==0)
            {
            summ += matrix[i,j];
            }
        }
    }
     return summ;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int row = GetNumber("Введите количество строк:");
int column = GetNumber("Введите количество столбцов:");
int[,] matrix = InitArray(row, column);
PrintMatrix(matrix);
Console.WriteLine($"среднее арифметическое элементов в первом столбце = {GetAverage(matrix)/row}");

