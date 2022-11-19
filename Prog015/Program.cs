/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/
void Zadacha15()
{
    Console.WriteLine("Введите цифру, обозначающую день недели");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 6 || number == 7)
    {
        Console.WriteLine("Сегодня выходной");
    }
    else if (0 < number && number < 6)
    {
        Console.WriteLine("Сегодня рабочий день");
    }
    else{
        Console.WriteLine("Не верное число");
    }

}

Zadacha15();
