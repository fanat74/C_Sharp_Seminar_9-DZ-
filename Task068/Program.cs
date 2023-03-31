// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое целое положительное число");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int numberM = Convert.ToInt32(Console.ReadLine());

int AkkFunction(int numN, int numM)
{
    
    if (numN == 0) return numM+1;
    else if (numM == 0)
    return AkkFunction(numN-1, 1);
    else return AkkFunction(numN-1, AkkFunction(numN, numM-1));
}
int akkFunction= AkkFunction(numberN, numberM);
Console.Write(akkFunction);