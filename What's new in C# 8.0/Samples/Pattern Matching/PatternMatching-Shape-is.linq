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
	if(obj is Circle circle)
	{
		return OptimizedPowOf2(circle.Radius) * Math.PI;
	}
	else if(obj is Rectangle square && square.X == square.Y)
	{
		//Sqaure
		return OptimizedPowOf2(square.X);
	}
	else if(obj is Rectangle rectangle)
	{
		return rectangle.X * rectangle.Y;
	}
	else if(obj is IShape shape)
	{
		throw new NotSupportedException();
	}
	else if(obj is null)
	{
		throw new ArgumentNullException();
	}
	
	throw new ArgumentException();
}




double OptimizedPowOf2(double value)
	=> value * value;