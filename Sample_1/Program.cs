// Напишите программу, которая выводит случайное число  из отрезка [10, 99] и показывает наибольщую цифру числа:
// 78-->8
// 12-->2
// 85-->8


int num = new Random().Next(10, 100); // генерирует целое число
int num1 = num/10;
int num2 = num % 10;
Console.WriteLine(num);
Console.WriteLine(num1);
Console.WriteLine(num2);

if (num1>num2)
{
    Console.WriteLine($"{num1} ");
}
else
{
    Console.WriteLine($"Наибольшее число: {num2} ");
}
