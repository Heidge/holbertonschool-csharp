using System;
using System.Collections.Generic;
using InventoryLibrary;

/// <summary>
/// Classe représentant un article avec des propriétés spécifiques telles que le nom, la description, le prix et les balises.
/// Hérite de la classe de base "BaseClass".
/// </summary>
public class Item : BaseClass
{
	/// <summary>
	/// Nom de l'article.
	/// </summary>
	public string name;

	/// <summary>
	/// Description de l'article.
	/// </summary>
	public string description { get; set; }

	/// <summary>
	/// Prix de l'article. Peut être nul.
	/// </summary>
	public float? price;

	/// <summary>
	/// Liste de balises associées à l'article.
	/// </summary>
	public List<string> tags { get; set; }

	/// <summary>
	/// Propriété pour obtenir ou définir le nom de l'article.
	/// Vérifie que le nom n'est pas vide lors de la définition.
	/// </summary>
	public string Name
	{
		get { return name; }
		set
		{
			if (value.Length == 0)
			{
				throw new Exception("Le nom ne peut pas être vide");
			}
			else
			{
				name = value;
			}
		}
	}

	/// <summary>
	/// Propriété pour obtenir ou définir le prix de l'article.
	/// </summary>
	public float Price
	{
		get { return price; }
		set
		{
			// Commented out code for future reference
			// if (floatPrice < 0)
			// {
			//    throw new Exception("Le prix ne peut pas avoir plus de 3 décimales");
			// }
			// else
			// {
			price = value;
			// }
		}
	}

	/// <summary>
	/// Constructeur de la classe Item.
	/// Initialise les propriétés de l'article avec les valeurs fournies.
	/// </summary>
	/// <param name="name">Nom de l'article.</param>
	/// <param name="description">Description de l'article (facultatif).</param>
	/// <param name="price">Prix de l'article (par défaut à 0).</param>
	/// <param name="tags">Liste de balises associées à l'article (facultatif).</param>
	public Item(string name, string description = null, float price = 0, List<string> tags = null)
	{
		this.name = name;
		this.description = description;
		this.price = price;
		this.tags = tags;
	}
}
