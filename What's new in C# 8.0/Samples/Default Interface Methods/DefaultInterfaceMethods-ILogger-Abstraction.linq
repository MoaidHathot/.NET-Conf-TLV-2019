<Query Kind="Program" />

void Main()
{
	ILogger a = new Logger();
	ILogger2 b = new Logger();

	a.Log(new Exception());
	b.Log(new Exception());
}

interface ILogger
{
	void Log(string message);
	void Log(Exception ex)
		=> Log(ex.ToString());
}

interface ILogger2 : ILogger
{
	abstract void ILogger.Log(Exception ex);
}

class Logger : ILogger2
{
	public void Log(string message)
		=> message.Dump();

	public void Log(Exception ex)
		=> ex.Dump();
}