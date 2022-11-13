Start();
void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("Задание 1 (введите 1)");
        System.Console.WriteLine("Задание 2 (введите 2)");
        System.Console.WriteLine("Задание 3 (введите 3)");
        System.Console.WriteLine("End (если введено - 0)");
        int numTask = Convert.ToInt32(Console.ReadLine());

        switch (numTask)
        {
            case 0: return; 
            case 1: NaturalNumbersRecursion(); break;
            case 2: SumNaturalNumbersRecursion(); break;
            case 3: AckermanFunction(); break;
            default: System.Console.WriteLine("Ошибка ввода"); break;
        }
    }
}
// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumbersRecursion()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    NaturalNumber(number, count);
    
    void NaturalNumber(int n, int count)
    {
        if (count > n)
        {
            return;
        }
        else
        {
            NaturalNumber(n, count + 1);
            Console.Write(count + " ");
        }
    }
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
void SumNaturalNumbersRecursion()
{
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    PrintSumNumber(m, n);
    
    // метод "печать сумма чисел от M до N"
    
    void PrintSumNumber(int m, int n)
    {
        Console.Write(Sum(m-1, n));
    }
    
    // расчет суммы чисел от M до N
    
    int Sum(int m, int n)
    {
        int count = m;
        if (m == n)
        return 0;
        else
        {
            m++;
            count = m + Sum(m, n);
            return count;
        }
    }
}
// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void AckermanFunction()
{
    Console.Write("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    
    if (numberM < 0 || numberN < 0)
    {
        Console.WriteLine("Некорректный ввод чисел");
        return;
    }
    AkkermanFunction(numberM, numberN);
    
    // метод Аккермана
    void AkkermanFunction(int numberM, int numberN)
    {
        Console.Write (Akkerman (numberM, numberN));
    }
    // расчет функции Аккермана
    
    int Akkerman(int numberM, int numberN)
    {
        if (numberM == 0)
        {
            return numberN + 1;
        }
        else if (numberN == 0 && numberM > 0)
        {
            return Akkerman(numberM - 1, 1);
        }
        else
        {
            return (Akkerman(numberM - 1, Akkerman(numberM, numberN - 1)));
        }
    }
}
