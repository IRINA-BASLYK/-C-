
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число:");
string NumberStr;
NumberStr = Console.ReadLine();
int n = int.Parse(NumberStr);
int a = n(1);
while (a >= n)
{
    Console.WriteLine(a);
    a = a + 1;
}
