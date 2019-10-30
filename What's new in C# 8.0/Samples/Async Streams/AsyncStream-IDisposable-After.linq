<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	var foo = new Foo();
	
	await foo.DisposeAsync();
}

class Foo : IAsyncDisposable
{
	public async ValueTask DisposeAsync()
	{
		await Task.Delay(500);
		
		"Disposed".Dump();
	}
}