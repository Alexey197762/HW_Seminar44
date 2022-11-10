/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
Для решения задания использование цикла for является обязательным условием.
452 -> 11
82 -> 10
9012 -> 12*/
Console.WriteLine("Введите чесло");
int namber = int.Parse(Console.ReadLine());
int n = namber;
int len = 0;
int sum = 0;
while(namber >0)
{
    len++;
    namber = namber /10;
}

for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
        
    }
    Console.WriteLine($"сумма цифр {sum}");
