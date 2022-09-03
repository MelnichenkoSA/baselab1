using System;

int X;

int Y;

Console.WriteLine("Введите число Х");
X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Y");
Y = Convert.ToInt32(Console.ReadLine());

//int c = X;

//X = Y;

//Y = c;

X = X - Y;

Y = Y + X;

X = -(X - Y);

Console.WriteLine($"X = {X}, Y = {Y}");