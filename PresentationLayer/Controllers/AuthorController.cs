using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers;

public class AuthorController : ControllerBase
{
    private readonly IAuthorService _authorService;

    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    [Route("/Authors")]
    [HttpGet]
    public async Task<IActionResult> GetAllAuthors()
    {
        return Ok(await _authorService.getAllAuthorsAsync());
    }
}
