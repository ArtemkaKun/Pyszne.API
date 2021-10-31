namespace Pyszne_API.APISystem
{
	public class APIManager
	{
		private Restaurants RestaurantsManager { get; }

		private const string SERVICE_ADDRESS = "https://cw-api.takeaway.com/api/v28/";

		public APIManager ()
		{
			RestaurantsManager = new Restaurants(SERVICE_ADDRESS);
		}
	}
}