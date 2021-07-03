using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetBookstore.Core.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public string EditionLanguage { get; set; }
        public int NumberOfPages { get; set; }
        public int YearOfIssue { get; set; }
        public decimal Price { get; set; }
    }
}
