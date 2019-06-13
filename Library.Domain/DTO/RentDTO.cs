using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.DTO
{
    public class RentDTO
    {
        public int Id { get; set; }
        public BookDTO Book { get; set; }
        public bool Available { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
