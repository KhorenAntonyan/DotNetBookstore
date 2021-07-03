using DotNetBookstore.Core.Entities;
using DotNetBookstore.Core.Interfaces;
using DotNetBookstore.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetBookstore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public ProductsController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetProducts()
        {
            var books = await _bookRepository.GetBooksAsync();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetProduct(int id)
        {
            return await _bookRepository.GetBookByIdAsync(id);
        }
    }
}
