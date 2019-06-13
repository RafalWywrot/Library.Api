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
        public bool Status { get; set; }
        public int Name { get; set; }
        public int Surname { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
