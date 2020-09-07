using Mews.Fiscalization.Greece.Dto.Xsd;
using Mews.Fiscalization.Greece.Model;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mews.Fiscalization.Greece
{
    internal class RestClient
    {
        private static readonly string ProductionEndpoint = "prod_endpoint";
        private static readonly string SandboxEndpoint = "https://mydata-dev.azure-api.net/SendInvoices";

        public string UserId { get; }

        public string SubscriptionKey { get; }

        public AadeLogger Logger { get; }

        public Uri EndpointUri { get; }

        private HttpClient HttpClient { get; }

        internal RestClient(string userId, string subscriptionKey, AadeEnvironment environment, AadeLogger logger = null)
        {
            UserId = userId ?? throw new ArgumentNullException(userId);
            SubscriptionKey = subscriptionKey ?? throw new ArgumentNullException(subscriptionKey);

            var endpoint = environment == AadeEnvironment.Production
                ? ProductionEndpoint
                : SandboxEndpoint;
            EndpointUri = new Uri(endpoint);

            Logger = logger;

            HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Add("aade-user-id", $"{UserId}");
            HttpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{SubscriptionKey}");
        }

        internal async Task<ResponseDoc> SendRequestAsync(InvoicesDoc invoicesDoc)
        {
            var requestContent = XmlManipulator.Serialize(invoicesDoc).OuterXml;
            var requestMessage = BuildHttpRequestMessage(requestContent);

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
