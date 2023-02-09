// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Random rnd = new Random();
int m = rnd.Next(2, 4);

int[,] arr1 = new int[m, m];
// делаю для квадратных матриц, потому что на большее мозгов не хватило 

for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        arr1[i, j] = rnd.Next(10);
        System.Console.Write(String.Format("{0,5}", (arr1[i, j])));
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

int[,] arr2 = new int[m, m];

for (int i = 0; i < arr2.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        arr2[i, j] = rnd.Next(10);
        System.Console.Write(String.Format("{0,5}", (arr2[i, j])));
    }
    System.Console.WriteLine();
}

int[,] arr3 = new int[m, m];

for (int i = 0; i < arr3.GetLength(0); i++)
{
    for (int j = 0; j < arr3.GetLength(1); j++)
    {
        for (int k = 0; k < arr3.GetLength(1); k++)
        {
            arr3[i, j] = arr3[i, j] + (arr1[i, k] * arr2[k, j]);
        }
    }
}
System.Console.WriteLine();

for (int i = 0; i < arr3.GetLength(0); i++)
{
    for (int j = 0; j < arr3.GetLength(1); j++)
    {
        System.Console.Write(String.Format("{0,5}", (arr3[i, j])));
    }
    System.Console.WriteLine();
}
