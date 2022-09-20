// Вариант №1 - Константин
int ReadData(string line) // Метод считывания данных пользователя
{
    Console.Write(line); // Выводим сообщение
    int number = int.Parse(Console.ReadLine() ?? "0"); // Считываем число
    return number; // Возвращаем значение
}

void Print2DArray(int[,] arr) // Метод, печатает одномерный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Fill2DArray(int rows, int cols, int numMin, int numMax) // Метод генерации и заполнения массива
{
    int[,] array2D = new int[rows, cols]; // Создаём массив

    if (numMin < numMax)
    {
        for (int i = 0; i < rows; i++) // Заполняем массив
        {
            for (int j = 0; j < cols; j++)
            {
                array2D[i, j] = new Random().Next(numMin, numMax + 1);
            }
        }
    }
    return array2D;
}

int SumEqualIndexElements(int[,] arr) // Метод, принимает массив, возвращает сумму элементов с одинаковыми индексами
{
    int length = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
    int sum = 0;

    for (int i = 0; i < length; i++)
    {
        sum += arr[i, i];
    }
    return sum;
}

int numMin = 10;
int numMax = 99;
int rows = ReadData("Введите количество строк: ");
int cols = ReadData("Введите количество столбцов: ");

int[,] array2D = Fill2DArray(rows, cols, numMin, numMax);

Console.WriteLine($"Случайный массив {rows}x{cols}:");
Print2DArray(array2D);

Console.WriteLine($"Сумма элементов по главной диагонали: {SumEqualIndexElements(array2D)}");

// // Вариант №2 - Евгений
// int ReadData(string line) // Чтение данных из консоли
// {
//     Console.Write(line); // Выводим сообщение
//     int number = int.Parse(Console.ReadLine() ?? "0"); // Считываем число
//     return number; // Возвращаем значение
// }

// void PrintResult(string prefix, string data) // Печать результата
// {
//     Console.WriteLine(prefix + data);
// }

// void Print2DArray(int[,] matr) // Печать двумерного массива
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// 
// int Change2DArray(int[,] matr) // Ищем сумму диагонали
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += matr[i, j];
//             }
//         }
//     }
//     return sum;
// }
// 
// void Fill2DArray(int[,] matr, int min, int max) // Заполняем массив случайными числами
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(min, max + 1);
//         }
//     }
// }

// int m = ReadData("Введите количество столбцов: ");
// int n = ReadData("Введите количество строк: ");
// int[,] matrix = new int[m, n];

// Fill2DArray(matrix, 10, 99);
// Print2DArray(matrix);

// PrintResult("Сумма главной диагонали: ", Change2DArray(matrix).ToString());