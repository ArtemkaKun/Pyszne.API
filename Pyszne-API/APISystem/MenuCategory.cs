using System.Collections.Generic;

namespace Pyszne_API.APISystem
{
	public class MenuCategory
	{
		public string ID { get; }
		public string Name { get; }
		public string Description { get; }
		public IReadOnlyList<string> ProductIDs { get; }

		public MenuCategory (string id, string name, string description, IReadOnlyList<string> productIDs)
		{
			ID = id;
			Name = name;
			Description = description;
			ProductIDs = productIDs;
		}
	}
}