using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Entities
{
    public class Review : BaseEntities
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string UserId { get; set; }
        public double Rating { get; set; } 
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        // navigation properties
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
