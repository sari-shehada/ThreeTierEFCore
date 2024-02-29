using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities;
public class Author
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public string Name { get; set; } = string.Empty;

    public IList<Book> Books { get; set; }
}
