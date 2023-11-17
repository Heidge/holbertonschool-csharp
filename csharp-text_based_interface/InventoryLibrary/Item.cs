using System;
using System.Collections.Generic;
using InventoryLibrary;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Item : BaseClass
{
	public string name;
	public string description { get; set; }
	public float? price;
	public List<string> tags { get; set; }

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


	public float Price
	{
		get { return price; }
		set
		{

			/** if (floatPrice < 0)
			{
				throw new Exception("Price cannothave more than 3 decimals");
			}
			else
			{ */
			price = value;
		}
	}

	public Item(string name, string description = null, int price = 0, List<string> tags = null)
	{
		this.name = name;
		this.description = description;
		this.price = price;
		this.tags = tags;
	}
}
