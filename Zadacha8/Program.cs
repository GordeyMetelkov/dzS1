//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
if (N == 0)
{
    Console.WriteLine("Вы ввели 0, нет четных чисел в промежутке");
}
if (N > 0)
{
    Console.WriteLine("Все четные числа:"); 
    while (a <= N)
    {
        if (a%2 > 0)
        {
            a++;
        }
        else
        {
            Console.Write(a);
            Console.Write(" ");
            a = a + 2; 
        }
    }
}
if (N < 0)
{
    Console.WriteLine("Все четные числа:");
    while (Math.Abs(a) <= Math.Abs(N))
    {
        if (a%2 > 0)
        {
            a = a + 1;
        }
        else
        {
            Console.Write(-a);
            Console.Write(" ");
            a = a + 2; 
        }
    }
}