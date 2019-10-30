<Query Kind="Program" />

void Main()
{
	ILogger a = new Logger();

	a.Log("C# 8");
	a.Log(new Exception());
}

interface ILogger
{
	void Log(string message);
	void Log(Exception ex)
		=> Log(ex.ToString());

	//Accessible only inside ILogger
	public static string prefix = "*** ";

	private static void LogMessage(string log)
		=> log.Dump();

	internal protected virtual void LogException(Exception ex)
		=> ex.Dump();
}


class Logger : ILogger
{
	public void Log(string message)
		=> message.Dump();

	public void Log(Exception ex)
		=> ex.Dump();
}