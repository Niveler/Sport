using System.Text.Json.Serialization;

namespace Sport.Models
{
    public class Complex
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("operationmode")]
        public string OperationMode { get; set; }
        [JsonPropertyName("adress")]

        public string Adress { get; set; }
        [JsonPropertyName("number")]
        public string Numper { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName ("img")]
        public byte[] Img { get; set; }
        public List<Event> Events { get; set; }
        public Complex() { }
       
    }
}
