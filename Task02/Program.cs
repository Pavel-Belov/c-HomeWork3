// Задача 2. Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int num = 0;
int sum = 0;
int count = 1;

while (count <= number)
{
    num = number % (count * 10) / count;
    sum += num;
    count *= 10;
}

Console.WriteLine("Сумма цифр в числе " + number + " равна " + sum);