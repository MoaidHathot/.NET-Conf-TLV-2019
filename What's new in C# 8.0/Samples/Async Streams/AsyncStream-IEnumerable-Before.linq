<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	foreach(var item in GetRandomNumbers(10))
	{
		item.Dump();
	}
}

public IEnumerable<int> GetRandomNumbers(int count)
{
	var random = new Random();

	for (var index = 0; index < count; ++index)
	{
		var number = random.Next(500, 4001);

		yield return number;
	}
}
