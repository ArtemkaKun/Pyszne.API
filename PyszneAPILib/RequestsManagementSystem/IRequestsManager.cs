using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PyszneAPILib.RequestsManagementSystem
{
	public interface IRequestsManager
	{
		Task<HttpResponseMessage> SendRequest (HttpRequestMessage requestToSend);
		string? ReadResponse (HttpResponseMessage responseToRead);
	}
}