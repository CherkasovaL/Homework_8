// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[3, 4];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void SortArry(int[, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int MaxNumber = array[i, j];
            for (int b = j; b < array.GetLength(1); b++)
            {
                if (MaxNumber < array[i, b])
                {
                    MaxNumber = array[i, b];
                    array[i, b] = array[i, j];
                    array[i, j] = MaxNumber;
                }
            }
        }
    }   
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
SortArry(array);
PrintArray(array);