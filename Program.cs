Console.Clear();
// //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите два числа: ");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// if(a>b)
// {
//    Console.WriteLine($"Число {a} больше числа {b}."); 
// }
// else
// {
//     Console.WriteLine($"Число {b} больше числа {a}."); 
// }

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите три числа: ");
// int a1 = int.Parse(Console.ReadLine());
// int b1 = int.Parse(Console.ReadLine());
// int c1 = int.Parse(Console.ReadLine());
// int max = a1;
// if(b1>max) max=b1;
// if(c1>max) max=c1;
// Console.WriteLine($"Максимальное число - {max}. ");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// if(num%2==0)
// {
//     Console.WriteLine($"{num} - четное число. ");
// }
// else
// {
//     Console.WriteLine($"{num} - нечетное число. ");


// }

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int Num = 1;

while(Num<=N)
{
    if(Num%2==0)
    {
        Console.WriteLine(Num);
    }
Num++;
}

