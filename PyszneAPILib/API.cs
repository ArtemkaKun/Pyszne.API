using System;
using System.Net.Http;
using System.Threading.Tasks;
using PyszneAPILib.RequestsManagementSystem;
using PyszneAPILib.RestaurantDataSystem;

namespace PyszneAPILib
{
	public class API
	{
		private IRestaurantDataManager RestaurantDataManager { get; }
		private IRequestsManager RequestsManager { get; }

		public API (IRestaurantDataManager restaurantDataManager, IRequestsManager requestsManager)
		{
			RestaurantDataManager = restaurantDataManager;
			RequestsManager = requestsManager;
		}

		public async Task TryGetRestaurantData (string restaurantID, Action<string> onSuccess, Action<HttpRequestFailData> onFail)
		{
			using HttpRequestMessage dataRequest = RestaurantDataManager.CreateRequest(restaurantID);
			using HttpResponseMessage dataResponse = await RequestsManager.SendRequest(dataRequest);

			if (dataResponse.IsSuccessStatusCode == true)
			{
				onSuccess.Invoke(await RequestsManager.ReadResponse(dataResponse));
			}
			else
			{
				onFail.Invoke(new HttpRequestFailData(dataResponse.StatusCode, dataResponse.ReasonPhrase));
			}
		}
	}
}