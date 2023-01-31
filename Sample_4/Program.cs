// Напишите программу, которая принимает на вход число  и проверяет, кратно ли оно одновременно 7 и 23
//14--> нет
//46-->нет
//161-->да

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = 7;
int c = 23;

if (a % b != 0) 
{
     Console.WriteLine($"Число {a} не кратно {b} ");
}
else 
{
     Console.WriteLine($"Число {a}  кратно  {b} ");
}
if (a % c != 0)
{
     Console.WriteLine($"Число {a} не кратно {c} ");
}
else 
{
     Console.WriteLine($"Число {a}  кратно  {c} ");
}