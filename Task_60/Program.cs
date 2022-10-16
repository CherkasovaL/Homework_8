// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int a = InputInt("Введите первую размерность: ");
int b = InputInt("Введите вторую размерность: ");
int c = InputInt("Введите третью размерность: ");
int countNumbers = 89;

if (a * b * c > countNumbers)
{
    Console.Write("Массив больше размерности случайных чисел");
    return;
}

int[,,] resultNumbers = Massive3D(a, b, c);

for (int i = 0; i < resultNumbers.GetLength(0); i++)
{
    for (int j = 0; j < resultNumbers.GetLength(1); j++)
    {
        for (int k = 0; k < resultNumbers.GetLength(2); k++)
        {
            Console.WriteLine($"{resultNumbers[i, j, k]}({i},{j},{k})");
        }
    }
}

int[,,] Massive3D(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] val = new int[countNumbers];
    int num = 10;
    for (int i = 0; i < val.Length; i++)
        val[i] = num++;

    for (int i = 0; i < val.Length; i++)
    {
        int random = new Random().Next(0, val.Length);
        int temp = val[i];
        val[i] = val[random];
        val[random] = temp;
    }

    int valIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = val[valIndex++];
            }
        }
    }
    return array;
}


int InputInt(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "0");
}
