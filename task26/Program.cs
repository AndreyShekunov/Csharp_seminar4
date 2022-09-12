// Задача 26: Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// Например:
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int numberOfDigital(int n) // метод определения кол-ва цифр в числе
{
    int i = 0;
    if(n == 0) // проверка ровно ли число 0
    {
        i = 1;
    }
    else
    {
        for (i = 0; n > 0; i++)
        {
            n = n / 10;
        }
    }
    return i;
}
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int digital = numberOfDigital(number);
Console.WriteLine($"Количество цифр в числе {number} = {digital}");