/* Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит
 число A в натуральную степень B. Для решения задания использование цикла for является 
 обязательным условием. Не использовать встроенный метод возведения в степень.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int numberA = ReadInt32("Введите число A: ");
int numberB = ReadInt32("Введите число B: ");
degree(numberA, numberB);

void degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

int ReadInt32(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}