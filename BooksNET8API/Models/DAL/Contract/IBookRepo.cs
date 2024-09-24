using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksNET8API.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BooksNET8API.Models.DAL.Contract
{
    public interface IBookRepo
    {
        Task<ActionResult<IEnumerable<Book>>> GetBooks();
        Task<ActionResult<Book>> GetBook(int id);
        Task<IActionResult> PutBook(int id, Book book);
        Task<ActionResult<Book>> PostBook(Book book);
        Task<IActionResult> DeleteBook(int id);
    }
}