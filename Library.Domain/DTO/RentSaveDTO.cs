﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.DTO
{
    public class RentSaveDTO
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? From { get; set; }
    }
}
