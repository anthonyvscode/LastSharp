using RestSharp;

namespace Lastfm
{
    public partial class LastfmApi
    {
        private const string BaseUrl = "http://ws.audioscrobbler.com/2.0";

        private readonly string _apiKey;
        private readonly string _secretKey;
        public int apiCalls;
        public long DataCount { get; set; }
        private RestClient _client;

        /// <summary>
        /// Initialize the library with only an API key.
        /// </summary>
        /// <param name="apiKey">A 32-character Last.fm API Key.</param>
        public LastfmApi(string apiKey)
        {
            _apiKey = apiKey;
            _client = new RestClient(BaseUrl);
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
        }

        public RestResponse<T> Execute<T>(RestRequest request) where T : new()
        {
            request.AddParameter("api_key", _apiKey);

            var response = _client.Execute<T>(request);
            apiCalls++;
            DataCount += response.RawBytes.Length;
            return response;
        }

        public RestResponse Execute(RestRequest request)
        {
            request.AddParameter("api_key", _apiKey, ParameterType.UrlSegment);
            var response = _client.Execute(request);
            apiCalls++;
            DataCount += response.RawBytes.Length;
            return response;
        }
    }
}
