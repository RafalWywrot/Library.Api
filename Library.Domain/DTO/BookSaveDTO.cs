using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.DTO
{
    public class BookSaveDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public int Year { get; set; }
        public int PublishHouseId { get; set; }
        public int ArtistId { get; set; }
        public int CategoryId { get; set; }
    }
}
