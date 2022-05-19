/*задача 60 Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.*/



int[,,] array3D = new int[2,4,3];
int count = 4;


for (int i = 0; i < array3D.GetLength(0); i++)
{
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            array3D[i,j,k] = count;
            count++;
        }
    }
}

for (int i = 0; i <array3D.GetLength(0); i++)
{
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            Console.WriteLine(array3D[i,j,k] + $" - Строка: {i + 1}; Столбец: {j + 1}; Ширина: {k + 1}");
        }
    }
}