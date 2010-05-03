using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lastfm.Model;
using RestSharp;
using System.Globalization;

namespace Lastfm
{
    public partial class LastfmApi
    {
        #region album.getInfo


        public Album albumGetInfo(string artist, string album)
        {
            return albumGetInfo(artist, album, null, null, null);
        }

        public Album albumGetInfo(string artist, Guid mbid)
        {
            return albumGetInfo(artist, null, mbid, null, null);
        }
        /// <summary>
        /// Get the metadata for an album on Last.fm using the album name or a musicbrainz id. See playlist.fetch on how to get the album playlist. 
        /// </summary>
        /// <param name="artist">The artist name in question</param>
        /// <param name="album">The album name in question</param>
        /// <param name="mbid">The musicbrainz id for the album</param>
        /// <param name="username">The username for the context of the request. If supplied, the user's playcount for this artist is included in the response.</param>
        /// <param name="lang">The language to return the biography in, expressed as an ISO 639 alpha-2 code.</param>
        /// <returns></returns>
        public Album albumGetInfo(string artist, string album, Guid? mbid, string username, string lang)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "album.getinfo");

            if (!string.IsNullOrEmpty(artist))
                request.AddParameter("artist", artist);

            if (mbid != null)
                request.AddParameter("mbid", mbid.ToString());

            if (!string.IsNullOrEmpty(username))
                request.AddParameter("username", username);

            if (!string.IsNullOrEmpty(lang))
                request.AddParameter("lang", lang);

            return Execute<Album>(request);
        }

        #endregion

    }
}
