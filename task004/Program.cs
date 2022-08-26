Console.Write("Введите число a: ");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
double numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
double numberC = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write(numberA);
Console.Write(" ");
Console.Write(numberB);
Console.Write(" ");
Console.Write(numberC);
Console.Write(" -> ");
if(numberA > numberB)
{
    if(numberA > numberC)
    {
       Console.Write(numberA); 
    }
    else
    {
        Console.Write(numberC); 
    }
}
else
{
    if(numberB>numberC)
    {
       Console.Write(numberB); 
    }
    else
    {
        Console.Write(numberC); 
    }
}