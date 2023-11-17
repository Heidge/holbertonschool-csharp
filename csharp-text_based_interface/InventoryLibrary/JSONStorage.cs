using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using InventoryLibrary;

/// <summary>
/// Summary description for Class1
/// </summary>
public class JSONStorage
{
	public Dictionary<string, BaseClass> objects;

	public JSONStorage()
	{
		objects = new Dictionary<string, BaseClass>();
	}

	public Dictionary<string, BaseClass> All()
	{
		return objects;
	}

	public void New(BaseClass obj)
	{
		objects.Add($"{obj.GetType().Name}.{obj.id}", obj);
	}

	public void Save()
	{
		string jsonString = JsonSerializer.Serialize(objects, new JsonSerializerOptions { WriteIndented = true});
		File.WriteAllText("../storage/inventory_manager.json", jsonString);
	}

	public void Load(string jsonString)
	{
		if (File.Exists("../storage/inventory_manager.json")) 
		{
			Dictionary<string, Baseclass> deserializeDic = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(File.ReadAllText(jsonString));
		}
		else
		{
			throw new Exception("File doesn't exists");
		}
		
	}
}
