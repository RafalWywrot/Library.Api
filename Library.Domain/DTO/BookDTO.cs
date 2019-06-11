using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public int Year { get; set; }
        public CategoryDTO Category { get; set; }
        public PublishHouseDTO PublishHouse { get; set; }
        public ArtistDTO Artist { get; set; }
    }
}
