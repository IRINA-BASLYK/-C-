
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа:");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberA > numberB)
{
    Console.WriteLine("max = ",numberA);

    if (numberA > numberC)
    {
        Console.WriteLine("max = ",numberA);
    }

else if (numberB > numberC)
        {
            Console.WriteLine("max = ",numberB);
        }
        else
        {
            Console.WriteLine("max = ",numberC);
        }
Console.WriteLine("максимальное из этих чисел:");

}

