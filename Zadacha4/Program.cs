// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел;
Console.WriteLine("Введите число a");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число c");
int c = Convert.ToInt32 (Console.ReadLine());
int max;
if (a >= b)
{
    max = a;
}
else
{
   max = b;
} 
    if (max >= c)
    {
        Console.Write ("Максимальное из трех чисел - ");
        Console.Write (max);
    }
    else
    {
        max = c;
        Console.Write ("Максимальное из трех чисел - ");
        Console.Write (max);
    }