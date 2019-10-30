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
	return obj switch
	{
		Rectangle square when square.X == square.Y => OptimizedPowOf2(square.X),
		Rectangle rectangle => rectangle.X * rectangle.X,
		Circle circle => OptimizedPowOf2(circle.Radius) * Math.PI,
		IShape s => throw new NotSupportedException(),
		null => throw new ArgumentNullException(),
		{ } => throw new ArgumentException(),
		//_ => throw new ArgumentException()
	};
}





double OptimizedPowOf2(double value)
	=> value * value;