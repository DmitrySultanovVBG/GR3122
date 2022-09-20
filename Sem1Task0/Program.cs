//==============================================================================================================
// № 0 Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
//==============================================================================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outNumber = 0;

    DateTime d1 = DateTime.Now;
    for (int i = 0; i < 10000000; i++)
    {
        outNumber = inputNumber * inputNumber;
    }

    DateTime d2 = DateTime.Now;
    Console.WriteLine(d2 - d1);

    //int outNumber = (int)Math.Pow(inputNumber,2);
    Console.WriteLine(outNumber);
}
