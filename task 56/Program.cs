// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Random rnd = new Random();
int m = rnd.Next(2, 6);
int n = rnd.Next(2, 6);

int[,] arr = new int[m, n];



for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(10);
        System.Console.Write(String.Format("{0,5}", (arr[i, j])));
    }
    System.Console.WriteLine();
}

int minsum = Int32.MaxValue;
int indexRow = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexRow++;
    }
}

Console.WriteLine("минимальная сумма элементов (" + (minsum) + ") в строке " + (indexRow));
