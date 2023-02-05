//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количетво строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количетво столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
Random rnd = new Random();


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(10);
        System.Console.Write(arr[i, j] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();


for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ Math.Round(sum / arr.GetLength(0),1)} ");
}
