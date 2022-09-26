// Задача 29: Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.
//1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33]

using static System.Console;
Clear();
Write("Введите размер массива: ");
int size = int.Parse(ReadLine()!);
int[] array = GetArray(size);
PrintArray(array);

int[] GetArray(int length)
{
    int[] result = new int[length];
    for(int i=0; i<length; i++)
    {
        result[i] = new Random().Next();
    }
    return result;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for(int i=0; i<inArray.Length-1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]");
}

