//  Task61 Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.Write("Size of Matrix: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] pascal = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (i == j || j == 0)
        {
            pascal[i, j] = 1;
        }
        else if (j > i)
        {
            pascal[i, j] = 0;
        }
        else if (i != j)
        {
            pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j];
        }
        
        Console.Write($"{pascal[i, j],5 }");
    }
    Console.WriteLine();
}