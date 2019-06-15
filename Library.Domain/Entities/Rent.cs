using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Rent
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Contact { get; set; }
        public DateTime? From { get; set; }
    }
}
