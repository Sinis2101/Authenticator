using System.ComponentModel.DataAnnotations;

namespace Authenticator.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

    }
}
