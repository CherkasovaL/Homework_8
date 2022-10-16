// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("Введите размер массива");
int len = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[len, len];

int number = 1;
int i = 0, j = 0;

while (number <= len * len)
{
    numbers[i, j] = number;
    if (i <= j + 1 && i + j < len - 1)
        ++j;
    else if (i < j && i + j >= len - 1)
        ++i;
    else if (i >= j && i + j > len - 1)
        --j;
    else
        --i;
    ++number;
}

PrintArray(numbers);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("");
        Console.WriteLine("");
    }
}

