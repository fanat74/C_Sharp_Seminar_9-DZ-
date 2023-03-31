// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое положительное число");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int numberM = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbersInIntervals(numberN, numberM);
if (numberN<0||numberM<0)
Console.Write("Вводите только положительные числа");
else
Console.Write($"Сумма чисел в промежутке от {numberN} до {numberM} равна {sumNumbers}");


int SumNumbersInIntervals(int num1, int num2)
{
    int max= Math.Max(num1, num2);
    int min= Math.Min(num1, num2);
    if (min == max) return min;
    else return min + SumNumbersInIntervals(min + 1, max);
}

