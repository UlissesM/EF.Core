using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.First.Entities
{
    public class BookDetails
    {
        public int Id { get; set; }
        public string Language { get; set; }
        public int PageNumbers { get; set; }
        public bool IsAvailable { get; set; }

    }
}
