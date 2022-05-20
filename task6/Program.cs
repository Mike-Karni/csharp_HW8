/**Задача 62:**

Заполните спирально массив 4 на 4.*/



/*1     2   3   4

12   13  14   5

11   16  15   6

10    9  8    7*/

int s = 4;
int [,] snakeArray = new int[s,s];
int tempNumber = 1;
int i = 0;
int j = 0;
while(tempNumber<=s*s)
{
    snakeArray[i,j] = tempNumber;
    tempNumber ++;
    if (i<=j+1 && i+j<s-1)
    {
        j++;
    }
    else if(i<j && i+j>=s-1)
    {
        i++;
    }
    else if(i>=j && i+j>s-1)
    {
        j--;
    }
    else
    {
        i--;
    }
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
PrintArray(snakeArray);