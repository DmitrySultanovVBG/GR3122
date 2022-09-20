//============================================================================================================
// № 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//============================================================================================================

Console.WriteLine("Введите число A: ");
string? inputLineA = Console.ReadLine();
Console.WriteLine("Введите число B: ");
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    if (inputNumberA > inputNumberB)
    {
        Console.WriteLine("Число A > B");
    }
    else
    {
        Console.WriteLine("Число B > A");
    }
}
