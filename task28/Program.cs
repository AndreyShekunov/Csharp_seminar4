// Задача 28: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24
// 5 -> 120

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()); // с помощью return возвращаем число введеное с консоли
}

// Создаем метод расчета суммы от 1 до а
int ProdNumbersFrom1ToN(int n)
{
    if(n > 0) //если N больше 0, то работаем дальше
    {
        int prod = 1;
        for (int i = 2; i <= n; i++)
        {
            prod = prod * i; // копим произведение
        }
        return prod; // вернем накопившееся произведение
    }
    else
    {
        Console.WriteLine("N должно быть больше 0!");
        return -1; // неправильное произведение (код ошибки)
    }
}

int number = ReadNumber("Введите число N:");

int prod = ProdNumbersFrom1ToN(number);
Console.WriteLine($"Произведение элементов от 1 до N = {prod}");