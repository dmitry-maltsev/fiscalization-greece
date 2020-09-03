using Mews.Fiscalization.Greece.Dto.Xsd;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mews.Fiscalization.Greece
{
    internal class RestClient
    {
        public string UserId { get; }

        public string SubscriptionKey { get; }

        public Uri EndpointUri { get; }

        private HttpClient HttpClient { get; }

        public RestClient(string userId, string subscriptionKey, string endpoint)
        {
            UserId = userId;
            SubscriptionKey = subscriptionKey;
            EndpointUri = new Uri(endpoint);
            HttpClient = new HttpClient();
        }

        public async Task<ResponseDoc> SendRequestAsync(InvoicesDoc invoicesDoc)
        {
            var requestContent = XmlManipulator.Serialize(invoicesDoc).OuterXml;
            var requestMessage = BuildHttpRequestMessage(requestContent);

            HttpClient.DefaultRequestHeaders.Add("aade-user-id", $"{UserId}");
            HttpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{SubscriptionKey}");

            var response = await HttpClient.SendAsync(requestMessage).ConfigureAwait(continueOnCapturedContext: false);

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
