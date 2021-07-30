using System.Text.Json.Serialization;

namespace Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
}