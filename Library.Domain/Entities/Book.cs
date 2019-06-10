using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public int Year { get; set; }
        public int CategoryId { get; set; }
        public int PublishHouseId { get; set; }
        public int ArtistId{ get; set; }
        public virtual Category Category { get; set; }
        public virtual PublishHouse PublishHouse { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
