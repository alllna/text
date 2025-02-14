
using System;

public class Rectangle
{
    private double width;
    private double height;

    public Rectangle()
    {
        width = 1.0;
        height = 1.0;
    }

    public Rectangle(double w, double h)
    {
        Width = w;
        Height = h;
    }

    public double Width
    {
        get { return width; }
        set
        {
            if (value > 0)
                width = value;
            else
                throw new ArgumentException("Ширина должна быть положительной.");
        }
    }

    public double Height
    {
        get { return height; }
        set
        {
            if (value > 0)
                height = value;
            else
                throw new ArgumentException("Высота должна быть положительной.");
        }
    }

    public double Area()
    {
        return width * height;
    }

    ~Rectangle()
    {
        Console.WriteLine("Объект Rectangle уничтожен.");
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(5.0, 3.0);
        Console.WriteLine($"Площадь прямоугольника: {rect.Area()}");
    }
}


