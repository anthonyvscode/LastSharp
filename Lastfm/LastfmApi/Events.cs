using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lastfm.Model;
using RestSharp;

namespace Lastfm
{
    public partial class LastfmApi
    {
        #region event.getShouts

        /// <summary>
        /// Get the metadata for an event on Last.fm. Includes attendance and lineup information. 
        /// </summary>
        /// <param name="eventId">The numeric last.fm event id</param>
        public ShoutList eventGetShouts(string eventId)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "event.getShouts");
            request.AddParameter("event", eventId);

            return Execute<ShoutList>(request);
        }

        #endregion

        #region event.getInfo

        /// <summary>
        ///  Get shouts for this event.
        /// </summary>
        /// <param name="eventId">The numeric last.fm event id</param>
        public Event eventGetInfo(string eventId)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "event.getinfo");
            request.AddParameter("event", eventId);

            return Execute<Event>(request);
        }

        #endregion
    }
}
