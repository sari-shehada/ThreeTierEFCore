using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Models;
public class AuthorDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;


    public static AuthorDTO FromAuthor(Author author)
    {
        return new()
        {
            Id = author.Id,
            Name = author.Name,
        };
    }
}
