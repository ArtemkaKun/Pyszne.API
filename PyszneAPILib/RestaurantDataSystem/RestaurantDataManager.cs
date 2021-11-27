using System.Net.Http;

namespace PyszneAPILib.RestaurantDataSystem
{
	public class RestaurantDataManager : IRestaurantDataManager
	{
		private const string SERVICE_ADDRESS = "https://cw-api.takeaway.com/api/v28/";
		
		public HttpRequestMessage CreateRequest (string restaurantID)
		{
			string restaurantRequest = $"{SERVICE_ADDRESS}restaurant?slug={restaurantID}";
			return new HttpRequestMessage(HttpMethod.Get, restaurantRequest);
		}
	}
}