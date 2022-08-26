Console.Clear();
Console.Write("Введите число a: ");
double numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
double numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("a = ");
Console.Write(numberA);
Console.Write(" b = ");
Console.Write(numberB);

if(numberA > numberB)
{
    Console.Write(" max = ");
    Console.Write(numberA);
}
else
{
    Console.Write(" max = ");
    Console.Write(numberB);
}