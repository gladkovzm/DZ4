//\\ Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число В: ");
// int B = Convert.ToInt32(Console.ReadLine());
// if (B == 0)
// {
//     Console.Write($"Число {A} в степени {B} = 1");
// }
// else
// {
//     int work = A;
//     for (int i = 2; i <= B; i++)
//     {
//         A *= work;
//     }
//     Console.WriteLine($"Число {work} в степени {B} = {A}");
// }


//\\ Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum(int num)
// {
//     int sum=0;
//     while (num > 0)
//     {
//         sum+=num%10;
//         num/=10;
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Напишите число, что бы вывести сумму его чисел: ");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма чисел = {Sum(A)}");

  

//\\ Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Введите количество элементов  массива");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число для случайного диапазона чисел");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число для случайного диапазона чисел");
int max = Convert.ToInt32(Console.ReadLine());
int[] arrayz = new int[num]; 
Random rand = new Random(); 
for (int i = 0; i < arrayz.Length; i++)
{
    arrayz[i] = rand.Next(min, max + 1);
    Console.Write($"{arrayz[i]}, ");
}
