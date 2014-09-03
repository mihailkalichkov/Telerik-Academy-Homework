using System;
using LoopsAndIfStataments;

public class Chef
{
    public void Cook()
    {
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();
        Peel(potato);
        Peel(carrot);
        Cut(potato);
        Cut(carrot);
        Bowl bowl;
        bowl = GetBowl();
        bowl.Add(carrot);
        bowl.Add(potato);
    }

    private static void Peel(Vegetable vegatable)
    {
        Console.WriteLine("Peeling");
    }

    private Potato GetPotato()
    {
        return new Potato();
    }

    private Carrot GetCarrot()
    {
        return new Carrot();
    }

    private void Cut(Vegetable vegetable)
    {
    }

    private Bowl GetBowl()
    {
        return new Bowl();
    }
}