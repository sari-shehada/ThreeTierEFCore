using DataAccessLayer.Contracts;
using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;
public class AuthorRepository : IAuthorRepository
{
    private readonly ApplicationDbContext _context;

    public AuthorRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Author>> GetAll()
    {
        return await _context.Authors.ToListAsync();
    }

    public async Task<Author> GetById(Guid id)
    {
        return await _context.Authors.Where((a) => a.Id == id).FirstAsync();
    }

    public async Task<Author> Insert(Author entity)
    {
        var result = await _context.AddAsync(entity);
        return result.Entity;
    }

    public async Task<Author> Update(Author entity)
    {
        return entity;
        // var result = await _context.Books.Where((b)=>b.Id==entity.Id).;
        // return result.Entity;
    }
}
