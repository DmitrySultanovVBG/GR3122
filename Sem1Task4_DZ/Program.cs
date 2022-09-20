//=================================================================================================
// № 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//=================================================================================================

int numberA = 52;
int numberB = 85;
int numberC = 21;

// Вариант №1
int numberD = ((numberA > numberB) ? numberA : numberB);
int numberR = ((numberD > numberC) ? numberD : numberC);
int max = ((numberD > numberR) ? numberD : numberR);

// Вариант №2
// int max = Math.Max(numberA, Math.Max(numberB,numberC));

// Вариант №3
// int max = numberA > numberB ? numberA > numberC ? numberA : numberC : numberB > numberC ? numberB : numberC;

Console.WriteLine(max);