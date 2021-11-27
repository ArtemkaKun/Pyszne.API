using System.Net.Http;
using System.Threading.Tasks;

namespace PyszneAPILib.RequestsManagementSystem
{
	public interface IRequestsManager
	{
		Task<HttpResponseMessage> SendRequest (HttpRequestMessage requestToSend);
		Task<string> ReadResponse (HttpResponseMessage responseToRead);
	}
}