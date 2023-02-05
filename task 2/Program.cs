// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

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
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        System.Console.Write(arr[i, j] + " ");
    }
    System.Console.WriteLine();
}

Console.WriteLine("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row <= arr.GetLength(0) && column <= arr.GetLength(1))
{
    System.Console.WriteLine(arr[row, column]);
}
else 
System.Console.WriteLine("Такого числа в массиве нет");