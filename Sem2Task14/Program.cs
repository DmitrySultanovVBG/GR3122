//=========================================================================================================
// № 14 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//=========================================================================================================

// Вариант №1
// Console.Write("Введите число: ");
// string? inputLineA = Console.ReadLine();
// int inputNumberA = int.Parse(inputLineA);

// if(inputNumberA%7==0 && inputNumberA%23==0)
// {
//     Console.Write("Число кратно одновременно 7 и 23");
// }
// else
// {
//     Console.Write("Число не кратно одновременно 7 и 23");
// }

// Вариант №2
// int number, resultA, resultB;

// int RequestNumber(string text = "Enter number", string exitCmd = "q") // запрашивает число у пользователь (принимает текст запроса и команду выхода)
// {
//     while (true) // цикл выполняется до введения целого числа или "q"
//     {
//         Console.Write(text + ": ");
//         string? inputLine = Console.ReadLine();

//         if (inputLine == null) // Игнорируем пробел
//         {
//             continue;
//         }
//         if (inputLine.ToLower() == exitCmd) // Выходим из программы
//         {
//             Environment.Exit(0);
//         }
//         if (int.TryParse(inputLine, out int number)) // Выдаём полученное число
//         {
//             return number;
//         }
//     }
// }

// void ReadData() // чтение данных из сонсоли
// {
//     number = RequestNumber("Enter number");
// }

// void CalculateData() // Определяем кратность чисел
// {
//     resultA = number % 7;
//     resultB = number % 23;
// }

// void PrintData() // Вывод данных
// {
//     if (resultA == 0 && resultB == 0)
//     {

//         Console.WriteLine("Число кратно 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine("Число не кратно 7 и 23");
//     }
// }

// ReadData();
// CalculateData();
// PrintData();

// Вариант №3
string? inputLineA = Console.ReadLine();
if (inputLineA != null) 
Console.Write(((int.Parse(inputLineA) % 7 == 0) && (int.Parse(inputLineA) % 23 == 0)) ? ("Кратно") : ("Не кратно"));
