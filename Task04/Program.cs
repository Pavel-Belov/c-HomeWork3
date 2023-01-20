// Задача 4. Показать кубы чисел, заканчивающихся на четную цифру

// Вариант 1. Если имеется в виду какое-то одно число
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 10 % 2 == 0)
{
    Console.WriteLine("Число " + number + " заканчивается на чётную цифру. " + number + " в кубе равно " + (number * number * number));
}
else
{
    Console.WriteLine("Число " + number + " не заканчивается на чётную цифру, условие задачи не соблюдено.");
}

// Варинт 2. Если имеется в виду числа от 1 до N
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int i = 2;
int value = 0;

while (i <= N)
{
    value = i * i * i;
    Console.WriteLine(i + " в кубе равно " + value);
    i += 2;
}