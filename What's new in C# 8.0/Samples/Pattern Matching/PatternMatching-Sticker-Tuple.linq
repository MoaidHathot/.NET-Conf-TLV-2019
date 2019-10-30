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
}

double GetPrice(Sticker sticker)
{
	return (sticker?.Color, sticker?.ColorMode) switch
	{
		("White", _) => 1 * sticker.Size,
		("Red", ColorMode.Fill) => 3 * sticker.Size,
		(_, ColorMode.Fill) => 2 * sticker.Size,
		(null, null) => throw new ArgumentNullException(),
		(_, _) => 1.5 * sticker.Size
		//_ => 1.5 * sticker.Size,
	};
}