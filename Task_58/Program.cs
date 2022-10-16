// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int InputNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "0");
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

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

int size = InputNumber("Введите размер матриц: ");
int[,] matrix1 = new int[size, size];
int[,] matrix2 = new int[size, size];
FillArray(matrix1);
FillArray(matrix2);
int[,] matrixmultiplication = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixmultiplication[i, j] = matrixmultiplication[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("Первая матрица");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц");
PrintArray(matrixmultiplication);

