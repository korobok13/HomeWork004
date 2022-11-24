// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
   int ost = 0;
   int num1 = 0;
   while (num > 0)
   {
        num1 = num % 10;
        ost = ost + num1;
        num = num / 10;
   }
return ost;
}
int result = SumNum(num);
Console.WriteLine(num+ " -> " +result);
