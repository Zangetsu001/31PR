using System;

public abstract class Figure
{
    private string name;

    public Figure(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get
        { 
            return name; 
        }
        set
        {
            name = value;
        }
    }

    public abstract double Area();
    public abstract double Perimeter();

    public virtual void Print()
    {
        Console.WriteLine($"Фигура: {Name}");
    }
}
