using System;

namespace InventoryLibrary
{
	/// <summary>
	/// Classe de base représentant un objet avec des propriétés communes telles que l'ID et les dates de création/mise à jour.
	/// </summary>
	public class BaseClass
	{
		/// <summary>
		/// Obtient ou définit l'identifiant unique de l'objet.
		/// </summary>
		public string id { get; set; }

		/// <summary>
		/// Obtient ou définit la date de création de l'objet.
		/// </summary>
		public DateTime date_created { get; set; }

		/// <summary>
		/// Obtient ou définit la date de la dernière mise à jour de l'objet.
		/// </summary>
		public DateTime date_updated { get; set; }

		/// <summary>
		/// Constructeur de la classe de base.
		/// Initialise l'ID avec une nouvelle valeur GUID, et les dates de création et de mise à jour avec la date et l'heure actuelles.
		/// </summary>
		public BaseClass()
		{
			id = Guid.NewGuid().ToString();
			date_created = DateTime.Now;
			date_updated = DateTime.Now;
		}
	}
}
