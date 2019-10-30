<Query Kind="Program" />

void Main()
{
	
}

enum ColorMode { Fill, Border }

class Sticker
{
	public string Color { get; set; }
	public ColorMode ColorMode { get; set; }
	
	public double Size { get; set; }
}

class TransparentSticker : Sticker
{
	
}

double GetPrice(Sticker sticker)
{
	return sticker switch
	{
		{ Color: "White", Size: var size } => 1 * size,
		TransparentSticker { Color: "Red", Size: var size } => 1.5 * size,
		{ Color: "Red", ColorMode: ColorMode.Fill, Size: var size } => 3 * size,
		{ ColorMode: ColorMode.Fill, Size: var size } => 2 * size,
		{ Size: var size } => 1.5 * size,		
		null => throw new ArgumentNullException(),
		//{ } => throw new NotSupportedException(),
		//_ => throw new NotSupportedException(),
	};
	
	//Without null it throws: SwitchExpressionException(Non-Exaustive switch expression failed to match its input)
}