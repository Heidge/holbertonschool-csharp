using System;

namespace InventoryLibrary
{
	/// <summary>
	/// Classe de base repr�sentant un objet avec des propri�t�s communes telles que l'ID et les dates de cr�ation/mise � jour.
	/// </summary>
	public class BaseClass
	{
		/// <summary>
		/// Obtient ou d�finit l'identifiant unique de l'objet.
		/// </summary>
		public string id { get; set; }

		/// <summary>
		/// Obtient ou d�finit la date de cr�ation de l'objet.
		/// </summary>
		public DateTime date_created { get; set; }

		/// <summary>
		/// Obtient ou d�finit la date de la derni�re mise � jour de l'objet.
		/// </summary>
		public DateTime date_updated { get; set; }

		/// <summary>
		/// Constructeur de la classe de base.
		/// Initialise l'ID avec une nouvelle valeur GUID, et les dates de cr�ation et de mise � jour avec la date et l'heure actuelles.
		/// </summary>
		public BaseClass()
		{
			id = Guid.NewGuid().ToString();
			date_created = DateTime.Now;
			date_updated = DateTime.Now;
		}
	}
}
