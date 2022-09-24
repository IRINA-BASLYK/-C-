
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите числo:");
double numberA = double.Parse(Console.ReadLine());

if (numberA%2 ==0)
{
    Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число не является чётным");
}


