//===========================================================================================================
// № 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//===========================================================================================================

    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    int thirdDigit = number % 10;

    Console.WriteLine(thirdDigit);