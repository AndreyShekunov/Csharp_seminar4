// Задача 24: Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

// создаем метод ввода числа с именем "ReadNumber"
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()); // с помощью return возвращаем число введеное с консоли
}

// Создаем метод расчета суммы от 1 до а
int SumNumbersFrom1ToA(int a)
{
    if(a >= 1) //если А больше или ровно 1, то работаем дальше
    {
        int sum = 0;
        for (int i = 1; i <= a; i++)
        {
            sum = sum + i; // копим сумму
            //sum += 1; // альтернативный способ записи выше
        }
        return sum; // вернем накопившуюся сумму
    }
    else
    {
        Console.WriteLine("А должна быть больше 1!");
        return -1; // неправильная сумма (код ошибки)
    }
}
//вызываем метод "ReadNumber" и сразу присваиваем значение которое вернул метод
int number = ReadNumber("Введите число А:");
// Вызываем метод "SumNumbersFrom1ToA" для вычисления суммы
int summa = SumNumbersFrom1ToA(number);
Console.WriteLine($"Сумма элементов от 1 до А = {summa}");
