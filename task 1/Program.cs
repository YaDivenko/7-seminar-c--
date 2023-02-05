//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

Console.WriteLine("Введите количеcтво строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количеcтво столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];
Random rnd = new Random();

double genRndDouble (int a, int b)
{
    Random rnd = new Random ();
    double rndDouble = Math.Round(a + rnd.NextDouble() * (b - a),2);

    return rndDouble;
}


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = genRndDouble(0,10);
        System.Console.Write(arr[i,j] + " ");
    }
    System.Console.WriteLine();
}
