// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]

int[] array = new int[8]; // создали массив на 8 элементов

Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 2);
}

Console.WriteLine(string.Join(", ", array)); // array - итерируемый объект (объект который можно перебирать)





// Вариант вывода массива через цикл
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }


//мое решение задачи 30

// int length = array.Length;
// int index = 0;
// while(index < length)
// {
//     array[index] = new Random().Next(0, 2);
//     index++;
// }

// int count = array.Length;
// int position = 0;
// while(position < count)
// {
//     Console.Write(array[position] + " ");
//     position++;
// }