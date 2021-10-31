namespace Pyszne_API.APISystem
{
	public class RestaurantData
	{
		public RestaurantMenu Menu { get; }

		public RestaurantData (RestaurantMenu menu)
		{
			Menu = menu;
		}
	}
}