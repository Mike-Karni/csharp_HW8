//**Задача 58: ГОТОВО**Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк m: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк o: "); 
int o = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов p: ");
int p = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
int[,] array1 = new int[o,p];

FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
int[,]r =Multiplication(array,array1);
PrintArray(r);


//МЕТОД ПЕЧАТИ МАССИВА
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
    //ADASDASDASDA
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




  int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            return r;
        }