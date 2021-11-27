using System.Threading.Tasks;
using NUnit.Framework;
using PyszneAPILib;
using PyszneAPILib.RequestsManagementSystem;
using PyszneAPILib.RestaurantDataSystem;

namespace PyszneAPILibServer
{
	public class RestaurantTests
	{
		private API APIInstance { get; set; } = null!; //null suppression was added to remove compiler warning for constructor. Property always initialized in initialization method. 27.11.2021. Artem Yurchenko

		[OneTimeSetUp]
		public void Initialize ()
		{
			APIInstance = new API(new RestaurantDataManager(), new RequestsManager());
		}
		
		[Test]
		public async Task SendRestaurantDataRequest_ReturnedCodeIsSuccess_True ()
		{
			await APIInstance.TryGetRestaurantData("diamond-kebab-bielsko-biala-sempolowskiej", ReactOnSuccess, ReactOnFail);

			void ReactOnSuccess (string _)
			{
				Assert.Pass();
			}

			void ReactOnFail (HttpRequestFailData failReason)
			{
				Assert.Fail($"{failReason.Code} - {failReason.ReasonMessage}");
			}
		}
		
		[Test]
		public void SendRestaurantDataRequest_ReturnedDataContainsExpectedKeywords_True ()
		{
			Assert.Fail();
		}
	}
}