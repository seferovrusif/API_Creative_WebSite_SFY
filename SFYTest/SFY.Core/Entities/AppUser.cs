using Microsoft.AspNetCore.Identity;

namespace SFY.Core.Entities
{
    public class AppUser: IdentityUser
    {
        public string Fullname { get; set; }
        public DateTime BirthDate { get; set; }
        public IEnumerable<Bag> Bags { get; set; }
    }
}
