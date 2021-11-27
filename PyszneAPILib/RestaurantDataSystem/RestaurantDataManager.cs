using System.Net.Http;

namespace PyszneAPILib.RestaurantDataSystem
{
	public class RestaurantDataManager : IRestaurantDataManager
	{
		private const string RESTAURANT_DATA_REQUEST_TEMPLATE = RequestRelatedConstants.DEFAULT_SERVICE_ADDRESS + "restaurant?slug={0}";
		
		public HttpRequestMessage CreateRequest (string restaurantID)
		{
			string restaurantRequest = string.Format(RESTAURANT_DATA_REQUEST_TEMPLATE, restaurantID);
			return new HttpRequestMessage(HttpMethod.Get, restaurantRequest);
		}
	}
}