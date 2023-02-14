// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Массив чисел от {number} до 1:");
System.Console.WriteLine(NumbersArray(number, 1));
string NumbersArray(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + ", " + NumbersArray(start - 1, end));
}
