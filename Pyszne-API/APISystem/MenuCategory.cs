using System.Collections.Generic;

namespace Pyszne_API.APISystem
{
	public class MenuCategory
	{
		private string ID { get; }
		private string Name { get; }
		private string Description { get; }
		private IReadOnlyList<string> ProductIDs { get; }

		public MenuCategory (string id, string name, string description, IReadOnlyList<string> productIDs)
		{
			ID = id;
			Name = name;
			Description = description;
			ProductIDs = productIDs;
		}
	}
}