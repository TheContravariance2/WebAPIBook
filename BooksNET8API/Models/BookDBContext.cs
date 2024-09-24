using BooksNET8API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksNET8API.Models
{
    public class BookDBContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {

        }
        
    }
}