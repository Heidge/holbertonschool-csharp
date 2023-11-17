using System;
using InventoryLibrary;

/// <summary>
/// Summary description for Class1
/// </summary>
public class User : BaseClass
{
	public string name;

	public string Name
	{
		get { return name; }
		set
		{
			if (value.Length == 0)
			{
				throw new Exception("Name cannot be empty");
			}
			else
			{
				name = value;
			}
		}
	}

	public User(string name)
	{
		this.name = name;
	}
}
