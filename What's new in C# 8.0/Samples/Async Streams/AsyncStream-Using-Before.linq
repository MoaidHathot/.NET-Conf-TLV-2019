<Query Kind="Program" />

void Main()
{
	using (var foo = new Foo())
	{
		
	}
}

class Foo : IDisposable
{
	public void Dispose()
	{
		"Disposed".Dump();
	}
}