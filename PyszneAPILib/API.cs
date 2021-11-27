using System.Net;
using System.Net.Http;
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

		public bool TryGetRestaurantData (string restaurantID, out string? restaurantData)
		{
			using HttpRequestMessage dataRequest = RestaurantDataManager.CreateRequest(restaurantID);
			using HttpResponseMessage dataResponse = RequestsManager.SendRequest(dataRequest).Result;

			bool isReturnedCodePositive = CheckIfRequestReturnPositiveCode(dataResponse.StatusCode);
			restaurantData = isReturnedCodePositive ? RequestsManager.ReadResponse(dataResponse) : null;
			return isReturnedCodePositive;
		}

		private bool CheckIfRequestReturnPositiveCode (HttpStatusCode returnedCode)
		{
			return returnedCode == HttpStatusCode.OK;
		}
	}
}