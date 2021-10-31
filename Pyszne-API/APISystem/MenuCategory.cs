using System.Collections.Generic;

namespace Pyszne_API.APISystem
{
	public class MenuCategory
	{
		public string ID { get; init; }
		public string Name { get; init; }
		public string Description { get; init; }
		public IReadOnlyList<string> ProductIDs { get; init; }
	}
}