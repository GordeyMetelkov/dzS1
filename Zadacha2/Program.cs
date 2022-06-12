// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine ("Введите число a");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите число b");
int b = Convert.ToInt32 (Console.ReadLine());
if (a > b)
{
    Console.WriteLine ("Максимальное из двух чисел");
    Console.Write (a);
}
else if (a < b)
{
    Console.WriteLine ("Максимальное из двух чисел");
    Console.Write (b);
}
else if (a == b)
{
    Console.WriteLine ("Вы ввели равнозначные числа");
}