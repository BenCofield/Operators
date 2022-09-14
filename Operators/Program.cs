using System;
using Operators;

//Operators

Console.WriteLine("Enter two integers");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());



int quotient = a / b;
int remainder = a % b;

Console.Write($"a + b = {(a+b)}\n" +
              $"a - b = {a-b}\n" +
              $"a * b = {a*b}\n" +
              $"a / b = {quotient} remainder {remainder}\n");

//Area of a circle
Console.WriteLine("Enter the radius for your circle:");
var radius = double.Parse(Console.ReadLine());

var area = Operators.Methods.AreaOfCircle(radius);
Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();