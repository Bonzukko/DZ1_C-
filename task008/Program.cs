﻿Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write(N);
Console.Write(" -> ");

if(N == 1)
{
    Console.Write(" ");
}
else
{
    if(N>1)
    {
        int number = 2;
        while(number<=N)
        {
            Console.Write(number);
            Console.Write(", ");
            number+=2;
        }
    }
    else
    {
      int number = 0;
        while(number>=N)
        {
            Console.Write(number);
            Console.Write(", ");
            number=number-2;  
        }
    }
}