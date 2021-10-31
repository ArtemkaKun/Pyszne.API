using System.Collections.Generic;

namespace Pyszne_API.APISystem
{
	public class RestaurantMenu
	{
		public IReadOnlyList<MenuCategory> Categories { get; }

		public RestaurantMenu (IReadOnlyList<MenuCategory> categories)
		{
			Categories = categories;
		}
	}
}