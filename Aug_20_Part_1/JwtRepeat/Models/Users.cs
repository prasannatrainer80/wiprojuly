using System.ComponentModel.DataAnnotations;

namespace JwtRepeat.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }  
    }
}
