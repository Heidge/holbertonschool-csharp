using System;
using InventoryLibrary;

/// <summary>
/// Classe représentant un utilisateur avec une propriété spécifique pour le nom.
/// Hérite de la classe de base "BaseClass".
/// </summary>
public class User : BaseClass
{
	/// <summary>
	/// Nom de l'utilisateur.
	/// </summary>
	public string name;

	/// <summary>
	/// Propriété pour obtenir ou définir le nom de l'utilisateur.
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
	/// Constructeur de la classe User.
	/// Initialise la propriété de nom de l'utilisateur avec la valeur fournie.
	/// </summary>
	/// <param name="name">Nom de l'utilisateur.</param>
	public User(string name)
	{
		this.name = name;
	}
}
