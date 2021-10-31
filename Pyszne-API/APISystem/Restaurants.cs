using System.IO;
using System.Net;
using System.Text.Json;

namespace Pyszne_API.APISystem
{
	public class Restaurants
	{
		private string ServerAddress { get; }

		public Restaurants (string serverAddress)
		{
			ServerAddress = serverAddress;
		}

		public void GetMenu (string restaurantName)
		{
			string restaurantRequest = $"{ServerAddress}restaurant?slug={restaurantName}";
			string restaurantDataResponse = MakeRestaurantDataRequest(restaurantRequest);
			RestaurantData responseData = JsonSerializer.Deserialize<RestaurantData>(restaurantDataResponse);
		}

		private string MakeRestaurantDataRequest (string restaurantRequest)
		{
			HttpWebRequest request = (HttpWebRequest) WebRequest.Create(restaurantRequest);
			using HttpWebResponse response = (HttpWebResponse) request.GetResponse();
			using Stream responseStream = response.GetResponseStream();
			using StreamReader responseReader = new(responseStream);
			return responseReader.ReadToEnd();
		}
	}
}