<Query Kind="Program" />

void Main()
{
	var test = new Test(10);
	
	test[^1].Dump();
	test[new Index(4)].Dump();
}

class Test
{
	public int Count { get; }
	
	public Test(int maximum)
	{
		Count = maximum;
	}
	
	public int this[int index] => index;
}

// Define other methods, classes and namespaces here