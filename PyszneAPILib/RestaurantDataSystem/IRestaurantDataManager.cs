using System.Net.Http;

namespace PyszneAPILib.RestaurantDataSystem
{
	public interface IRestaurantDataManager
	{
		HttpRequestMessage CreateRequest (string restaurantID);
	}
}