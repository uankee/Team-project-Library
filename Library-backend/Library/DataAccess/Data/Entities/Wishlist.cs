using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Entities
{
    public class Wishlist : BaseEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int BookId { get; set; }

        // navigation properties
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
