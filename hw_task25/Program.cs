// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber(string message) // метод считывания числа с консоли
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberAToNaturalPowerB(int a, int b) // метод возведения числа A в натуральную степень B
{
    if(a > 0 && b > 0)
    {
        int result = 1;
        for (int i = 1; i <= b; i++)
            {
                result = result * a; // копим результат
            }
        return result; // вернем результат выполнения метода
    }
    else
    {
        Console.WriteLine("Числа А и B должны быть больше 0!");
        return -1; // неправильная сумма (код ошибки)
    }
    
}
int numberA = ReadNumber("Введите число А:");
int numberB = ReadNumber("Введите число B:");

int res = NumberAToNaturalPowerB(numberA, numberB);
Console.WriteLine($"Результат = {res}");