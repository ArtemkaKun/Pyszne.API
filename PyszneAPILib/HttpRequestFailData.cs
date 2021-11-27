using System.Net;

namespace PyszneAPILib
{
	public readonly struct HttpRequestFailData
	{
		public HttpStatusCode Code { get; }
		public string? ReasonMessage { get; }

		public HttpRequestFailData (HttpStatusCode code, string? reasonMessage)
		{
			Code = code;
			ReasonMessage = reasonMessage;
		}
	}
}