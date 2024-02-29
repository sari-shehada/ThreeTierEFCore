
using DataAccessLayer.Contracts;
using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;
public class BookRepository : IBookRepository
{
    private readonly ApplicationDbContext _context;

    public BookRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Book>> GetAll()
    {
        return await _context.Books.ToListAsync();
    }

    public async Task<Book> GetById(Guid id)
    {
        return await _context.Books.Where((b) => b.Id == id).FirstAsync();
    }

    public async Task<Book> Insert(Book entity)
    {
        var result = await _context.AddAsync(entity);
        return result.Entity;
    }

    public async Task<Book> Update(Book entity)
    {
        return entity;
        // var result = await _context.Books.Where((b)=>b.Id==entity.Id).;
        // return result.Entity;
    }
}
