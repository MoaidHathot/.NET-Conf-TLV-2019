<Query Kind="Program" />

void Main()
{
	string s = null;
	
	if(s is { Length: var length })
	{
		length.Dump();
	}
}

// Define other methods, classes and namespaces here
