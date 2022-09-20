int ReadData(string line) // Чтение данных из консоли
{
    Console.WriteLine(line); // Выводим сообщение
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

void Fill2DArray(int[,] matr) // Заполняем массив 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
}

int m = ReadData("Введите количество столбцов");
int n = ReadData("Введите количество строк");
int[,] matrix = new int[m, n];

Fill2DArray(matrix);
Print2DArray(matrix);