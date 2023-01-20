// Задача 3. Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int number = 1;
int result = 1; 

while (number <= N)
{
    result *= number;
    number++;
}

Console.WriteLine("Произведение числе от 1 до " + N + " равно " + result);