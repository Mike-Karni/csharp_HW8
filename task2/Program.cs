
/***Задача 56: ГОТОВО**

Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

/*Console.Write("Введите количество строк m: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];

FillArray(array);
PrintArray(array);
Console.WriteLine("Сумма значений всех элементов массива   ");
AllSum(array,m,n);



//РЕШЕНИЕ ЗАДАЧИ- ОСТАЛЬНОЕ- ПРОВЕРКА

double AllSum(double[,] array,double cows,double columns)
{
    double sum = 0;
    for (int j=0; j<columns; j++)
    {  
        for (int i = 0; i < cows; i++)
        {
            sum += array[i, j];
        }
        
         
    }
    Console.WriteLine(sum);
    return sum;
}

//МЕТОД ПЕЧАТИ МАССИВА
void PrintArray(double[,] matr) 
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
void FillArray(double[,] matr) 
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

*/

    int n1, n2;
                int[,] A;
     
                Console.Write("Введите количество строк в матрице: ");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Введите количество столбцов в матрице: ");
                n2 = int.Parse(Console.ReadLine());
                A = new int[n1, n2];
                Random rnd = new Random();
     
                // Присвоение значений датчиком случайных чисел
                for (int i = 0; i < n1; i++)
                    for (int j = 0; j < n2; j++)
                        A[i, j] = rnd.Next(-0, 10 + 1);
     
                //Вывод массива
                for (int i = 0; i < n1; i++, Console.WriteLine())
                    for (int j = 0; j < n2; j++)
                        Console.Write(A[i, j] + "\t");
                    int minRowSum = int.MaxValue, indexMinRow = 0;
     
                 for (int i = 0; i < n1; i++)
                 {
                    int rowSum = 0;
                    for (int j = 0; j < n2; j++)
                        rowSum += A[i, j];
                    
                    if (rowSum < minRowSum)
                    {
                        minRowSum = rowSum;
                        indexMinRow = i;
                    }
                 }
     
                 Console.WriteLine("Строка с минимальной суммой элементов");
                     for(int j = 0;j<n2;j++)
                          Console.Write(A[indexMinRow, j] + "\t");