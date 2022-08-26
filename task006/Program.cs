Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write(number);
Console.Write(" - ");
if(number%2==0)
{
   Console.Write("Чётное"); 
}
else
{
   Console.Write("Не чётное");
}
