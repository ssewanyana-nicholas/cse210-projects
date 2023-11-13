using System;

class Shape
{
    protected string _color;

    public string Getcolor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return -1;
    }
}