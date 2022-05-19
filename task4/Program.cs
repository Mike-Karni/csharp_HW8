   
//Задайте двумерный массив. Напишите программу, которая упорядочит по 
  //  убыванию элементы каждой строки двумерного массива.




//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Строк M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Столбцов N: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m, n];

Console.WriteLine("Начальный массив");
PrintArray(array);

for (var i = 0; i < myArray.GetLength(0); i++)
{
    int[] tempArray = new int[myArray.GetLength(1)];
    for(int j = 0; j < myArray.GetLength(1); j++)
    {
        tempArray[j] = myArray[i, j];
    }
    tempArray = BubbleSort(tempArray);

    for (var j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i, j] = tempArray[j];
    }
}

Console.WriteLine("Конечный массив: ");
PrintArray(myArray);



void PrintArray(int[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($" {matr[rows, columns]} ");   
        }
        Console.WriteLine();
    }
}

// МЕТОД ЗАПОЛНЕНИЯ МАССИВА

void FillArray(int[,] matr) 
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows,columns] = new Random().Next(1,11); 
        }
        Console.WriteLine();
    }
}



/*
using System;
    using System.Linq;
     
    namespace n
    {
     
        internal class Program
        {
            private static void Main(string[] args)
            {
     
                var matrix = new int[5, 5];
                var rnd = new Random();
     
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rnd.Next(12, 45);
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
     
                var arr = matrix.Cast<int>().OrderByDescending(a => a).ToArray();
     
                int c = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        matrix[j, k] = arr[c];
                        Console.Write(matrix[j, k] + " ");
                        c++;
                    }
                    Console.WriteLine();
                }
                
            }
        }
    } */