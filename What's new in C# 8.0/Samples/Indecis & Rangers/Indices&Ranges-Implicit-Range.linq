<Query Kind="Program" />

void Main()
{
	var test = new Test(10);

	test[0..3].Dump();
	test[0..^0].Dump();
	test[new Range(Index.Start, Index.End)].Dump();
}

class Test
{
	public int Length { get; }

	public Test(int maximum)
	{
		Length = maximum;
	}

	public IEnumerable<int> Slice(int start, int end) => Enumerable.Range(start, end - start);
}