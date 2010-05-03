.NET C# Client for the Last.fm API

Example usage:

        LastfmApi _lastfm = new LastfmApi("b25b959554ed76058ac220b7b2e0a026");
		
		var artist = _lastfm.artistGetInfo("Blur");

		Console.WriteLine(artist.bio);