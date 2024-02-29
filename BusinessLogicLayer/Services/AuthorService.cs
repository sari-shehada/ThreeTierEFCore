using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Models;
using DataAccessLayer;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;


namespace BusinessLogicLayer.Services;
public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
    public async Task<IEnumerable<AuthorDTO>> getAllAuthorsAsync()
    {
        var result = await _authorRepository.GetAll();
        return result.Select(AuthorDTO.FromAuthor);
    }
}
