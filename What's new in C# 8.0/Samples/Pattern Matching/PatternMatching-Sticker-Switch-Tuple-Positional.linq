<Query Kind="Program" />

void Main()
{
	GetPrice(new Sticker { Color = "Red", ColorMode = ColorMode.Fill }).DumpDecompile();
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

	public void Deconstruct(out string color, out ColorMode colorMode, out double size)
	{
		color = Color;
		colorMode = ColorMode;
		size = Size;
	}
}

double GetPrice(Sticker sticker)
{
	return sticker switch
	{
		var (color, colorMode, size) when color == "Red" && colorMode == ColorMode.Fill => 3 * sticker.Size,
		var (_, colorMode, size) when colorMode == ColorMode.Fill => 2 * sticker.Size,
		var (color, _, _) when color is null => throw new ArgumentNullException(),
		var (_, _, size) => 1.5 * size,
		//_ => 1.5 * sticker.Size,
	};
}