using System.Text.Json.Serialization;

namespace Sport.Models
{
    public class Event
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("timedate")]
        public string Timedate { get; set; }
        [JsonPropertyName("place")]
        public string Place { get; set; }
        [JsonPropertyName("complexId")]
        public string ComplexId { get; set; }
        public Complex Complex { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
