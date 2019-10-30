<Query Kind="Program" />

void Main()
{
	ILogger a = new Logger();
	Logger aa = new Logger();
	
	a.Log("ILogger");
	aa.Log("Logger");
}

interface ILogger
{
	void Log(string message);
}

class Logger : ILogger
{
	public void Log(string message)
		=> message.Dump();
}