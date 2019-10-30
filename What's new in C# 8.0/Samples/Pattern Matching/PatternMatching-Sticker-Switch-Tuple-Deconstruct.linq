<Query Kind="Program" />

void Main()
{
	GetPrice(null).Dump();
}

enum ColorMode { Transparent, Fill, Border }

class Sticker
{
	public string Color { get; set; }
	public ColorMode ColorMode { get; set; }

	public double Size { get; set; }
	
	public void Deconstruct(out string color, out ColorMode colorMode)
	{
		color = Color;
		colorMode = ColorMode;
	}
}

double GetPrice(Sticker sticker)
{
	return sticker switch
	{
		("Whie", _) => 1 * sticker.Size,
		("Red", ColorMode.Fill) => 3 * sticker.Size,
		(_, ColorMode.Fill) => 2 * sticker.Size,
		(null, _) => throw new ArgumentNullException(),
		(_, _) => 1.5 * sticker.Size
		//_ => 1.5 * sticker.Size,
	};
}