using System;

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



}
	
