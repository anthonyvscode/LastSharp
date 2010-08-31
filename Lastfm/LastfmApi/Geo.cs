using Lastfm.Model;
using RestSharp;

namespace Lastfm
{
    public partial class LastfmApi
    {
        public LastfmResponse<EventsList> geoGetEvents(string location, decimal? latitude, decimal? longitude, int? page, int? distance)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "geo.getevents");

            if (!string.IsNullOrEmpty(location))
                request.AddParameter("location", location);

            if (latitude != null) request.AddParameter("lat", latitude);
            if (longitude != null) request.AddParameter("long", longitude);
            if (page != null) request.AddParameter("page", page);
            if (distance != null) request.AddParameter("distance", distance);

            return Execute<LastfmResponse<EventsList>>(request).Data;
        }
    }
}
