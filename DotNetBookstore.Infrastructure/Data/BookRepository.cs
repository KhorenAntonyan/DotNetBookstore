using DotNetBookstore.Core.Entities;
using DotNetBookstore.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBookstore.Infrastructure.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<IReadOnlyList<Book>> GetBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }
    }
}
