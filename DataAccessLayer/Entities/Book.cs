using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities;

public class Book
{

    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public Guid AuthorId { get; set; }
    public Author Author { get; set; } = new() { };
}
