using Microsoft.AspNetCore.Identity;

namespace DataAccess.Data.Entities
{
    public class User : IdentityUser, BaseEntities
    {
        public string? Country { get; set; }

        // navigation properties
        public ICollection<Review>? Reviews { get; set; }
    }
}
