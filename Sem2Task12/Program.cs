//=========================================================================================================================
// № 12 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.
//=========================================================================================================================

int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

// Вариант №1
void ReadData() // Получаем два числа от пользователя
{
    Console.WriteLine("Метод 1");
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
}
void CoculateData() // Определяем кратность числа
{
    result = (inputNumberB % inputNumberA == 0);
}
// void PrintData() // Выводим данные вычисления
// {
if (result)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
}
// }
// 
ReadData();
CoculateData();
// PrintData();

// Вариант №2
// void Variant2()
// {
//     Console.WriteLine("Метод 2");
//     Console.Write("Введите первое число: ");
//     string? inputLineA = Console.ReadLine();
//     Console.Write("Введите второе число: ");
//     string? inputLineB = Console.ReadLine();

//     int inputNumberA = int.Parse(inputLineA);
//     int inputNumberB = int.Parse(inputLineB);

//     Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));
// }

// Вариант №3
// void Variant3()
// {
//     Console.WriteLine("Метод 3");
//     string? inputLineA = Console.ReadLine();
//     string? inputLineB = Console.ReadLine();

//     if (inputLineA != null && inputLineB != null)
//     {
//         int inputNumberA = (int)int.Parse(inputLineA);
//         int inputNumberB = (int)int.Parse(inputLineB);

//         Console.WriteLine(inputNumberB % inputNumberA == 0 ? "Является кратным" : inputNumberB % inputNumberA);
//     }
// }

// Variant1();
// Variant2();
// Variant3();
