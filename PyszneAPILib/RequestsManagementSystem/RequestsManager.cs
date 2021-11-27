using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PyszneAPILib.RequestsManagementSystem
{
	public class RequestsManager : IRequestsManager
	{
		private HttpClient RequestsClient { get; set; } = null!; //null suppression was added to remove compiler warning for constructor. Property always initialized in initialization method. 27.11.2021. Artem Yurchenko
		private Dictionary<string, string> DefaultHeadersMap { get; set; } = null!; //null suppression was added to remove compiler warning for constructor. Property always initialized in initialization method. 27.11.2021. Artem Yurchenko

		private const int DEFAULT_REQUEST_TIMEOUT_IN_MINUTES = 1;

		public RequestsManager ()
		{
			InitializeDefaultHeadersMap();
			InitializeRequestsClient();
		}

		public async Task<string> ReadResponse (HttpResponseMessage responseToRead)
		{
			return await responseToRead.Content.ReadAsStringAsync();
		}

		public async Task<HttpResponseMessage> SendRequest (HttpRequestMessage requestToSend)
		{
			return await RequestsClient.SendAsync(requestToSend);
		}

		private void InitializeDefaultHeadersMap ()
		{
			DefaultHeadersMap = new Dictionary<string, string>
			{
				{"authority", "cw-api.takeaway.com"},
				{"x-instana-t", "a72df02c74bb0d7b"},
				{"x-instana-s", "a72df02c74bb0d7b"},
				{"accept-language", "pl"},
				{"sec-ch-ua-mobile", "?0"},
				{"x-instana-l", "1,correlationType=web;correlationId=a72df02c74bb0d7b"},
				{"accept", "application/json, text/plain, */*"},
				{"x-requested-with", "XMLHttpRequest"},
				{"x-session-id", "b30d529c-4c4f-4a1c-bf36-c15a7eac9151"},
				{"user-agent", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36"},
				{"x-country-code", "pl"},
				{"sec-ch-ua", "\"Google Chrome\";v=\"95\", \"Chromium\";v=\"95\", \";Not A Brand\";v=\"99\""},
				{"sec-ch-ua-platform", "\"Linux\""},
				{"origin", "https://www.pyszne.pl"},
				{"sec-fetch-site", "cross-site"},
				{"sec-fetch-mode", "cors"},
				{"sec-fetch-dest", "empty"},
			};
		}

		private void InitializeRequestsClient ()
		{
			RequestsClient = new HttpClient();
			RequestsClient.Timeout = TimeSpan.FromMinutes(DEFAULT_REQUEST_TIMEOUT_IN_MINUTES);

			foreach (var (name, value) in DefaultHeadersMap)
			{
				RequestsClient.DefaultRequestHeaders.Add(name, value);
			}
		}
	}
}