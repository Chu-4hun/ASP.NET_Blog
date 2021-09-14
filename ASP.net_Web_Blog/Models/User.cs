using System.ComponentModel.DataAnnotations;

namespace ASP.net_Web_Blog.Models
{
    public class User
    {
        [Key]
        
        public int Id { get; set; }
        
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}