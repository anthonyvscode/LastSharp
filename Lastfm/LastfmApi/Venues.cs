using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lastfm.Model;
using Lastfm.Utilities;
using RestSharp;
using RestSharp.Validation;

namespace Lastfm
{
    public partial class LastfmApi
    {
        #region venue.search

        /// <summary>
        ///  Search for a venue by venue name 
        /// </summary>
        /// <param name="venue">The venue name you would like to search for.</param>
        /// <returns>List of venues</returns>
        public VenueList venueSearch(string venue)
        {
            return venueSearch(venue, string.Empty, null, null);
        }

        /// <summary>
        ///  Search for a venue by venue name 
        /// </summary>
        /// <param name="venue">The venue name you would like to search for.</param>
        /// <param name="country">Filter your results by country. Expressed as an ISO 3166-2 code.</param>
        /// <returns>List of venues</returns>
        public VenueList venueSearch(string venue, string country)
        {
            return venueSearch(venue, country, null, null);
        }

        /// <summary>
        ///  Search for a venue by venue name 
        /// </summary>
        /// <param name="venue">The venue name you would like to search for.</param>
        /// <param name="country">Filter your results by country. Expressed as an ISO 3166-2 code.</param>
        /// <param name="page">The results page you would like to fetch</param>
        /// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
        /// <returns>List of venues</returns>
        public VenueList venueSearch(string venue, string country, int? page, int? limit)
        {
            var request = new RestRequest(Method.GET);
            if (!string.IsNullOrEmpty(country))
                request.AddParameter("country", country);
            if (page != null)
                request.AddParameter("page", page);
            if(limit != null)
                request.AddParameter("limit", limit);

            request.AddParameter("venue", venue);
            request.AddParameter("method", "venue.search");

            return Execute<LastfmResponse<VenueList>>(request).Data.Value;
        }
        #endregion

        #region venue.getEvents

        /// <summary>
        ///  Get a list of upcoming events at this venue. 
        /// </summary>
        /// <param name="venueId">The Last.fm Id for the venue you would like to fetch event listings for.</param>
        /// <returns>future events happening at the venue</returns>
        public EventsList venueGetEvents(string venueId)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "venue.getevents");
            request.AddParameter("venue", venueId);

            return Execute<LastfmResponse<EventsList>>(request).Data.Value;
        }

        #endregion

        #region venue.getPastEvents

        /// <summary>
        ///  Get a paginated list of all the events held at this venue in the past.
        /// </summary>
        /// <param name="venueId">The Last.fm Id for the venue you would like to fetch event listings for.</param>
        /// <returns>paginated list of all the events held at this venue in the past.</returns>
        public EventsList venueGetPastEvents(string venueId)
        {
            return venueGetPastEvents(venueId, null, null);
        }

        /// <summary>
        ///  Get a paginated list of all the events held at this venue in the past.
        /// </summary>
        /// <param name="venueId">The Last.fm Id for the venue you would like to fetch event listings for.</param>
        /// <returns>paginated list of all the events held at this venue in the past.</returns>
        public EventsList venueGetPastEvents(string venueId, int? page, int? limit)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "venue.getpastevents");
            request.AddParameter("venue", venueId);

            if (page != null)
                request.AddParameter("page", page);
            if (limit != null)
                request.AddParameter("limit", limit);

            return Execute<LastfmResponse<EventsList>>(request).Data.Value;
        }

        #endregion
    }
}
