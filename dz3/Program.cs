/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
using System;
*/
/*
void Func(int num1)
{
    if(num1/10000 == num1%10 && (num1 / 1000)%10 == (num1 % 100) / 10)
    {
        Console.WriteLine($"the number {num1} is polindrom");
    }
    else
    {

        Console.WriteLine($"the number {num1} is not polindrom");

    }

}
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Func(num);
*/
/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53
*/
/*
using System.Numerics;

double LongLine(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double length=Math.Sqrt((x1- x2)*(x1 - x2)+(y1- y2)*(y1 - y2)+(z1- z2)*(z1-z2));
    Console.WriteLine($"length={Math.Round(length,2)}");
    return length;
}
Console.Write("inpu x of A: ");
int x_A = Convert.ToInt32(Console.ReadLine());
Console.Write("inpu y of A: ");
int y_A = Convert.ToInt32(Console.ReadLine());
Console.Write("inpu z of A: ");
int z_A = Convert.ToInt32(Console.ReadLine());
Console.Write("inpu x of B: ");
int x_B = Convert.ToInt32(Console.ReadLine());
Console.Write("inpu y of B: ");
int y_B = Convert.ToInt32(Console.ReadLine());
Console.Write("inpu z of B: ");
int z_B = Convert.ToInt32(Console.ReadLine());

LongLine(x_A, y_A, z_A,x_B,y_B, z_B);
*/
/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void Cub(int N)
{
   
    int i = 1;
    
    while( i <= N)
    {
       
        int cub =  (i * i * i);
        Console.Write(cub+"  ");
        i++;
    }
    
}
Console.Write("input N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Cub(numN);
*/