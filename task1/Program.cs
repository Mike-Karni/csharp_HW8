/*Задача 59 : Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении 
которых расположен наименьший элемент массива.*/

Console.Write("Введите количество строк m: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
int[,] newArray = new int[m-1,n-1];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int minValue = MinValue(array);
Console.WriteLine($"Минимальное значение в массиве равно {minValue}");
int minRow = MinRow(array);
int minCol = MinCol(array);

Console.WriteLine($"Минимальный элемент находится в строке {minRow}");
Console.WriteLine($"Минимальный элемент находится в столбце {minCol}");


int k=0,l=0;


    for( int i = 0; i < newArray.GetLength(0); i++)
    {
        l=0;
        if(i==minRow)k++;
        for( int j = 0; j < newArray.GetLength(1); j++)
        {
        if(j==minCol)l++;
        //Console.WriteLine($"i:{i}  j:{j}  k:{k}  l:{l} "); ЛОГИРОВАНИЕ!!!
        newArray[i,j] = array[k,l]; 
        l++;
        }
        k++;

    }




    for( int i = 0; i < array.GetLength(0)-1; i++)
    {
     
        for( int j = 0; j < array.GetLength(1)-1; j++)
        {
        Console.Write(newArray[i,j]+" ");

        
        }
       Console.WriteLine(       );

    }






   /* for( int i = 0; i < array.GetLength(0)-1; i++)
    {
        for( int j = 0; j < array.GetLength(1)-1; j++)
        {
            while( i > minRow && j > minCol )
            { 
            newArray[i,j] =  array[i,j];
            
            }
            Console.Write(newArray[i,j] + " ");
        }
        
        Console.WriteLine(); 
        
    }*/




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


int MinValue(int[,] matrix)
{   
    int minRow = 0;
    int minCol = 0;
    int minValue = matrix[0,0];
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < minValue)
            {
                minValue = matrix[i,j];
                minRow = i;
                minCol = j;
            }
        }
      
    }
    return minValue;
  
    
}

int MinRow(int[,] matrix)
{   
    int minRow = 0;
    int minCol = 0;
    int minValue = matrix[0,0];
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < minValue)
            {
                minValue = matrix[i,j];
                minRow = i;
                minCol = j;
            }
        }
      
    }
    return minRow;
  
    
}

int MinCol(int[,] matrix)
{   
    int minRow = 0;
    int minCol = 0;
    int minValue = matrix[0,0];
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < minValue)
            {
                minValue = matrix[i,j];
                minRow = i;
                minCol = j;
            }
        }
      
    }
    return minCol;
  
    
}