// Дано N секунд. Вывести время в формате часы:минуты:секунды.
Console.WriteLine("Введите количество секунд");
int N = Convert.ToInt32(Console.ReadLine());
int hours = 0;
int min = 0;
int sec = 0;
Console.WriteLine("Время в формате часы:минуты:секунды");
if (N >= 3600)
{
    hours = N / 3600;
    Console.Write(hours);
    Console.Write(":");
    if (N%3600 > 60)
    {
        min = N%3600 / 60;
        Console.Write(min);
        Console.Write(":");
        sec = N%3600%60;
        Console.Write(sec);
    }
    else 
    {
        sec = N%3600;
        Console.Write("0:");
        Console.Write(sec);
    }
}
else 
{
    Console.Write("0:");
    if (N >= 60)
        {
            min = N / 60;
            sec = N%60;
            Console.Write(min);
            Console.Write(":");
            Console.Write(sec);
        }
    else 
    {
        Console.Write("0:");
        sec = N;
        Console.Write(sec);
    }
}