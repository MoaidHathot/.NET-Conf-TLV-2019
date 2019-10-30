<Query Kind="Program" />

#nullable enable

void Main()
{
	var miguel = new Person("Miguel", "De", "Icaza");
	var andres = new Person("Anders", "Hejlsberg ");
	
	GetMiddleNameLength(andres).Dump();	
	var length = miguel.MiddleName!.Length;
	IsNameTooLong(miguel.MiddleName!);

}

int GetMiddleNameLength(Person person)
{
	return person.MiddleName?.Length ?? 0;
}

bool IsNameTooLong(string name)
{
	return name.Length > 10;
}

public class Person
{
	public string FirstName { get; }
	public string? MiddleName { get; }
	public string LastName { get; }
	
	public Person(string firstName, string? middleName, string lastName)
	{
		FirstName = firstName;
		MiddleName = middleName;
		LastName = lastName;
	}
	
	public Person(string firstName, string lastName)
		: this(firstName, null, lastName)
	{
		
	}
}