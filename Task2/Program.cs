// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();
Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int Sum = sum(number);
WriteLine(Sum);

int sum(int Number)
{
    int result = 0;
    while (number>0)
    {
        result += number%10;
        number/=10;
    }
    return result;
}