using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using InventoryLibrary;

/// <summary>
/// Classe représentant un système de stockage basé sur le format JSON pour des objets dérivés de la classe de base "BaseClass".
/// </summary>
public class JSONStorage
{
	// Dictionnaire pour stocker les objets avec une clé sous la forme "TypeName.ObjectID"
	public Dictionary<string, BaseClass> objects;

	/// <summary>
	/// Constructeur de la classe JSONStorage, initialise le dictionnaire d'objets.
	/// </summary>
	public JSONStorage()
	{
		objects = new Dictionary<string, BaseClass>();
	}

	/// <summary>
	/// Retourne tous les objets stockés dans le dictionnaire.
	/// </summary>
	/// <returns>Dictionnaire d'objets.</returns>
	public Dictionary<string, BaseClass> All()
	{
		return objects;
	}

	/// <summary>
	/// Ajoute un nouvel objet au dictionnaire avec une clé unique générée en combinant le nom du type et l'ID de l'objet.
	/// </summary>
	/// <param name="obj">Objet dérivé de la classe de base "BaseClass" à ajouter.</param>
	public void New(BaseClass obj)
	{
		objects.Add($"{obj.GetType().Name}.{obj.id}", obj);
	}

	/// <summary>
	/// Sérialise le dictionnaire d'objets au format JSON et écrit le contenu dans un fichier.
	/// </summary>
	public void Save()
	{
		string jsonString = JsonSerializer.Serialize(objects, new JsonSerializerOptions { WriteIndented = true });
		File.WriteAllText("../storage/inventory_manager.json", jsonString);
	}

	/// <summary>
	/// Charge les objets à partir d'une chaîne JSON et les ajoute au dictionnaire.
	/// </summary>
	/// <param name="jsonString">Chaîne JSON représentant les objets.</param>
	public void Load(string jsonString)
	{
		if (File.Exists("../storage/inventory_manager.json"))
		{
			// Désérialise la chaîne JSON et stocke le résultat dans un dictionnaire temporaire.
			Dictionary<string, BaseClass> deserializeDic = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(File.ReadAllText(jsonString));
		}
		else
		{
			throw new Exception("Le fichier n'existe pas");
		}
	}
}
