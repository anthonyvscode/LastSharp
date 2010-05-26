using RestSharp;
using RestSharp.Deserializers;

namespace Lastfm
{
    public partial class LastfmApi
    {
        private const string BaseUrl = "http://ws.audioscrobbler.com/2.0";

        private readonly string _apiKey;
        private readonly string _secretKey;
        /// <summary>
        /// The number of requests that have been made by the current Client instance
        /// </summary>
        public int RequestCount { get; set; }
        /// <summary>
        /// The total Bytes returned from the requests made by the current Client instance
        /// </summary>
        public long DataCount { get; set; }

        private RestClient _restClient;

        /// <summary>
        /// Initialize the library with only an API key.
        /// </summary>
        /// <param name="apiKey">A 32-character Last.fm API Key.</param>
        public LastfmApi(string apiKey)
        {
            _apiKey = apiKey;
            _restClient = new RestClient(BaseUrl);
            _restClient.ClearHandlers();
            _restClient.AddHandler("application/xml", new XmlAttributeDeserializer());
        }

        /// <summary>
        /// Initialize the library with an API key and a Lastfm Secret API key. Secret Key is required for all .add method calls.
        /// </summary>
        /// <param name="apiKey">A 32-character Last.fm API Key.</param>
        /// <param name="secretKey">A 32-character Last.fm API Secret Key..</param>
        public LastfmApi(string apiKey, string secretKey)
        {
            _apiKey = apiKey;
            _secretKey = secretKey;
            _restClient = new RestClient(BaseUrl);
            _restClient.ClearHandlers();
            _restClient.AddHandler("application/xml", new XmlAttributeDeserializer());
        }

        /// <summary>
        /// Creates a generic typed rest request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public RestResponse<T> Execute<T>(RestRequest request) where T : new()
        {
            request.AddParameter("api_key", _apiKey);

            var response = _restClient.Execute<T>(request);
            RequestCount++;
            DataCount += response.RawBytes.Length;
            return response;
        }

        public RestResponse Execute(RestRequest request)
        {
            request.AddParameter("api_key", _apiKey, ParameterType.UrlSegment);
            var response = _restClient.Execute(request);
            RequestCount++;
            DataCount += response.RawBytes.Length;
            return response;
        }
    }
}
