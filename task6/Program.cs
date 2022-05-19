/**Задача 62:**

Заполните спирально массив 4 на 4.*/

int[,] snakeArray = new int[4,4];



for(int i = 0; i < 1; i++)
{
    for(int j = 1; j < snakeArray.Length; j++)
    {
        snakeArray[0,0] = 1;
        snakeArray[0,j] = snakeArray[0,j] + 1;
    }
}

for(int i = 0; i < snakeArray.Length; i++)
{
    for(int j = 0; j < snakeArray.Length; j++)
    {
        Console.Write(snakeArray[0,j]);
    }
    Console.WriteLine();
}