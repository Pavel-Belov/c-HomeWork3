// Задача 1. Найти кубы чисел от 1 до N

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int value = 0;
int number = 1;

while (number <= N)
{
    value = number;
    value *= value *= value;
    Console.WriteLine("Куб числа " + number + " равен " + value);
    number++;
}