<Query Kind="Program" />

#nullable enable

void Main()
{
	
}

void Strange()
{
	string notNull = null!;
}

void Interesting1()
{
	var dictionary = new Dictionary<string, string>();
	
	dictionary.TryGetValue("", out var value);
}

void Interesting2()
{
	string[] strings = new []{ "a", "b", "c" };

	var first = strings.FirstOrDefault();
}