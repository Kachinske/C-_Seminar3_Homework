//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)

Console.WriteLine("Введите пятизначное число");
string Task19Number = Console.ReadLine()!;

if (Task19Number.Length == 5)
{
    if (Task19Number[0] == Task19Number[4] && Task19Number[1] == Task19Number[3])
    {
        Console.WriteLine($"Число {Task19Number} является полиндромом");
    }
    else
    {
        Console.WriteLine($"Число {Task19Number} не является полиндромом");
    }
}
else
{
    Console.WriteLine("Введено некорректное число");
}


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату первой точки по х");
int Xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату первой точки по y");
int Ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату первой точки по z");
int Za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату второй точки по х");
int Xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату второй точки по y");
int Yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату второй точки по z");
int Zb = int.Parse(Console.ReadLine()!);

Double size = Math.Sqrt(Math.Pow((Xb-Xa), 2) + Math.Pow((Yb-Ya), 2) + Math.Pow((Zb-Za), 2));
Console.WriteLine($"Расстояние между точками -> {size:f2}");


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите натуральное число");
int Task23Number = int.Parse(Console.ReadLine()!);
int i = 1;

while (i < Task23Number)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
    i++;
}
Console.Write($"{Math.Pow(Task23Number, 3)}");