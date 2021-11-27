using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PyszneAPILib.RequestsManagementSystem
{
	public class RequestsManager : IRequestsManager
	{
		private HttpClient RequestsClient { get; set; } = null!; //null suppression was added to remove compiler warning for constructor. Property always initialized in initialization method. 27.11.2021. Artem Yurchenko

		public RequestsManager ()
		{
			InitializeRequestsClient();
		}

		public async Task<HttpResponseMessage> SendRequest (HttpRequestMessage requestToSend)
		{
			return await RequestsClient.SendAsync(requestToSend);
		}

		public async Task<string> ReadResponse (HttpResponseMessage responseToRead)
		{
			return await responseToRead.Content.ReadAsStringAsync();
		}
		}

		private void InitializeRequestsClient ()
		{
			RequestsClient = new HttpClient();
			RequestsClient.Timeout = TimeSpan.FromMinutes(1);
			RequestsClient.DefaultRequestHeaders.Add("authority", "cw-api.takeaway.com");
			RequestsClient.DefaultRequestHeaders.Add("x-instana-t", "a72df02c74bb0d7b");
			RequestsClient.DefaultRequestHeaders.Add("x-instana-s", "a72df02c74bb0d7b");
			RequestsClient.DefaultRequestHeaders.Add("accept-language", "pl");
			RequestsClient.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
			RequestsClient.DefaultRequestHeaders.Add("x-instana-l", "1,correlationType=web;correlationId=a72df02c74bb0d7b");
			RequestsClient.DefaultRequestHeaders.Add("accept", "application/json, text/plain, */*");
			RequestsClient.DefaultRequestHeaders.Add("x-requested-with", "XMLHttpRequest");
			RequestsClient.DefaultRequestHeaders.Add("x-session-id", "b30d529c-4c4f-4a1c-bf36-c15a7eac9151");
			RequestsClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");
			RequestsClient.DefaultRequestHeaders.Add("x-country-code", "pl");
			RequestsClient.DefaultRequestHeaders.Add("sec-ch-ua", "\"Google Chrome\";v=\"95\", \"Chromium\";v=\"95\", \";Not A Brand\";v=\"99\"");
			RequestsClient.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Linux\"");
			RequestsClient.DefaultRequestHeaders.Add("origin", "https://www.pyszne.pl");
			RequestsClient.DefaultRequestHeaders.Add("sec-fetch-site", "cross-site");
			RequestsClient.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
			RequestsClient.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
		}
	}
}