using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Sport.Models
{
    public class Person
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("famile")]
        public string Famile{ get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
        [JsonPropertyName("role")]
        public string Role { get; set; }
        [JsonPropertyName("img")]
        public byte[] Img { get; set; }
    }
}
