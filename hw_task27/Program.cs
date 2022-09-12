// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// Например:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message) // метод считывания числа с консоли
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigital(int num) // метод суммирования цифр числа
{
    num = Math.Abs(num);
    if(num != 0)
    {
        int result = 0;
        int tempNumber = num;
        while(tempNumber > 0)
        {
            int digital = tempNumber % 10;
            result = result + digital;
            tempNumber = tempNumber / 10;
        }
        return result;
    }
    else
    {
        return 1;
    }
}
int number = ReadNumber("Введите число:");

int res = SumDigital(number);
Console.WriteLine($"Результат = {res}");
