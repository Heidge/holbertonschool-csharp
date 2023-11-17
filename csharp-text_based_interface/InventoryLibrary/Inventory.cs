using System;
using InventoryLibrary;

/// <summary>
/// Classe représentant un élément d'inventaire associé à un utilisateur et un article avec une quantité spécifique.
/// Hérite de la classe de base "BaseClass".
/// </summary>
public class Inventory : BaseClass
{
	/// <summary>
	/// Identifiant de l'utilisateur associé à cet élément d'inventaire.
	/// </summary>
	public string user_id { get; set; }

	/// <summary>
	/// Identifiant de l'article associé à cet élément d'inventaire.
	/// </summary>
	public string item_id { get; set; }

	/// <summary>
	/// Quantité de l'article dans l'inventaire. Ne peut pas être inférieure à 0.
	/// </summary>
	private int quantity = 1;

	/// <summary>
	/// Propriété pour obtenir ou définir la quantité de l'article dans l'inventaire.
	/// Vérifie que la quantité n'est pas inférieure à 0 lors de la définition.
	/// </summary>
	public int Quantity
	{
		get { return quantity; }
		set
		{
			if (value < 0)
			{
				throw new Exception("La quantité ne peut pas être inférieure à 0");
			}
			else
			{
				quantity = value;
			}
		}
	}

	/// <summary>
	/// Constructeur de la classe Inventory.
	/// Initialise les propriétés user_id, item_id et quantity avec les valeurs fournies.
	/// </summary>
	/// <param name="user">Utilisateur associé à l'inventaire.</param>
	/// <param name="item">Article associé à l'inventaire.</param>
	/// <param name="quantity">Quantité de l'article dans l'inventaire (par défaut à 1).</param>
	public Inventory(User user, Item item, int quantity = 1)
	{
		this.user_id = user.id;
		this.item_id = item.id;
		this.quantity = quantity;
	}
}
