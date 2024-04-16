using Microsoft.AspNetCore.Identity;

namespace Core.Entities
{
    public class User : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Card>? Cards { get; set; }
    }
}
