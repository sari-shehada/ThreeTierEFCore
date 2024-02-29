using BusinessLogicLayer.Models;

namespace BusinessLogicLayer.Interfaces;
public interface IAuthorService
{
    Task<IEnumerable<AuthorDTO>> getAllAuthorsAsync();
}
