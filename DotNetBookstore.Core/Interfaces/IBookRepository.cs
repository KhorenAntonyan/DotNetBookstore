using DotNetBookstore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBookstore.Core.Interfaces
{
    public interface IBookRepository
    {
        Task<Book> GetBookByIdAsync(int id);
        Task<IReadOnlyList<Book>> GetBooksAsync();
    }
}
