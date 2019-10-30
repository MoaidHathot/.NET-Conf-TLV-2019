<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	await Test();
}

public async Task Test()
{
	await using var test = new MyDisposable();

	"Processing".Dump();
	
	test.Dump();
}

class MyDisposable : IAsyncDisposable
{
	public async ValueTask DisposeAsync()
	{
		await Task.Delay(TimeSpan.FromSeconds(1));
		
		"Disposed".Dump();
	}
}