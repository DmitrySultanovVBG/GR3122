// Вариант №1 - Евгений
int ReadData(string line) // Чтение данных из консоли
{
    Console.Write(line); // Выводим сообщение
    int number = int.Parse(Console.ReadLine() ?? "0"); // Считываем число
    return number; // Возвращаем значение
}

void Print2DArray(int[,] matr) // Печать двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Fill2DArray(int[,] matr, int min, int max) // Заполняем массив случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void Change2DArray(int[,] matr) // Делаем квадраты
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matr[i, j] = (int)Math.Pow(matr[i, j], 2);
            }

        }
    }
}

int m = ReadData("Введите количество столбцов: ");
int n = ReadData("Введите количество строк: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 10, 99);
Print2DArray(matrix);
Change2DArray(matrix);

Console.WriteLine();
Print2DArray(matrix);

// // Вариант №2 - Анатолий
// // Печать 2D массива.
// void Print2DArr(int[,] arr, string message = "Массив: ")
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} "); // табуляция \t
//         }
//         Console.WriteLine();
//     }
// }

// // Делаем квадраты
// void Change2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matr[i, j] = (int)Math.Pow(matr[i, j], 2);
//             }

//         }
//     }
// }

// // Генерация случайного двумерного массива.
// int[,] Gen2DArr(int arrLen, int arrDepth, int arrMin, int arrMax)
// {
//     int[,] arr = new int[arrLen, arrDepth];
//     Random rnd = new Random();

//     if (arrMin > arrMax)
//     {
//         int temp = arrMax;
//         arrMax = arrMin;
//         arrMin = temp;
//     }

//     for (int i = 0; i < arrLen; i++)
//     {
//         for (int j = 0; j < arrDepth; j++)
//         {
//             arr[i, j] = rnd.Next(arrMin, arrMax);
//         }
//     }
//     return arr;
// }

// //
// int[,] EvenToSquere(int[,] arr)
// {
//     for (int i = 1; i < arr.GetLength(0); i += 2)
//     {
//         for (int j = 1; j < arr.GetLength(1); j += 2)
//         {
//             arr[i, j] *= arr[i, j];
//         }
//     }
//     return arr;
// }

// int[,] arr = Gen2DArr(10, 15, 10, 99);
// Print2DArr(arr);
// Console.WriteLine();
// Console.WriteLine();

// // Проверка вермени
// int[,] arr2d_1 = new int[10, 15];
// int[,] arr2d_2 = new int[10, 15];

// arr2d_1 = (int[,])arr.Clone();
// arr2d_2 = (int[,])arr.Clone();

// DateTime d1 = DateTime.Now;
// arr2d_1 = EvenToSquere(arr2d_1);
// Console.WriteLine(DateTime.Now - d1);

// DateTime d2 = DateTime.Now;
// EvenToSquere(arr2d_2);
// Console.WriteLine(DateTime.Now - d2);

Print2DArr(EvenToSquere(arr));
