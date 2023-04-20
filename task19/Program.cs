﻿// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите координату X первой точки и нажмите enter: ");
int y1 = ReadInt("Введите координату Y первой точки и нажмите enter: ");
int z1 = ReadInt("Введите координату Z первой точки и нажмите enter: ");
int x2 = ReadInt("Введите координату X второй точки и нажмите enter: ");
int y2 = ReadInt("Введите координату Y второй точки и нажмите enter: ");
int z2 = ReadInt("Введите координату Z второй точки и нажмите enter: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние между точками в 3D пространстве  {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}