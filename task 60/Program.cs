﻿// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Random rnd = new Random();
int m = rnd.Next(2, 4);
int n = rnd.Next(2, 4);
int p = rnd.Next(2, 4);

int[,,] arr = new int[m, n, p];



for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
        arr[i, j, k] = rnd.Next(10,99);
        }
    }
}


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
            {
            Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
    System.Console.WriteLine();
    }
}