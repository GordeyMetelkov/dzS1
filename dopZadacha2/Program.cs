// Даны два числа a, b, такие что a < b. Вывести на экран сколько раз число a поместиться в числе b.;
Console.WriteLine("Введите число 'a'");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 'b'");
int b = Convert.ToInt32(Console.ReadLine());
int count = 1;
int c = a;
if (b > a)
{
    while (b - c >= a)
    {
        count++;
        c = c + a;
    }
    Console.Write("Число " + a + " поместится в число " + b + " " + count + " раз(а)");
}
else
{
    Console.WriteLine("Вы ввели значения чисел, не подходящих под условие 'a < b'");
}