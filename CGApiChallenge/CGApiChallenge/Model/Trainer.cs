using System.Text.Json.Serialization;

namespace CGApiChallenge.Model
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
    }
}
