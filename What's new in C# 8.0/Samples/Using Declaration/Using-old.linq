<Query Kind="Program" />

void Main()
{
	M();
}

public void M()
{
	using (var test = new MyDisposable())
	{
		test.Dump();
	}
}

class MyDisposable : IDisposable
{
	public void Dispose()
	{
		"Disposed".Dump();
	}
}
