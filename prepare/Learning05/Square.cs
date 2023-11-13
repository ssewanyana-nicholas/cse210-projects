using System;

class Square : Shape
{
    private int _side = 0;

    public int GetSide()
    {
        return _side;

    }

    public void SetSide(int side)
    {
        _side = side;

    }

    public override double GetArea()
    {
        return _side * _side;
    }

}