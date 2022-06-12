// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).;
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 0)
{
   Console.WriteLine("Вы ввели 0, попробуйте другое число"); 
}
else if (a%2 == 0)
{
    Console.WriteLine("Число является четным");
}
else 
{
    Console.WriteLine("Число не является четным");
}