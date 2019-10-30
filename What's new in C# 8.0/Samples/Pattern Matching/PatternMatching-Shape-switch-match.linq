<Query Kind="Program" />

void Main()
{
	
}

interface IShape
{
	
}

class Rectangle : IShape
{
	public double X { get; set; }
	public double Y { get; set; }
}

class Circle : IShape
{
	public double Radius { get; set; }
}

double GetArea(object obj)
{
	switch (obj)
	{
		case Rectangle square when square.X == square.Y:
			return OptimizedPowOf2(square.X);
		case Rectangle rectangle:
			return rectangle.X * rectangle.X;
		case Circle circle:
			return OptimizedPowOf2(circle.Radius) * Math.PI;
		case IShape shape:
			throw new NotSupportedException();
		case null:
			throw new ArgumentNullException();
		default:
			throw new ArgumentException();
	}
}





double OptimizedPowOf2(double value)
	=> value * value;

