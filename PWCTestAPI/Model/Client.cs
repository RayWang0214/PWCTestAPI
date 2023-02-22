using System.Text.Json.Serialization;

namespace PWCTestAPI.Model
{
    public class Client
    {
        public Guid Id { get; set; }
        public string? ClientName { get; set; }
        public string? ClientEmail { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
