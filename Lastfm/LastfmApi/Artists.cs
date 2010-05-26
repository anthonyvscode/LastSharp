using System;
using Lastfm.Model;
using RestSharp;

namespace Lastfm
{
    public partial class LastfmApi
    {
        //TODO: artist.addTags - authentication..... DUN DUN DUNNNNN

        #region artist.getEvents

        /// <summary>
        ///  Get a list of upcoming events for this artist.  
        /// </summary>
        /// <param name="artist">The artist name in question.</param>
        /// <returns>future events happening by the artist</returns>
        public LastfmResponse<EventsList> artistGetEvents(string artist)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "artist.getevents");
            request.AddParameter("artist", artist);

            return Execute<LastfmResponse<EventsList>>(request).Data;
        }

        #endregion

        #region artist.getImages

        /// <summary>
        /// Get Images for this artist in a variety of sizes.
        /// </summary>
        /// <param name="artist">The artist name in question.</param>
        /// <returns></returns>
        public LastfmResponse<ImageList> artistGetImages(string artist)
        {
            return artistGetImages(artist, null, null, null);
        }

        /// <summary>
        /// Get Images for this artist in a variety of sizes.
        /// </summary>
        /// <param name="artist">The artist name in question.</param>
        /// <param name="page">Which page of limit amount to display.</param>
        /// <param name="limit">How many to return. Defaults and maxes out at 50.</param>
        /// <param name="order">Sort ordering can be either 'popularity' (default) or 'dateadded'. While ordering by popularity officially selected images by labels and artists will be ordered first.</param>
        /// <returns></returns>
        public LastfmResponse<ImageList> artistGetImages(string artist, int? page, int? limit, Utilities.Enums.Order? order)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "artist.getimages");
            request.AddParameter("artist", artist);

            if (page != null)
                request.AddParameter("page", page);
            if (limit != null)
                request.AddParameter("limit", limit);
            if (order != null)
                request.AddParameter("order", order);

            return Execute<LastfmResponse<ImageList>>(request).Data;
        }

        #endregion

        #region artist.getInfo

        /// <summary>
        /// Get the metadata for an artist on Last.fm. Includes biography.
        /// </summary>
        /// <param name="artist">The artist name in question</param>
        /// <returns></returns>
        public LastfmResponse<Artist> artistGetInfo(string artist)
        {
            return artistGetInfo(artist, null, string.Empty, null);
        }
        /// <summary>
        /// Get the metadata for an artist on Last.fm. Includes biography.
        /// </summary>
        /// <param name="mbid">The musicbrainz id for the artist</param>
        /// <returns></returns>
        public LastfmResponse<Artist> artistGetInfo(Guid mbid)
        {
            return artistGetInfo(string.Empty, mbid, string.Empty, null);
        }
        /// <summary>
        /// Get the metadata for an artist on Last.fm. Includes biography.
        /// </summary>
        /// <param name="artist">The artist name in question</param>
        /// <param name="mbid">The musicbrainz id for the artist</param>
        /// <param name="username">The username for the context of the request. If supplied, the user's playcount for this artist is included in the response.</param>
        /// <param name="lang">The language to return the biography in, expressed as an ISO 639 alpha-2 code.</param>
        /// <returns></returns>
        public LastfmResponse<Artist> artistGetInfo(string artist, Guid? mbid, string username, string lang)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "artist.getInfo");

            if (!string.IsNullOrEmpty(artist))
                request.AddParameter("artist", artist);

            if (mbid != null)
                request.AddParameter("mbid", mbid.ToString());

            if (!string.IsNullOrEmpty(username))
                request.AddParameter("username", username);

            if (!string.IsNullOrEmpty(lang))
                request.AddParameter("lang", lang);

            var response = Execute<LastfmResponse<Artist>>(request);

            return response.Data;
        }

        #endregion

        #region artist.getPastEvents

        /// <summary>
        ///  Get a paginated list of all the events this artist has played at in the past.
        /// </summary>
        /// <param name="artist">The artist name in question.</param>
        /// <param name="limit">The maximum number of results to return per page</param>
        /// <param name="page">The page of results to return.</param>
        /// <returns>past events by the artist</returns>
        public LastfmResponse<EventsList> artistGetPastEvents(string artist)
        {
            return artistGetPastEvents(artist, null, null);
        }

        /// <summary>
        ///  Get a paginated list of all the events this artist has played at in the past.
        /// </summary>
        /// <param name="artist">The artist name in question.</param>
        /// <param name="limit">The maximum number of results to return per page</param>
        /// <param name="page">The page of results to return.</param>
        /// <returns>past events by the artist</returns>
        public LastfmResponse<EventsList> artistGetPastEvents(string artist, int? page, int? limit)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "artist.getpastevents");
            request.AddParameter("artist", artist);
            if (page != null)
                request.AddParameter("page", page);
            if (limit != null)
                request.AddParameter("limit", limit);

            return Execute<LastfmResponse<EventsList>>(request).Data;
        }

        #endregion

        //TODO: find an artist with a podcast that will actually work....
        #region artist.getPodcast

        /// <summary>
        /// Get a podcast of free mp3s based on an artist
        /// </summary>
        /// <param name="artist">The Artist name in question.</param>
        /// <returns></returns>
        public LastfmResponse<PodcastChannel> artistGetPodcast(string artist)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "artist.getpodcast");
            request.AddParameter("artist", artist);

            return Execute<LastfmResponse<PodcastChannel>>(request).Data;
        }

        #endregion

        #region artist.getShouts

        /// <summary>
        /// Get shouts for this artist.
        /// </summary>
        /// <param name="artist">The artist name in question</param>
        /// <returns>A paged list of shouts for this artist</returns>
        public LastfmResponse<ShoutList> artistGetShouts(string artist)
        {
            return artistGetShouts(artist, null, null);
        }


        /// <summary>
        /// Get shouts for this artist.
        /// </summary>
        /// <param name="artist">The artist name in question</param>
        /// <param name="limit">An integer used to limit the number of shouts returned per page. The default is 50.</param>
        /// <param name="page">The page number to fetch.</param>
        /// <returns>A paged list of shouts for this artist</returns>
        public LastfmResponse<ShoutList> artistGetShouts(string artist, int? page, int? limit)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "artist.getshouts");
            request.AddParameter("artist", artist);
            if (page != null)
                request.AddParameter("page", page);
            if (limit != null)
                request.AddParameter("limit", limit);

            return Execute<LastfmResponse<ShoutList>>(request).Data;
        }

        #endregion

        #region artist.getSimilar

        //TODO: add summary.

        /// <summary>
        /// Get all the artists similar to this artist
        /// </summary>
        /// <param name="artist">The artist name in question</param>
        /// <returns>artists similar to this artist</returns>
        public LastfmResponse<SimilarArtistList> artistGetSimilar(string artist)
        {
            return artistGetSimilar(artist, null);
        }

        /// <summary>
        /// Get all the artists similar to this artist
        /// </summary>
        /// <param name="artist">The artist name in question</param>
        /// <param name="limit">Limit the number of similar artists returned.</param>
        /// <returns>artists similar to this artist</returns>
        public LastfmResponse<SimilarArtistList> artistGetSimilar(string artist, int? limit)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "artist.getsimilar");
            request.AddParameter("artist", artist);
            if (limit != null)
                request.AddParameter("limit", limit);

            return Execute<LastfmResponse<SimilarArtistList>>(request).Data;
        }
        #endregion

        #region artist.getTags

        /// <summary>
        /// Get the tags applied by an individual user to an artist on Last.fm.
        /// </summary>
        /// <param name="artist"></param>
        /// <returns></returns>
        public LastfmResponse<TagList> artistGetTags(string artist)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "artist.gettags");
            request.AddParameter("artist", artist);

            //TODO: this requires authentication for some reason. so for now, it does nothing.
            return Execute<LastfmResponse<TagList>>(request).Data;
        }

        #endregion

        #region artist.getTopAlbums

        /// <summary>
        /// Get the top albums for an artist on Last.fm, ordered by popularity.
        /// </summary>
        /// <param name="artist">The artist name in question</param>
        /// <returns>The top albums for an artist on Last.fm, ordered by popularity.</returns>
        public LastfmResponse<TopAlbumsLists> artistGetTopAlbums(string artist)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "artist.gettopalbums");
            request.AddParameter("artist", artist);

            //TODO: this requires authentication for some reason. so for now, it does nothing.
            return Execute<LastfmResponse<TopAlbumsLists>>(request).Data;
        }


        #endregion

        #region artist.getTopFans

        /// <summary>
        /// Get the top fans for an artist on Last.fm, based on listening data. 
        /// </summary>
        /// <param name="artist">The artist name in question</param>
        /// <returns>Get the top fans for an artist on Last.fm, based on listening data.</returns>
        public LastfmResponse<FanList> artistGetTopFans(string artist)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "artist.gettopfans");
            request.AddParameter("artist", artist);

            //TODO: this requires authentication for some reason. so for now, it does nothing.
            return Execute<LastfmResponse<FanList>>(request).Data;
        }


        #endregion

        #region artist.getTopTags

        /// <summary>
        /// Get the top tags for an artist on Last.fm, ordered by popularity. 
        /// </summary>
        /// <param name="artist">The artist name in question</param>
        /// <returns>Get the top tags for an artist on Last.fm, ordered by popularity.</returns>
        public LastfmResponse<TopTagList> artistGetTopTags(string artist)
        {
            var request = new RestRequest(Method.GET);
            request.AddParameter("method", "artist.gettoptags");
            request.AddParameter("artist", artist);

            //TODO: this requires authentication for some reason. so for now, it does nothing.
            return Execute<LastfmResponse<TopTagList>>(request).Data;
        }


        #endregion
    }
}
