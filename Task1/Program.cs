// Задача 25: Напишите метод, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B с использованием цикла.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;
Clear();
Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int Power = GetPower(A,B);
WriteLine(Power);


int GetPower(int num1, int num2)
{   
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
    result = result*num1; 
    }
    return result;
}