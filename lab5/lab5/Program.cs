﻿//Var 12
using System;
public class Circle
{
    private double radius;
    public double Radius
    {
        get { return radius; }
        set
        {
            if (value >= 0)
                radius = value;
        }
    }
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }
}
public class Triangle
{
    private double side_length;
    private double height;
    public double Side_length
    {
        get { return side_length; }
        set
        {
            if (value >= 0) side_length = value;
        }
    }
    public double Height
    {
        get { return height; }
        set
        {
            if (value >= 0) height = value;
        }
    }
    public double CalculateArea()
    {
        return (side_length*height)/2;
    }
}
class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        Triangle triangle = new Triangle();
        double radius;
        double height;
        double side_length;
        Console.Write("Отримання площі та довжини круга");
        Console.Write("\n\nВведіть радіус круга: ");
        while (!double.TryParse(Console.ReadLine(), out radius) || radius < 0)
        {
            Console.WriteLine("Неправильне значення. Радіус має бути додатнім");
            Console.Write("Введіть радіус круга: ");
        }
        circle.Radius = radius;
        Console.WriteLine($"Площа круга з радіусом {circle.Radius} дорівнює {circle.CalculateArea():F2}");
        Console.WriteLine($"Довжина круга з радіусом {circle.Radius} дорівнює {circle.CalculateCircumference():F2}");
        Console.Write("\nПерейти до роботи з трикутником? (y/n)");

        char a = Convert.ToChar(Console.ReadLine());
        if (a == 'n') { }
        else if (a == 'y')
        {
            Console.Clear();
            Console.WriteLine("Отримання площі трикутника");
            Console.Write("\nВведіть довжину сторони трикутника: ");
            while (!double.TryParse(Console.ReadLine(), out side_length) || side_length < 0)
            {
                Console.WriteLine("Неправильне значення. Сторона має бути додатнім");
                Console.Write("Введіть довжину сторони трикутника: ");
            }
            triangle.Side_length = side_length;
            Console.Write("Введіть висоту трикутника: ");
            while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
            {
                Console.WriteLine("Неправильне значення. Висота має бути додатнім");
                Console.Write("Введіть висоту трикутника: ");
            }
            triangle.Height = height;
            Console.WriteLine($"Площа трикутника зі стороною {triangle.Side_length} і висотою {triangle.Height} дорівнює {triangle.CalculateArea():F2}");
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.Write("Неправильне значення");
            Console.ReadKey();
        }
    }
}