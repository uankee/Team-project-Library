using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Configurations.DTOs.AuthorDto
{
    public class UpdateAuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}
