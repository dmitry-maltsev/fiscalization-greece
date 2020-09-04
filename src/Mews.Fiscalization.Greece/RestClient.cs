using Mews.Fiscalization.Greece.Dto.Xsd;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mews.Fiscalization.Greece
{
    internal class RestClient
    {
        public string UserId { get; }

        public string SubscriptionKey { get; }

        public AadeLogger Logger { get; }

        public Uri EndpointUri { get; }

        private HttpClient HttpClient { get; }

        public RestClient(string userId, string subscriptionKey, string endpoint, AadeLogger logger = null)
        {
            UserId = userId;
            SubscriptionKey = subscriptionKey;
            EndpointUri = new Uri(endpoint);
            Logger = logger;
            HttpClient = new HttpClient();
        }

        public async Task<ResponseDoc> SendRequestAsync(InvoicesDoc invoicesDoc)
        {
            var requestContent = XmlManipulator.Serialize(invoicesDoc).OuterXml;
            var requestMessage = BuildHttpRequestMessage(requestContent);

            HttpClient.DefaultRequestHeaders.Add("aade-user-id", $"{UserId}");
            HttpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{SubscriptionKey}");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var response = await HttpClient.SendAsync(requestMessage).ConfigureAwait(continueOnCapturedContext: false);

            stopwatch.Stop();
            Logger?.Info($"HTTP request finished in {stopwatch.ElapsedMilliseconds}ms.", new { HttpRequestDuration = stopwatch.ElapsedMilliseconds });

            var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);            
            
            return XmlManipulator.Deserialize<ResponseDoc>(responseContent);
        }

        private HttpRequestMessage BuildHttpRequestMessage(string messageContent)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, EndpointUri);

            message.Content = new StringContent(content: messageContent, encoding: Encoding.UTF8, mediaType: "application/xml");

            return message;
        }
    }
}
