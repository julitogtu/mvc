using Enums.Enums;

namespace Enums.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        public string Name { get; set; }

        public ClientType ClientType { get; set; }
    }
}