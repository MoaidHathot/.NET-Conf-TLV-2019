<Query Kind="Program" />

void Main()
{
	var foo = new Foo();
	
	foo.Dispose();
}

class Foo : IDisposable
{
	public void Dispose()
	{
		"Disposed".Dump();
	}
}
