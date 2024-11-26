using LibrisApi.Communication.Requests;
using LibrisApi.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LibrisApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisterBookJson
        {
            Id = 1,
            Title = request.Title,
        };

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>()
        {
            new Book { Id = 1, Title = "Livro A", Author = "Autor 1", Gender = Book.Genders.Ficção, Price = 20.50, Quantity = 30},
            new Book { Id = 2, Title = "Livro B", Author = "Autor 2", Gender = Book.Genders.Mistério, Price = 40.59, Quantity = 10},
            new Book { Id = 3, Title = "Livro C", Author = "Autor 3", Gender = Book.Genders.Romance, Price = 12, Quantity = 25},
        };

        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById(int id)
    {
        var response = new Book { Id = 1, Title = "Livro A", Author = "Autor 1", Gender = Book.Genders.Ficção, Price = 20.50, Quantity = 30 };

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateBookProfileJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }
}
