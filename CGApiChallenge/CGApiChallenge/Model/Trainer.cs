using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGApiChallenge.Model
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}
