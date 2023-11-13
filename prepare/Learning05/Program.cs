using System;

class Program
{
    static void Main(string[] args)
    {
        Square pSquare = new Square();
        pSquare.SetColor("Red");
        pSquare.SetSide(10);

        Rectangle Xrectangle = new Rectangle();
        Xrectangle.SetColor("blue");
        Xrectangle.SetLength(5);
        Xrectangle.SetWidth(4);


        Circle Zcircle = new Circle();
        Zcircle.SetColor("Pink");
        Zcircle.SetRadius(2);


        List<Shape> shapes = new List<Shape>();
        shapes.Add(pSquare);
        shapes.Add(Xrectangle);
        shapes.Add(Zcircle);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.Getcolor();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }


    }

}