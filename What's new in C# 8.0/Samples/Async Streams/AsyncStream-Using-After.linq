<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	await using(var foo = new Foo())
	{
		
	}	
}

class Foo : IAsyncDisposable
{
	public async ValueTask DisposeAsync()
	{
		await Task.Delay(500);

		"Disposed".Dump();
	}
}