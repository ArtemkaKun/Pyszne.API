using NUnit.Framework;
using PyszneAPILib;
using PyszneAPILib.RequestsManagementSystem;
using PyszneAPILib.RestaurantDataSystem;

namespace PyszneAPILibServer
{
	public class RestaurantTests
	{
		private API APIInstance { get; set; }

		[OneTimeSetUp]
		public void Initialize ()
		{
			APIInstance = new API(new RestaurantDataManager(), new RequestsManager());
		}
		
		[Test]
		public void SendRestaurantDataRequest_ReturnedCodeIsSuccess_True ()
		{
			Assert.IsTrue(APIInstance.TryGetRestaurantData("diamond-kebab-bielsko-biala-sempolowskiej", out _));
		}
		
		[Test]
		public void SendRestaurantDataRequest_ReturnedDataContainsExpectedKeywords_True ()
		{
			Assert.Fail();
		}
	}
}