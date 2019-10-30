<Query Kind="Program" />

void Main()
{
	ILogger a = new Logger();
	Logger aa = new Logger();
	
	a.Log(new Exception());
	//aa.Log(new Exception());
}

interface ILogger
{
	void Log(string message);
	void Log(Exception ex)
		=> Log(ex.ToString());
}

class Logger : ILogger
{
	public void Log(string message)
		=> message.Dump();
}