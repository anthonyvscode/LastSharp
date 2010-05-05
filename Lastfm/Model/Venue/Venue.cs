
namespace Lastfm.Model
{
    public class Venue
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public string Url { get; set; }
        public string Website { get; set; }
        public string Phonenumber { get; set; }
        public ImageListMini Image { get; set; }
    }
}
