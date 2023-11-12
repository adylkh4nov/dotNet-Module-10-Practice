using System;
using System.Collections.Generic;

public class House
{
    private List<IPart> parts = new List<IPart>();

    public void AddPart(IPart part)
    {
        parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("Дом построен!");
        foreach (var part in parts)
        {
            part.Build();
        }
    }
}