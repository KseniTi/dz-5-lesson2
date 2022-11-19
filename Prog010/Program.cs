//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Zadacha10()
{
    Console.WriteLine("Введите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());

    int a = number / 100;
    int b = number / 10;
    int c = b - a * 10;
    
    Console.WriteLine($"{c}");

}

Zadacha10();
