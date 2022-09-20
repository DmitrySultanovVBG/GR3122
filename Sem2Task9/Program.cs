//=================================================================================================================
// № 9 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//=================================================================================================================

void Variant1()
{
    Console.WriteLine("Метод №1");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    // Вариант №1
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void Variant2()
{
    Console.WriteLine("Метод №2");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 99);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    // Вариант №2
    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}

void Variant3()
{
    Console.WriteLine("Метод №3");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 99);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    // Вариант №3
    Char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

Variant1();
Variant2();
Variant3();