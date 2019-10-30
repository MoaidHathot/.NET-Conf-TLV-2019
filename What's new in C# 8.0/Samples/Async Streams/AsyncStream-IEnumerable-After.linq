<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	await foreach (var item in GetRandomNumbersAsync(10))
	{
		item.Dump();
	}
}

public async IAsyncEnumerable<int> GetRandomNumbersAsync(int count)
{
	var random = new Random();

	for (var index = 0; index < count; ++index)
	{
		var number = random.Next(500, 4001);

		await Task.Delay(number);

		yield return number;
	}
}
