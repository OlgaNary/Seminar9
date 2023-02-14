// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(NumbersSum(numberM - 1, numberN));

//Метод находит сумму чисел от m до n:
int NumbersSum(int m, int n)
{
    int sum = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        sum = m + NumbersSum(m, n);
        return sum;
    }
}

