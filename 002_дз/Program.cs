
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;
int min = numberB;


if (numberA > numberB)
{
    max = numberA;
    min = numberB;
}

   // else 
  //  {
   //     Console.WriteLine("Числа равны");
   // }


Console.WriteLine("БОЛЬШЕЕ");
Console.Write("max =");
Console.WriteLine(max); 

Console.WriteLine("МЕНЬШЕЕ");
Console.Write("min =");
Console.WriteLine(min);




