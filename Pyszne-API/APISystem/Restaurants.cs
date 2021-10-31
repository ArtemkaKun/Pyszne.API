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
			request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			request.Headers.Add("authority", "cw-api.takeaway.com");
			request.Headers.Add("x-instana-t", "a72df02c74bb0d7b");
			request.Headers.Add("x-instana-s", "a72df02c74bb0d7b");
			request.Headers.Add("accept-language", "pl");
			request.Headers.Add("sec-ch-ua-mobile", "?0");
			request.Headers.Add("x-instana-l", "1,correlationType=web;correlationId=a72df02c74bb0d7b");
			request.Headers.Add("accept", "application/json, text/plain, */*");
			request.Headers.Add("x-requested-with", "XMLHttpRequest");
			request.Headers.Add("x-session-id", "b30d529c-4c4f-4a1c-bf36-c15a7eac9151");
			request.Headers.Add("user-agent", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");
			request.Headers.Add("x-country-code", "pl");
			request.Headers.Add("sec-ch-ua", "\"Google Chrome\";v=\"95\", \"Chromium\";v=\"95\", \";Not A Brand\";v=\"99\"");
			request.Headers.Add("sec-ch-ua-platform", "\"Linux\"");
			request.Headers.Add("origin", "https://www.pyszne.pl");
			request.Headers.Add("sec-fetch-site", "cross-site");
			request.Headers.Add("sec-fetch-mode", "cors");
			request.Headers.Add("sec-fetch-dest", "empty");
			using HttpWebResponse response = (HttpWebResponse) request.GetResponse();
			using Stream responseStream = response.GetResponseStream();
			using StreamReader responseReader = new(responseStream);
			return responseReader.ReadToEnd();
		}
	}
}