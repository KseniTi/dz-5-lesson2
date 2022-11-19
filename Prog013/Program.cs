/*Задача 13: Напишите программу, которая с помощью
деления выводит третью цифру заданного числа или
сообщает, что третьей цифры нет.*/

void Zadacha13()
{
    Console.WriteLine("Введите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else if (number < 1000)
    {
        Console.WriteLine(number % 10);
    }
    else{
        Console.WriteLine("Не знаю");
    }

}

Zadacha13();
