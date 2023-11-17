using System;
using InventoryLibrary;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Inventory : BaseClass
{
	public string user_id { get; set; }
	public string item_id { get; set; }
	private int quantity = 1;

	public int Quantity
	{
		get { return quantity; }
		set
		{
			if (value < 0)
			{
				throw new Exception("Quantity cannot be less than 0");
			}
			else
			{
				quantity = value;
			}
		}
	}

	public Inventory(User user, Item item, int quantity = 1)
	{
		this.user_id = user.id;
		this.item_id = item.id;
		this.quantity = quantity;

	}



}
	
